using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;

namespace Lessons
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //Программа принимает 2 числа и складывает их.
            //В случае, если было введено не число, сообщает об ошибке и перезапускается.
           
            int a, b;
            bool restart = true;
            while (restart == true) 
            {
                Console.Clear();
                restart = false;
                try
                {
                    Console.WriteLine("Введите число 1: ");

                    a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2: ");

                    b = int.Parse(Console.ReadLine());

                    int result = a + b;

                    Console.WriteLine("Сумма введённых чисел = " + result);
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введены неверные данные!");
                    Console.ReadLine();
                    restart = true;
                }
                
            }
            
        }
        
    }
}
