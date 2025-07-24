using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sorting:");
            Console.WriteLine("Enter the size of array:");
            int n=Convert.ToInt32(Console.ReadLine());
            int [] array=new int[n];
            Console.WriteLine("Enter Elements of array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element:",i+1);
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            // Ascending Order
            for (int i = 0;i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted Array (Ascending):");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} , ", array[i]);
            }
            Console.ReadLine();
            //Console.WriteLine(string.Join(", ", arr));  => Alternate way to print


            // Descending Order
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }
                }
            }
            Console.WriteLine("\nSorted Array (Descending):");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} , ", array[i]);
            }
            Console.ReadLine();
            //Console.WriteLine(string.Join(", ", arr));  => Alternate way to print

        }
    }
}
