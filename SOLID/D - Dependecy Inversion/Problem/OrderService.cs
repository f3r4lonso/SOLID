namespace PrincipiosSOLID.SOLID.D___Dependecy_Inversion.Problem
{
    public class OrderService
    {
        public readonly DataDogService _service;

        public OrderService(DataDogService service)
        {
            _service = service;
        }

        public void GenerateOrder()
        {
            _service.LogEvent("The Order was succefully created");
        }
    }
}
