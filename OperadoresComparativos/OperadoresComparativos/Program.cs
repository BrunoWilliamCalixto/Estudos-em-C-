using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresComparativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console.writeline("digite seu nome completo: ");
            //string[] nome = console.readline().split(' ');
            //string n1 = nome[0];


            //console.writeline("digite seu horário atual: ");
            //double horario = double.parse(console.readline(), cultureinfo.invariantculture);

            //if (horario >= 0 && horario <= 11.59)
            //{
            //    console.writeline($"bom dia {n1}!");
            //}
            //else if (horario <= 17.59)
            //{
            //    console.writeline($"boa tarde {n1}!");
            //}
            //else if (horario <= 23.59)
            //{
            //    console.writeline($"boa tarde {n1}!");
            //}
            //else
            //{
            //    console.writeline("horario inválido");
            //}

            //if (horario % 2 == 0)
            //{
            //    console.writeline($"{horario.tostring("f2", cultureinfo.invariantculture)} é par!");
            //}
            //else
            //{
            //    console.writeline($"{horario.tostring("f2", cultureinfo.invariantculture)} é ímpar!");
            //}

            //Exercicio proposto

            Console.WriteLine("Entre com a hora inicial do jogo:");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a hora final do jogo:");
            int horaFinal = int.Parse(Console.ReadLine());

            int horaJogo = 0;

            if (horaInicial <= 24)
            {
                if (horaFinal <= 24)
                {
                    if (horaInicial < horaFinal)
                    {
                        horaJogo = horaFinal - horaInicial;

                    }
                    else if (horaInicial >= horaFinal)
                    {
                        horaJogo = 24 - horaInicial + horaFinal;

                    }

                    Console.WriteLine($"O JOGO DUROU {horaJogo} HORA(S)");
                }
                else
                {
                    Console.WriteLine("Horario final inválido");
                }
            }
            else
            {
                Console.WriteLine("Horario Inicial inválido");
            }

            



        }
    }
}
