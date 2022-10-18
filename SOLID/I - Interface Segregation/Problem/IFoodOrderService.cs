namespace PrincipiosSOLID.SOLID.I___Interface_Segregation.Problem
{
    internal interface IFoodOrderService
    {
        public void OrderBurguer(int qty) { }
        public void OrderStake(int qty) { }
        public void OrderSalad(int qty) { }
    }
}
