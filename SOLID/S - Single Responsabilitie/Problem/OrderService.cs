namespace PrincipiosSOLID.SOLID.S.Problem
{
    internal class OrderService
    {

        public void SaveOrder(Order order)
        {
            try
            {
                this.InsertOrder(order);

                var invoice = this.CreateInvoice(order);

                this.EmailInvoice(invoice);

                File.WriteAllText(@"c:\InfoLog.txt", "The Order has bean completed.");

            }
            catch (Exception e)
            {
                File.WriteAllText(@"c:\ErrorLog.txt", e.Message);
            }
        }

        private void EmailInvoice(object invoice)
        {
            throw new NotImplementedException();
        }

        private object CreateInvoice(Order order)
        {
            throw new NotImplementedException();
        }

        private void InsertOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
