using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;
class JsonToXml
{
    static void Main()
    {
        string jsonData = @"{ 'name':'Alice','age':30,'city':'Delhi' }";
        JObject obj = JObject.Parse(jsonData);
        XmlDocument xml = JsonConvert.DeserializeXmlNode(obj.ToString(), "Root");
        Console.WriteLine(xml.OuterXml);
    }
}
