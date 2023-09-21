using Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class orderRepository : GenericRepository<Order>, IOrderRepository
    {
        public orderRepository(SuperStoreContext context) : base(context)
        {
        }

        public Order GetMostRecentOrder()
        {
            return _context.Orders.OrderByDescending(Order => Order.OrderId).FirstOrDefault();

        }

    }
}
