using System;
using System.Collections.Generic;
using System.Text;
using composition3_csharp.Entities.Enums;

namespace composition3_csharp.Entities
{
    class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens{ get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime momment, OrderStatus status)
        {
            Momment = momment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }
    }
}
