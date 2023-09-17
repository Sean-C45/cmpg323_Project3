using Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class orderRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();
        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }
    }
}
