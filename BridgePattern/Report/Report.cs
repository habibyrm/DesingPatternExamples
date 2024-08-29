using BridgePattern.ReportFormat;

namespace BridgePattern.Report
{
    public abstract class Report
    {
        public IReportFormat ReportFormat { get; set; }

        public Report(IReportFormat reportFormat)
        {
            ReportFormat = reportFormat;
        }
        public virtual void Display()
        {
            ReportFormat.Generate();
        }
    }
}
