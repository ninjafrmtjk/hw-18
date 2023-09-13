using Crm.DataAccess;

namespace Crm.BusinessLogic;

public sealed class StatisticsService : IStatisticsService
{
    private readonly IOrderRepository _orderRepository;

    public StatisticsService(IOrderRepository  orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public int GetClientCount()
    {
        return _clientRepository.GetAll().Count;
    }

    public int GetOrderCount() => _orderRepository.GetOrderCount();

    public int GetOrderCount(OrderState orderState) => _orderRepository.GetOrderCount(orderState);

    private readonly IClientRepository _clientRepository;

    public StatisticsServiceClient(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }
}