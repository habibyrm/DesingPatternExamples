namespace BridgePattern.ReportFormat
{
    public class DesktopFormat : IReportFormat
    {
        public void Generate()
        {
            Console.WriteLine("Rapor Desktop Formatında oluşturuldu");
        }
    }
}
