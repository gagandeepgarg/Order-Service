using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderMicroservice.Repository.Interfaces;
using OrderMicroservice.DBContexts;
using OrderMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace OrderMicroservice.Repository.Managers
{
    public class OrderManager : IOrderManager
    {
        private readonly OrderContext _dbContext;

        public OrderManager(OrderContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _dbContext.Orders.ToListAsync();
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _dbContext.Orders.Where(o => o.Id == id).FirstOrDefaultAsync();
        }

        public async Task SaveOrder(Order orderVal)
        {
            _dbContext.Add(orderVal);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateOrder(int id, Order orderVal)
        {
            _dbContext.Update(orderVal);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteOrder(int id)
        {
            var order = await GetOrderById(id);
            _dbContext.Orders.Remove(order);
        }
    }
}
