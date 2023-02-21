using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        delegate bool Del(int x);
        delegate int Square(int x);
        delegate void MinMax(int[] arr);
        delegate void Odd(int[] arr);
        static void Main(string[] args)
        {
            int[] mass = new int[5];
            Del del = delegate (int a)
             {
                 return a % 2 == 0;
             };
            Console.WriteLine(del(10));

            Square square = delegate (int t)
            {
                return t * t;
            };
            Console.WriteLine(square(2));

            Square square3 = i => i * i * i;
            Console.WriteLine(square3(2));

            MinMax max = (int[] arr) =>
            {
                for(int i=0;i<arr.Length;i++)
                {
                    arr[i] = i + 1;
                }
                Console.WriteLine("Maximum number is " + arr.Max());
            };

            MinMax min = (int[] arr) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = i + 1;
                }
                Console.WriteLine("Maximum number is " + arr.Min());
            };

            Odd odd = (int[] arr) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = i + 1;
                    if(arr[i]%2!=0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            };
        }
    }
}
