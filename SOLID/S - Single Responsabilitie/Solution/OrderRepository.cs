using System.Reflection.Metadata.Ecma335;

namespace PrincipiosSOLID.SOLID.S.Solution
{
    internal interface IOrderRepository
    {
        public void InertOrder(Order order);    
    }
    public class OrderRepository : IOrderRepository
    {

        public void InertOrder(Order order) 
        { 

        }
    }
}
