using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAOs
{
    public class OrderDetailDAO
    {
        private readonly EStoreDbContext _dbContext;

        public OrderDetailDAO(EStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return _dbContext.OrderDetails.ToList();
        }

        public OrderDetail GetOrderDetailById(int orderId, int productId)
        {
            return _dbContext.OrderDetails.Find(orderId, productId);
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            _dbContext.OrderDetails.Add(orderDetail);
            _dbContext.SaveChanges();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            _dbContext.OrderDetails.Update(orderDetail);
            _dbContext.SaveChanges();
        }

        public void DeleteOrderDetail(int orderId, int productId)
        {
            var orderDetail = _dbContext.OrderDetails.Find(orderId, productId);
            if (orderDetail != null)
            {
                _dbContext.OrderDetails.Remove(orderDetail);
                _dbContext.SaveChanges();
            }
        }
    }
}
