using System;
using System.Collections.Generic;
using System.Text;

namespace composition3_csharp.Entities
{
    class Order
    {
        public DateTime Momment { get; set; }
        

        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();


    }
}
