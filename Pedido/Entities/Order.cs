using Pedido.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Pedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> List = new List<OrderItem>();
        public Order(DateTime moment,OrderStatus status,Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            List.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            List.Remove(item);
        }
        public double Total()
        {
            double returnTotal = 0.0;
            foreach (OrderItem order in List)
            {
                returnTotal += order.SubTotal();
            }
            return returnTotal;
        }
        public override string ToString()
        {
            StringBuilder returnToString = new StringBuilder();
            returnToString.AppendLine("\nORDER SUMMARY");
            returnToString.Append("Order moment: ");
            returnToString.AppendLine(Moment.ToString());
            returnToString.Append("Order status: ");
            returnToString.AppendLine(Status.ToString());
            returnToString.Append("Client: ");
            returnToString.Append(Client.Name.ToString());
            returnToString.Append(" (");
            returnToString.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            returnToString.Append(") - ");
            returnToString.AppendLine(Client.Email.ToString());
            returnToString.AppendLine("Order items: ");
            foreach (OrderItem order in List)
            {
                returnToString.AppendLine(order.Product.Name + ", $" + order.Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + order.Quantity.ToString() + ", Subtotal: $" + order.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            returnToString.Append("Total Price: $");
            returnToString.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));
            return returnToString.ToString();
        }
    }
}
