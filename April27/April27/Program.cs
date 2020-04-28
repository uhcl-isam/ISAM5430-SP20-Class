using System;
using System.Collections.Generic;
using System.Collections;

namespace April27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            //            a.Length = a.Length + 1;
            List<int> b = new List<int>();
            b.Add(1);
            b.Add(2);
            b.Add(3);
            Console.WriteLine(b[0]);
            foreach(int c in b)
            {
                Console.Write(c);
                Console.Write(" ");
            }

            Console.WriteLine();

            int sum = 0;

            foreach(int s in a)
            {
                sum = sum + s;
            }
            Console.WriteLine(sum);

            int sum2 = 0;
            IEnumerator enumerator = a.GetEnumerator();

            while(enumerator.MoveNext())
            {
                int s = (int)enumerator.Current;
                sum2 = sum2 + s;
            }
            Console.WriteLine(sum2);

            int sum3 = 0;
            IEnumerator<int> enumerator2 = b.GetEnumerator();

            while (enumerator.MoveNext())
            {
                int s = enumerator2.Current;
                sum3 = sum3 + s;
            }
            Console.WriteLine(sum3);


            Console.WriteLine($"b: {string.Join(", ", b)}");

            SumResult(b);

            Console.WriteLine($"b: {string.Join(", ", b)}");

            SumResult(b);
            Console.WriteLine(Sum(a));

            Console.WriteLine("---------------------");

            //            Print(a);
            //            Print2(a);
            // Print(b);
            // Print2(b);


            List<int> x = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                x.Add(i);
            }
            var o = new ClassTen();
            foreach (var item in o)
            {
                x.Add(item);
            }

            // INitializing values into the list.

            int[] aa = new int[] { 1, 2, 3, 4 };
            List<int> bb = new List<int> { 1, 2, 3, 4 };
        }

        public static void SumResult(ICollection<int> collection)
        {
            int sum = 0;
            foreach(int c in collection)
            {
                sum = sum + c;
            }
            collection.Add(sum);
        }

        public static int Sum(IReadOnlyCollection<int> collection)
        {
            int sum = 0;
            foreach (int c in collection)
            {
                sum = sum + c;
            }
            return sum;
        }


        public static void Print(ICollection<object> collection)
        {
            foreach(var c in collection)
            {
                Console.Write(" - " + c);
            }
            Console.WriteLine();
        }

        public static void Print2(IEnumerable<object> collection)
        {
            foreach (var c in collection)
            {
                Console.Write(" - " + c);
            }
            Console.WriteLine();
        }

    }
}
