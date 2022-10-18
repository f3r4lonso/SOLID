namespace PrincipiosSOLID.SOLID.O___Open_Close
{
    public class ReportingServices
    {
        public void CreateReport(List<Order> orders, ReportType type)
        {
            if (type == ReportType.PDF)
            {
                this.CreatePDFReport(orders);
            }
            else if (type == ReportType.Excel)
            {
                this.CreateExcelReport(orders);
            }
        }
        public void CreatePDFReport(List<Order> orders)
        {
            ///create PDF report.
        }
        public void CreateExcelReport(List<Order> orders)
        {
            ///create Excel report.
        }
    }
}
