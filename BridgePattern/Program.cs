using BridgePattern;
using BridgePattern.Report;
using BridgePattern.ReportFormat;

Report report = new EmployeePerformanceReport(new DesktopFormat());
report.Display();

Console.WriteLine("\n");

Report report2= new SalesReport(new WebFormat());
report2.Display();