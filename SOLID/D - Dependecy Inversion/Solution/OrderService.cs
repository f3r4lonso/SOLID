namespace PrincipiosSOLID.SOLID.D___Dependecy_Inversion.Solution
{
    public class OrderService
    {
        public readonly ILoggerService service;

        public OrderService (ILoggerService service)
        {
            this.service = service;
        }

        public void GenerateOrder()
        {
            service.LogMessage("The Order was succefully created");
        }
    }
}
