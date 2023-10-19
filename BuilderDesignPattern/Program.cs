using BuilderDesignPattern;
using System.Text;

// --------------   No Builder Pattern  ---------------
var sb = new StringBuilder();
var words = new[] { "hello", "world" };
sb.Append("<ul>");
sb.Append('\n'); 
foreach (var word in words)
{
    sb.AppendFormat("<li>{0}</li>", word);
    sb.Append('\n');
}
sb.Append("</ul>");
Console.WriteLine(sb);

// --------------   Builder Pattern  ---------------

// daha anlaşılır olması için html implemantasyon yapıyoruz

BuilderImplementation imp = new BuilderImplementation();
var html_element = new HtmlElement("html", "");
var head_element = new HtmlElement("head","");

head_element.Elements.Add(new HtmlElement("title","My Webpage"));
html_element.Elements.Add(head_element);

var body_element = new HtmlElement("body", "");

var table_element = new HtmlElement("table", "");
var tr_element = new HtmlElement("tr", "");
var td_element = new HtmlElement("td", "this topic is so important");
var p_element = new HtmlElement("p", "o this is a very well known approach in object oriented design, which is called a fluent interface,an interface which allows you to chain several calls by returning a reference to the object you're working with.");

tr_element.Elements.Add(td_element);
table_element.Elements.Add(tr_element);
body_element.Elements.Add(table_element);
body_element.Elements.Add(p_element);
html_element.Elements.Add(body_element);

Console.WriteLine(imp.Impl(0, html_element));
