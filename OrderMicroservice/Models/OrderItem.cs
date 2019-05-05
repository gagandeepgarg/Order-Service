using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMicroservice.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public long PricePerUnit { get; set; }
        public int MeasurementUnit { get; set; }
        public int OrderId { get; set; }
        public int ItemCount { get; set; }
    }
}
