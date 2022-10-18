namespace PrincipiosSOLID.SOLID.O___Open_Close.Problem
{
    internal class Program
    {
        public static void Mian(string[] args)
        {
            List<Order> orders = new List<Order>();
            ReportingServices service = new ReportingServices();
            service.CreateReport(orders, ReportType.PDF);
        }
    }
}
