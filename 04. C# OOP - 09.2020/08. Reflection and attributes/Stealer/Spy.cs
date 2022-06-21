using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, string[] requestedFields)
        {
            var type = Type.GetType(investigatedClass);

            FieldInfo[] classFields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            var sb = new StringBuilder();

            Object classIntance = Activator.CreateInstance(type, new object[] { });

            sb.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classIntance)}");
            }


            return sb.ToString().TrimEnd();
        }

        public string AnalyzeAcessModifiers(string investigatedClassName)
        {
            var type = Type.GetType(investigatedClassName);

            FieldInfo[] classFields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classPublicMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classNonPublicMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            foreach (var field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (var method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }
            foreach (var method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            return sb.ToString().TrimEnd();
        }

        public string RevealPrivateMethods(string investigatedClassName)
        {
            Type type = Type.GetType(investigatedClassName);

            MethodInfo[] classPrivateMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"All Private Methods of Class: {type.Namespace}.{type.Name}")
                .AppendLine($"Base Class: {type.BaseType.Name}");

            foreach (var method in classPrivateMethods)
            {
                sb.AppendLine(method.Name);
            }

            return sb.ToString().TrimEnd();
        }

        public string CollectGettersAndSetters(string investigatedClassName)
        {
            Type type = Type.GetType(investigatedClassName);

            MethodInfo[] classMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder sb = new StringBuilder();

            foreach (var method in classMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (var method in classMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
