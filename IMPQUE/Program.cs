using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMPQUE
{
    public class Program
    {
       
        public static T Add<T> (T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a + b;
        }

        public  T Substract<T> (T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a - b;
        }
        public static T Multiplication<T> (T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a * b;
        }
        public static T Division <T>(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a / b;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Program.Add(1, 2);
            Console.WriteLine(p.Substract(1,1));
            Console.WriteLine(Program.Multiplication(1,2));

        }
    }
}
