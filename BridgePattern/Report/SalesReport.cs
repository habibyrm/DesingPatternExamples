using BridgePattern.ReportFormat;

namespace BridgePattern.Report
{
    public class SalesReport : Report
    {
        public SalesReport(IReportFormat format) : base(format) { }
        public override void Display()
        {
            Console.WriteLine("---Satış Raporu---");
            base.Display();
        }
    }
}
