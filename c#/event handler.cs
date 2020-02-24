using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        


        public delegate int deleg();
        public event deleg print;
        public int OnPrint()
        {
            return 5;
        }
        public void show()
        {
           int x= print();
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            a.print = new deleg(a.OnPrint);
            a.show();
            Console.ReadKey();
        }
    }
   }

