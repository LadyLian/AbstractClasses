using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class MyArray : IOutput
    {
        public static int number { get; set; }
        public static int[] arr { get; set; }


        public void Show(int[] arr) 
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine(" ");
        }
        public void Show(string message, int[]arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine($"{message}");
        }

}
}
