namespace ProxyPattern.Protection
{
    public class FileProcess : IFileProcess
    {
        public void DeleteFile(string fileName)
        {
            Console.WriteLine($"{fileName} dosyası silindi.");
        }
    }
}
