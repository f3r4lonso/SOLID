namespace PrincipiosSOLID.SOLID.S.Solution
{
    interface IEmailService
    {
        public void SendInvoice(Invoice invoice);
    }
    public class EmailService : IEmailService
    {
        public void SendInvoice(Invoice invoice) { }
    }
}
