namespace PrincipiosSOLID.SOLID.O___Open_Close.Solution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();

            ReportingService service = new ReportingService(new ReportGeneratorPDF());
            service.GenerateReport(orders);
        }
    }
}
