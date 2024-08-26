using Newtonsoft.Json;
using System.Xml;

namespace AdapterPattern
{
    // XmldenJsonaAdapter.cs
    public class XmlToJsonAdapter : IJSONSistem
    {
        public string JsonToXml(string json)
        {
            // JSON verisini XmlNode olarak deserialize et
            XmlDocument xmlDoc = JsonConvert.DeserializeXmlNode(json, "Kullanici");
            return xmlDoc.OuterXml;
        }

        public string XmlToJson(string xml)
        {
            // XML'i JSON'a dönüştürmek için XML dokümanını parse ediyoruz
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            // XML'den JSON'a dönüşüm
            string jsonVerisi = JsonConvert.SerializeXmlNode(doc);
            
            return jsonVerisi;
        }
    }

}
