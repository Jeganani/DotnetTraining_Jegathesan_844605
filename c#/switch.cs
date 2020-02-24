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
            int b;
              Console.WriteLine("type the b");
              b = int.Parse(Console.ReadLine());
              switch (b)
              {
                  case 1:
                      Console.WriteLine("it is working");
                      break;
                  case 2:
                      Console.WriteLine("it is not working");
                      break;
                  case 3:
                      Console.WriteLine("this is case 3");
                      break;
                  default:
                      Console.WriteLine("You didnt give a perfect number");
                      break;
              }
             int a;
             a =int.Parse( Console.ReadLine());
             for(int i=1;i<=10;i++)
             {
                 Console.WriteLine(i * a);
             }
             int n = 9;
             do
             {
                 Console.WriteLine("it is working");
                 n = n + 2;
             }
             while (n > 10);

         }
           



        }
    }
}
