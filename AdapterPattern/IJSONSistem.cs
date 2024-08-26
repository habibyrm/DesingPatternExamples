namespace AdapterPattern
{
    public interface IJSONSistem
    {
        string JsonToXml(string json);

        string XmlToJson(string xml);
    }
}
