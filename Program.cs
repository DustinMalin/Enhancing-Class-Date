using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malind_Assignment_10_6
{
    class Program
    {
        static void Main(string[] args)
        {
           Date newDate = new Date(1, 1, 1);

           for(int i = 0; i <30; i++)
           {
               newDate.ToString();
               newDate.NextDay();
           }


           Console.ReadKey();

        }
    }
}
