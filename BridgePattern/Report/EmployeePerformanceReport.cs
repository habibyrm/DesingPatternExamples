using BridgePattern.ReportFormat;

namespace BridgePattern.Report
{
    public class EmployeePerformanceReport : Report
    {
        public EmployeePerformanceReport(IReportFormat format) : base(format) { }
        public override void Display()
        {
            Console.WriteLine("---Çalışan Performans Raporu---");
            base.Display();
        }
    }
}
