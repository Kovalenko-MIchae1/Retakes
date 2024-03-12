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
            //Программа принимает 2 строки и складывает их.
            //В случае, если в одной из строк нет данных, сообщает об ошибке и перезапускается.

            string str1, str2;
            bool restart = true;
            while (restart == true) 
            {
                Console.Clear();
                restart = false;
                Console.WriteLine("Введите данные первой строки: ");
                str1 = Console.ReadLine();
                Console.WriteLine("Введите данные второй строки: ");
                str2 = Console.ReadLine();
                if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
                {
                    Console.WriteLine("Ошибка! Введены неверные данные!");
                    Console.ReadLine();
                    restart = true;
                }
                else 
                {
                    Console.WriteLine("Ваши данные: " + str1 + str2);
                }
            }
        }
    }
}
