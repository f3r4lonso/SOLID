namespace PrincipiosSOLID.SOLID.S.Solution
{
    interface ILogService
    {
        public void LogError(string error);

        public void LogOrder(Order order);
    }
    public class LogService
    {
        public void LogError(string error) { }

        public void LogOrder(Order order) { }

    }
}
