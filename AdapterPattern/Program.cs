// Yeni XML kütüphanesi oluşturuluyor
using AdapterPattern;

var xmlKutuphanesi = new XmlKutuphanesi();
var jsonKutuphanesi = new JsonKutuphanesi();

// Adapter oluşturuluyor
var xmlToJsonAdapter = new XmlToJsonAdapter();
//dış servisten alındığı varsayılan json dosyasını string veriye aktarma
string xml = xmlKutuphanesi.XmlVerisiAl();

var jsonData = xmlToJsonAdapter.XmlToJson(xml);

Console.WriteLine("Dönüştürülmüş JSON Verisi: " + jsonData + "\n");
//dış servisten alındığı varsayılan json dosyasını string veriye aktarma
string json = jsonKutuphanesi.JsonVerisiAl();
var xmlData = xmlToJsonAdapter.JsonToXml(json);

Console.WriteLine("Dönüştürülmüş XML Verisi: " + xmlData);