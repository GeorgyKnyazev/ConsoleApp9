using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string userInput;
            bool isProgramWork = true;
            int userInputNumber;

            const string exitInMenu = "Exit";
            const string sumInMenu = "Sum";

            while (isProgramWork)
            {
                Console.Clear();
                Console.WriteLine("ВВедите числа для сложения");
                Console.WriteLine($"Для сложения всех чисел введите - {sumInMenu}");
                Console.WriteLine($"Для выхода нажмите - {exitInMenu}");

                userInput = Console.ReadLine();
  
                if (int.TryParse(userInput, out userInputNumber))
                {
                    numbers.Add(userInputNumber);
                }
                else
                {
                    switch (userInput)
                    {
                        case sumInMenu:
                            SumOfNumbers(ref numbers);
                            break;

                        case exitInMenu:
                            isProgramWork = false;
                            break;
                    }
                }
            }

        }
        static void SumOfNumbers(ref List<int> numbers)
        {
            int numbersSum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                numbersSum += numbers[i];
            }

            Console.WriteLine("Сумма всех чисел = " + numbersSum);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            numbers.Clear();
            Console.ReadKey();
        }  
    }
}
