namespace PrincipiosSOLID.SOLID.O___Open_Close.Solution
{
    public interface IReportGenerator
    {
        void CreateReport(List<Order> orders);
    }
}