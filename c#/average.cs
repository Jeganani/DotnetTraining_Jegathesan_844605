using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int n,n1;
             n = int.Parse(Console.ReadLine());
             n1 = int.Parse(Console.ReadLine());
             int[,] arr = new int[n,n1];
             for(int i=0;i<n;i++)
             {
                 for (int j = 0; j < n; j++)
                 {
                     arr[i, j] = int.Parse(Console.ReadLine());
                 }
             }
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < n; j++)
                 {
                     Console.Write( arr[i, j]+"\t");
                 }
                 Console.WriteLine();
             }*/
            /*int[] arr =  { 1, 5, 2, 10, 4, 6 };
           
            Array.Sort(arr);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }*/
            int i=10,j=20;
        
          int sum= Val(ref i, ref j);
            Console.WriteLine("{0},{1}", i, j);
            Console.WriteLine(sum);
          
            Console.ReadKey();
        }
        static  int Val( ref int a, ref int b)
        {
            a = a + 10;
            b = b + 10;
           int sum = a + b;
            return sum;
        }
       
       
    }
}
