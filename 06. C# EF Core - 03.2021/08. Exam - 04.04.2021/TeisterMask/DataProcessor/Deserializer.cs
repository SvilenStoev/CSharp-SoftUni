namespace TeisterMask.DataProcessor
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using TeisterMask.Data.Models;
    using TeisterMask.Data.Models.Enums;
    using TeisterMask.DataProcessor.ImportDto;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedProject
            = "Successfully imported project - {0} with {1} tasks.";

        private const string SuccessfullyImportedEmployee
            = "Successfully imported employee - {0} with {1} tasks.";

        public static string ImportProjects(TeisterMaskContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var xmlSerializer = new XmlSerializer(typeof(ProjectsXmlInputModel[]), new XmlRootAttribute("Projects"));
            var projects = (ProjectsXmlInputModel[])xmlSerializer.Deserialize(new StringReader(xmlString));

            foreach (var xmlProject in projects)
            {
                if (!IsValid(xmlProject))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                bool parsedOpenDate = DateTime.TryParseExact(xmlProject.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var openDate);
                bool parsedDueDate = DateTime.TryParseExact(xmlProject.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dueDate2);

                DateTime? dueDate = dueDate2;

                if (!parsedOpenDate || !parsedDueDate)
                {
                    if (!parsedDueDate)
                    {
                        dueDate = null;
                    }
                    else
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                }

                var project = new Project
                {
                    Name = xmlProject.Name,
                    OpenDate = openDate,
                    DueDate = dueDate,
                };
                foreach (var xmlTask in xmlProject.Tasks)
                {
                    if (!IsValid(xmlTask))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    bool parsedTaskOpenDate = DateTime.TryParseExact(xmlTask.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var taskOpenDate);
                    bool parsedTaskDueDate = DateTime.TryParseExact(xmlTask.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var taskDueDate);

                    if (!parsedTaskOpenDate || !parsedTaskDueDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    if (taskOpenDate < openDate || taskDueDate > dueDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var task = context.Tasks.FirstOrDefault(x => x.Name == xmlTask.Name)
                        ?? new Task
                        {
                            Name = xmlTask.Name,
                            DueDate = taskDueDate,
                            OpenDate = taskOpenDate,
                            ExecutionType = (ExecutionType)xmlTask.ExecutionType, //Parse?
                            LabelType = (LabelType)xmlTask.LabelType,
                        };

                    project.Tasks.Add(task);
                    context.SaveChanges();
                }

                context.Projects.Add(project);

                sb.AppendLine($"Successfully imported project - {project.Name} with {project.Tasks.Count()} tasks.");
            }

            context.SaveChanges();
            return sb.ToString();
        }

        public static string ImportEmployees(TeisterMaskContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var employees = JsonConvert.DeserializeObject<IEnumerable<EmployeeJsonImportModel>>(jsonString);

            foreach (var jsonEmployee in employees)
            {
                if (!IsValid(jsonEmployee))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var employee = new Employee
                {
                    Username = jsonEmployee.Username,
                    Email = jsonEmployee.Email,
                    Phone = jsonEmployee.Phone,
                };

                int taskAdded = 0;

                foreach (var jsonTask in jsonEmployee.Tasks)
                {
                    var task = context.Tasks.FirstOrDefault(x => x.Id == jsonTask);

                    if (task == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    employee.EmployeesTasks.Add(new EmployeeTask { Task = task });
                    taskAdded++;
                    context.SaveChanges();
                }

                context.Employees.Add(employee);
                context.SaveChanges();
                sb.AppendLine(string.Format(SuccessfullyImportedEmployee, jsonEmployee.Username, taskAdded));
            }

            return sb.ToString();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}