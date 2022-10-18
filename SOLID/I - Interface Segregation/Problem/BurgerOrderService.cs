namespace PrincipiosSOLID.SOLID.I___Interface_Segregation.Problem
{
    public class BurgerOrderService : IFoodOrderService
    {
        public void OrderBurguer(int qty)
        {
            /// Order Burguer
        }
        public void OrderStake(int qty)
        {
            throw new NotImplementedException();
        }
        public void OrderSalad(int qty)
        {
            throw new NotImplementedException();
        }
    }
}
