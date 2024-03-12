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
            //Программа принимает строку.
            //В случае, если в строке нет данных, сообщает об ошибке и перезапускается.

            string str;
            bool restart = true;
            while (restart == true) 
            {
                Console.Clear();
                restart = false;
                Console.WriteLine("Введите данные: ");
                str = Console.ReadLine();
                if (String.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Ошибка! Введены неверные данные!");
                    Console.ReadLine();
                    restart = true;
                }
                else 
                {
                    Console.WriteLine("Кол-во символов в строке: " + str.Length);
                }
                
            }
        }
    }    
}

