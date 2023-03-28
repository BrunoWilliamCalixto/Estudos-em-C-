using Sobre_Try_Catch_SolucaoCorreta.Entities.Exceptions;
using Sobre_TryCatch.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Try_Catch_SolucaoCorreta
{
	internal class Program
	{

		public static void Main()
		{
			try
			{
				Console.Write("Room Number: ");
				int roomNumber = int.Parse(Console.ReadLine());
				Console.Write("Check-in date (DD/MM/YYYY): ");
				DateTime checkIn = DateTime.Parse(Console.ReadLine());
				Console.Write("Check-out date (DD/MM/YYYY): ");
				DateTime checkOut = DateTime.Parse(Console.ReadLine());

				Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
				Console.WriteLine(reservation);

				Console.WriteLine("Enter data to update the reservation: ");
				Console.Write("Check-in date:");
				checkIn = DateTime.Parse(Console.ReadLine());
				Console.Write("Check-out date: ");
				checkOut = DateTime.Parse(Console.ReadLine());
				reservation.UpdateDates(checkIn, checkOut);

				Console.WriteLine("Upade date:");
				Console.WriteLine(reservation);
			}

			catch (DomainException e)
			{
				Console.WriteLine("Error in Reservation: " + e.Message);
			}
			catch(FormatException e)
			{
                Console.WriteLine("Error in Reservation: " + e.Message);
            }
			catch(Exception e)
			{
                Console.WriteLine("Unexpected error: " + e.Message);
            }
		}
	}
}


