namespace PrincipiosSOLID.SOLID.O___Open_Close.Solution
{
    internal class ReportingService
    {
        private readonly IReportGenerator _reportGenerator;

        public ReportingService(IReportGenerator reportGenerator)
        {
            _reportGenerator = reportGenerator;
        }

        public void GenerateReport(List<Order> orders) 
        {
        _reportGenerator.CreateReport(orders);
        }

    }
}
