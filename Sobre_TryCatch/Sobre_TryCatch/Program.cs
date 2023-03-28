using Sobre_TryCatch.Entities;
using System;
using System.IO;
public class Program
{
	public static void Main()
	{
		//Programa destinado a uma opção ruim de código


		// Solicita ao usuário o número do quarto e armazena em roomNumber
		Console.Write("Room Number: ");
		int roomNumber;

		// Tenta converter a entrada do usuário para int e armazenar em roomNumber
		if (!int.TryParse(Console.ReadLine(), out roomNumber))
		{
			// Caso a conversão falhe, exibe uma mensagem de erro e encerra o programa com return
			Console.WriteLine("Error in input format. Please enter a valid integer value for room number.");
			return;
		}

		// Solicita ao usuário a data de check-in e armazena em checkIn
		Console.Write("Check-in date: (DD/MM/YYYY): ");
		DateTime checkIn;

		// Tenta converter a entrada do usuário para DateTime e armazenar em checkIn
		if (!DateTime.TryParse(Console.ReadLine(), out checkIn))
		{
			// Caso a conversão falhe, exibe uma mensagem de erro e encerra o programa com return
			Console.WriteLine("Error in input format. Please enter a valid date format: DD/MM/YYYY");
			return;
		}

		// Solicita ao usuário a data de check-out e armazena em checkOut
		Console.Write("Check-out date: (DD/MM/YYYY): ");
		DateTime checkOut;

		// Tenta converter a entrada do usuário para DateTime e armazenar em checkOut
		if (!DateTime.TryParse(Console.ReadLine(), out checkOut))
		{
			// Caso a conversão falhe, exibe uma mensagem de erro e encerra o programa com return
			Console.WriteLine("Error in input format. Please enter a valid date format: DD/MM/YYYY");
			return;
		}

		// Verifica se a data de check-out é menor ou igual à data de check-in
		if (checkOut <= checkIn)
		{
			// Caso seja, exibe uma mensagem de erro e encerra o programa com return
			Console.WriteLine("Error, check-out is smaller than check-in");
			return;
		}

		// Armazena a data e informações da reserva em um objeto Reservation
		Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

		// Exibe as informações da reserva
		Console.WriteLine(reservation);

		// Solicita ao usuário as novas datas de check-in e check-out
		Console.WriteLine("Enter data to update the reservation: ");

		Console.Write("Check-in date: (DD/MM/YYYY): ");
		// Armazena a nova data de check-in em checkIn
		if (!DateTime.TryParse(Console.ReadLine(), out checkIn))
		{
			// Caso a conversão falhe, exibe uma mensagem de erro e encerra o programa com return
			Console.WriteLine("Error in input format. Please enter a valid date format: DD/MM/YYYY");
			return;
		}

		Console.Write("Check-out date: (DD/MM/YYYY): ");
		// Armazena a nova data de check-out em checkOut
		if (!DateTime.TryParse(Console.ReadLine(), out checkOut))
		{
			// Caso a conversão falhe, exibe uma mensagem de erro e encerra o programa com return
			Console.WriteLine("Error in input format. Please enter a valid date format: DD/MM/YYYY");
			return;
		}

		// Verifica se a data de check-out é menor ou igual à data de check-in
		if (checkOut <= checkIn)
		{
			// Caso seja, exibe uma mensagem de erro e encerra o programa com return
			Console.WriteLine("Error, check-out is smaller than check-in");
		}
	}
}