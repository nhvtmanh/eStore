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
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly OrderDetailDAO _orderDetailDAO;

        public OrderDetailRepository(EStoreDbContext context)
        {
            _orderDetailDAO = new OrderDetailDAO(context);
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails() => _orderDetailDAO.GetAllOrderDetails();

        public OrderDetail GetOrderDetailById(int orderId, int productId) => _orderDetailDAO.GetOrderDetailById(orderId, productId);

        public void AddOrderDetail(OrderDetail orderDetail) => _orderDetailDAO.AddOrderDetail(orderDetail);

        public void UpdateOrderDetail(OrderDetail orderDetail) => _orderDetailDAO.UpdateOrderDetail(orderDetail);

        public void DeleteOrderDetail(int orderId, int productId) => _orderDetailDAO.DeleteOrderDetail(orderId, productId);
    }
}
