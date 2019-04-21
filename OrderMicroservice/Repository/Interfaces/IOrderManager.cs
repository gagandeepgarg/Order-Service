using Microsoft.EntityFrameworkCore;
using OrderMicroservice.DBContexts;
using OrderMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMicroservice.Repository.Interfaces
{
    public interface IOrderManager
    {
        Task<List<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
        Task SaveOrder(Order orderVal);
        Task UpdateOrder(int id, Order orderVal);
        Task DeleteOrder(int id);
    }
}
