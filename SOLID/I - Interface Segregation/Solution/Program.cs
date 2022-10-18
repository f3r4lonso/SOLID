namespace PrincipiosSOLID.SOLID.I___Interface_Segregation.Solution
{
    public class Program
    {
        public void Main(string[] args) 
        {
            BurgerService service = new BurgerService();
            service.OrderBuerguer(2);
        }
    }
}
