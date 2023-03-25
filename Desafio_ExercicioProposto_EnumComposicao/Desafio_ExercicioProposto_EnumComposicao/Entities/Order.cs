using Desafio_ExercicioProposto_EnumComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_ExercicioProposto_EnumComposicao.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }


        public double Total()
        {
            double totalValue = 0.0;

            foreach (OrderItem item in Items)
            {
                totalValue += item.SubTotal();
            }
            return totalValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name + ", (" + Client.birthDate + ")" + " - " + Client.Email);
            sb.AppendLine();
            sb.AppendLine("Order items:");
            sb.AppendLine();
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.Product.Name + ", Quantity: " + item.Quantity
                    +", SubTotal: $" + item.SubTotal());
           
            }
            sb.AppendLine("----------------------------------------------");
            sb.AppendLine("Total Price: " + Total());

            return sb.ToString();
        }
    }
}
