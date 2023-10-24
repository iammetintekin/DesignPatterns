using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    public class Field
    {
        public string Name { get; set; }
        public string DataType { get; set; }
    }
    public class CodeBuilder
    {
        private readonly string ClassName; 
        public List<Field> Fields { get; set; } = new();
        public CodeBuilder(string class_name)
        { 
            ClassName = class_name;
        } 
        public CodeBuilder AddField(string name, string type)
        {
            Fields.Add(new Field { Name = name, DataType = type });
            return this;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("public class " + ClassName);
            sb.AppendLine();  
            sb.Append("{");
            sb.AppendLine();
            foreach (Field field in Fields)
            {
                sb.Append("\tpublic "+field.DataType + " " + field.Name + " { get; set; }");
                sb.AppendLine(); 
            } 
            sb.Append("}");

            return sb.ToString();
        }
    }
}
