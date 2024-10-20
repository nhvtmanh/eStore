using BusinessObject;
using DataAccess.DAOs;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDAO _orderDAO;

        public OrderRepository(EStoreDbContext context)
        {
            _orderDAO = new OrderDAO(context);
        }

        public IEnumerable<Order> GetAllOrders() => _orderDAO.GetAllOrders();

        public Order GetOrderById(int orderId) => _orderDAO.GetOrderById(orderId);

        public void AddOrder(Order order) => _orderDAO.AddOrder(order);

        public void UpdateOrder(Order order) => _orderDAO.UpdateOrder(order);

        public void DeleteOrder(int orderId) => _orderDAO.DeleteOrder(orderId);
    }
}
