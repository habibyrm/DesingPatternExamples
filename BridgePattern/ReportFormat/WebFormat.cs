namespace BridgePattern.ReportFormat
{
    public class WebFormat : IReportFormat
    {
        public void Generate()
        {
            Console.WriteLine("Rapor Web Formatında oluşturuldu");
        }
    }
}
