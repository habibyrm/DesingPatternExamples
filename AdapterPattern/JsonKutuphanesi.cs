namespace AdapterPattern
{
    public class JsonKutuphanesi
    {
        public string JsonVerisiAl()
        {
            string jsonVerisi = "{\"Kullanici\":{\"Ad\":\"habibe\",\"Soyad\":\"bayram\"}}";
            Console.WriteLine("Json Formatındaki veri: " + jsonVerisi + "\n");
            // Örnek bir Json verisi döndürelim
            return jsonVerisi;
        }
    }
}
