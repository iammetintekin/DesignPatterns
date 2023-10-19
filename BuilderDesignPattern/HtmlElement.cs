using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public HtmlElement()
        {
            
        }
        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }
        public List<HtmlElement> Elements = new();
    }
}
