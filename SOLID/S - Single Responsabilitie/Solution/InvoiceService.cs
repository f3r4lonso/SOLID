namespace PrincipiosSOLID.SOLID.S.Solution
{
    interface IInvoiceService
    {
        public Invoice CreateInvoice(Order order);

    }
    public class InvoiceService : IInvoiceService
    {
        public Invoice CreateInvoice(Order order)
        {

            return new Invoice();
        }
    }
}
