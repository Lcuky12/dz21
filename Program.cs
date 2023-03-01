using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userEnters;
            bool examination = true;
         
            while (examination) 
            {
                Console.WriteLine("Введите сообщение");
                userEnters= Console.ReadLine();

                if (userEnters == "exit") 
                {
                    break;
                } 
            }
        }
    }
}
