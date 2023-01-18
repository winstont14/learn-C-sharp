using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //ถามจำนวนชั้น
            Console.WriteLine("How many floors?");
            int floors = int.Parse(Console.ReadLine());

            string print_value = "";
            //สร้างพีรามิด
            while(floors >0)
            {   
                print_value+= "*" ;
                Console.WriteLine(print_value);
                floors--;



            }
            Console.ReadLine();

        }
    }
}
