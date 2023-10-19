using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace BuilderDesignPattern
{
    public class BuilderImplementation
    {
        private const int indentSize = 2;
        public string Impl(int indent, HtmlElement htmlElement)
        {
            var stringBuilder = new StringBuilder();
            var i = new string(' ', indentSize * indent); 
            stringBuilder.Append($"{i}<{htmlElement.Name}>");
            stringBuilder.Append('\n');

            if (!string.IsNullOrEmpty(htmlElement.Text))
            {
                var j = new string(' ', indentSize * (indent + 1));
                stringBuilder.Append(j);
                stringBuilder.AppendLine(htmlElement.Text);
            }

            foreach (var item in htmlElement.Elements)
            {
                int imple = (indent + 1);
                stringBuilder.Append(Impl(imple, item));
                stringBuilder.Append('\n');

            }
            // closing
            stringBuilder.Append($"{i}</{htmlElement.Name}>");
            return stringBuilder.ToString();
        }
    }
}
