namespace TeisterMask.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using TeisterMask.DataProcessor.ExportDto;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportProjectWithTheirTasks(TeisterMaskContext context)
        {
            var data = context.Projects.ToList()
                  .Where(p => p.Tasks.Count() > 0)
                  .Select(p => new ProjectXmlExportModel
                  {
                      TasksCount = p.Tasks.Count(),
                      ProjectName = p.Name,
                      HasEndDate = p.DueDate == null ? "No" : "Yes",
                      Tasks = p.Tasks.Select(pt => new TasksXmlExportModel
                      {
                          Name = pt.Name,
                          Label = pt.LabelType.ToString(),
                      }).OrderBy(t => t.Name).ToArray()
                  }).OrderByDescending(p => p.TasksCount).ThenBy(p => p.ProjectName).ToArray();
            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProjectXmlExportModel[]), new XmlRootAttribute("Projects"));

            var sw = new StringWriter();
          
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            xmlSerializer.Serialize(sw, data, ns);
            return sw.ToString();
        }

        public static string ExportMostBusiestEmployees(TeisterMaskContext context, DateTime date)
        {
            var employees = context.Employees.ToList()
                .Select(y => new
                {
                    Username = y.Username,
                    Tasks = y.EmployeesTasks.Where(yt => yt.Task.OpenDate >= date)
                    .Select(yt => new
                    {
                        TaskName = yt.Task.Name,
                        OpenDate = yt.Task.OpenDate.ToString("d", CultureInfo.InvariantCulture),
                        DueDate = yt.Task.DueDate.ToString("d", CultureInfo.InvariantCulture),
                        LabelType = yt.Task.LabelType.ToString(),
                        ExecutionType = yt.Task.ExecutionType.ToString(),
                    })
                })
                .OrderByDescending(y => y.Tasks.Count())
                .ThenBy(y => y.Username)
                .Take(10)
                .ToList();

            return JsonConvert.SerializeObject(employees, Formatting.Indented);
        }
    }
}