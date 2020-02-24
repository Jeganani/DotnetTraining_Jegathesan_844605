using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int i,number, prime = 0;
            number = int.Parse(Console.ReadLine());
            for(i=2;i<=number/2;i++)
            {
                if(number%i==0)
                {
                    prime = 0;
                }
                else
                {
                    prime = 1;
                }
            }
            if(prime==1||number==3|| number == 2|| number == 1)
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }
        }
           



        
    }
}
