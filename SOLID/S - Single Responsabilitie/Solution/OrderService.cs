namespace PrincipiosSOLID.SOLID.S.Solution
{
    internal class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ILogService _logService;
        private readonly IInvoiceService _invoiceService;
        private readonly IEmailService _emailService;

        public OrderService(IOrderRepository orderRepository, ILogService logService, IInvoiceService invoiceService, IEmailService emailService)
        {
            _orderRepository = orderRepository;
            _logService = logService;
            _invoiceService = invoiceService;
            _emailService = emailService;
        }

        public void SaveOrder(Order order)
        {
            try
            {
                _orderRepository.InertOrder(order);
                var invoice = _invoiceService.CreateInvoice(order);
                _emailService.SendInvoice(invoice);
                _logService.LogOrder(order);
            }
            catch (Exception e)
            {
                _logService.LogError(e.Message);
            }
        }
    }
}
