namespace PrincipiosSOLID.SOLID.I___Interface_Segregation.Problem
{
    public class Program
    {
        public void Main(string[] args) {

            BurgerOrderService service = new BurgerOrderService();
            service.OrderBurguer(2);


        }

    }
}
