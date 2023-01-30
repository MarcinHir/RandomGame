using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w naszej grze.");
            Console.WriteLine("System wylosował jedną liczbę z przedziału od 0 do 100, Twoim zadaniem jest zgadnięcię wylosowanej liczby.");
            Console.WriteLine("Podaj liczbę: ");
            GetInput();
            Console.WriteLine();
        }
        private static void GetInput()
        {
            Random random = new Random();
            int number = random.Next(0, 100);
            int counter = 1;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Podana wartość jest nieprawidłowa. Wpisz liczbę:");
                    counter++;
                }
                else if (input < number)
                {
                    Console.WriteLine("Podana liczba jest za mała. Spróbuj jescze raz");
                    counter++;
                }
                else if (input > number)
                {
                    Console.WriteLine("Podana liczba jest za duża. Spróbuj jescze raz");
                    counter++;
                }
                else if (input == number)
                {
                    Console.WriteLine($"Brawo zgadłeś po {counter} próbach");
                    break;
                }
            }
        }
    }
}
