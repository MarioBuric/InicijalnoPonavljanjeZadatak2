using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuricMarioZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds;
            int minutes;
            int sec;


            Console.WriteLine("Type seconds");

            seconds = Convert.ToInt32(Console.ReadLine());

            minutes = seconds / 60;
            sec = seconds % 60;
            Console.WriteLine("{1} seconds and {0} minutes", minutes, sec);
            Console.ReadKey();


        }
    }
}