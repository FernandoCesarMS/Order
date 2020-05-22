using Pedido.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> List = new List<OrderItem>();
        public void addItem(OrderItem item)
        {

        }
        public void removeItem(OrderItem item)
        {

        }
        public double total()
        {

            return 0.0;
        }
    }
}
