/*
 * Write a C# program to find the pair of adjacent elements that has the highest product of an given array of integers.
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestProductOfAdjacentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Enter numbers separated by commas\n\n>>> ");
                    string[] input = Console.ReadLine().Split(',');
                    int[] arr = new int[input.Length];
                    for (int i = 0; i < input.Length; i++)
                    {
                        arr[i] = Convert.ToInt32(input[i]);
                    }
                    Console.WriteLine($"\nThe adjacent elements with the highest product of {HighestAdjacentProduct(arr)[2]} are {HighestAdjacentProduct(arr)[0]} and {HighestAdjacentProduct(arr)[1]}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n{ex.Message}");
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static int[] HighestAdjacentProduct(int[] arr)
        {
            int[] output = { arr[0], arr[1], arr[0] * arr[1] };
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] * arr[i + 1] > output[2])
                {
                    output[0] = arr[i];
                    output[1] = arr[i + 1];
                    output[2] = arr[i] * arr[i + 1];
                }
            }
            return output;
        }

    }
}
