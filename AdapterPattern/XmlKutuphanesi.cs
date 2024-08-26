namespace AdapterPattern
{
    public class XmlKutuphanesi
    {
        public string XmlVerisiAl()
        {
            string xmlVerisi = "<Kullanici><Ad>habibe</Ad><Soyad>bayram</Soyad></Kullanici>";
            Console.WriteLine("Xml Formatındaki veri: " + xmlVerisi + "\n");
            // Örnek bir XML verisi döndürelim
            return xmlVerisi;
        }
    }
}
