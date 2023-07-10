using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ExitInMenu = "Exit";
            const string SumInMenu = "Sum";

            List<int> numbers = new List<int>();

            string userInput;
            bool isProgramWork = true;
            int userInputNumber;
                        
            while (isProgramWork)
            {
                Console.Clear();
                Console.WriteLine("ВВедите числа для сложения");
                Console.WriteLine($"Для сложения всех чисел введите - {SumInMenu}");
                Console.WriteLine($"Для выхода нажмите - {ExitInMenu}");

                userInput = Console.ReadLine();
  
                if (int.TryParse(userInput, out userInputNumber))
                {
                    numbers.Add(userInputNumber);
                }
                else
                {
                    switch (userInput)
                    {
                        case SumInMenu:
                            ToSumNumbers(numbers);
                            break;

                        case ExitInMenu:
                            isProgramWork = false;
                            break;
                    }
                }
            }
        }

        static void ToSumNumbers(List<int> numbers)
        {
            int numbersSum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                numbersSum += numbers[i];
            }

            Console.WriteLine("Сумма всех чисел = " + numbersSum);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }  
    }
}
