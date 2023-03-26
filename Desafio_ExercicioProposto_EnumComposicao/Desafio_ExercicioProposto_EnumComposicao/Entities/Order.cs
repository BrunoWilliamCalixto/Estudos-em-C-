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

		// Construtor padrão da classe Order
		public Order() { }

		// Construtor que recebe os dados necessários para criar um objeto Order
		public Order(DateTime moment, OrderStatus status, Client client)
		{
			Moment = moment;
			Status = status;
			Client = client;
		}

		// Método que adiciona um objeto OrderItem à lista de itens do objeto Order
		public void AddItem(OrderItem item)
		{
			Items.Add(item);
		}

		// Método que remove um objeto OrderItem da lista de itens do objeto Order
		public void RemoveItem(OrderItem item)
		{
			Items.Remove(item);
		}

		// Método que calcula o valor total do pedido somando os valores de cada OrderItem
		public double Total()
		{
			double totalValue = 0.0;

			foreach (OrderItem item in Items)
			{
				totalValue += item.SubTotal();
			}
			return totalValue;
		}

		// Sobrescrita do método ToString para imprimir um resumo do objeto Order
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
					+ ", SubTotal: $" + item.SubTotal());

			}
			sb.AppendLine("----------------------------------------------");
			sb.AppendLine("Total Price: " + Total());

			return sb.ToString();
		}
	}
}
