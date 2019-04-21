using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMicroservice.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int OrderItemsCount { get; set; }
        public long OrderAmount { get; set; }
        public long AdditionalCharges { get; set; }
        public string AdditionalChargesDescription { get; set; }
        public long TotalAmount { get; set; }
        public int PaymentStatus { get; set; }
        public int PaymentMethod { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public List<OrderItem> items { get; set; }
    }
}

public enum PaymentStatus
{
    Paid = 1,
    PayLater = 2
}
public enum PaymentMethod
{
    Cash = 1,
    DebitCard = 2,
    CreditCard = 3
}
