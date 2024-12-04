

using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading;
using System.Xml.Linq;
namespace test
{

    class Program
    {
        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main()
        {

            /*  Problem: Write a program that:
      o Initializes a one-dimensional array in three different ways(new int[size],
      initializer list, and Array syntax sugar).
      o Assigns values to each element in the array and prints them.
      o Demonstrates an IndexOutOfRangeException.*/
            //int[] x = new int[4];
            //int[] y = { 1, 2, 34, 4 };
            //int[] z = new int[4] { 1, 2, 3, 4 };
            //try
            //{
            //    Console.WriteLine(z[6]);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            /*  Problem: Write a program to:
            o Create two arrays(arr1 and arr2).
            o Perform a shallow copy and demonstrate how modifying one affects the other.
            o Perform a deep copy using the Clone method and show that modifications do not
            affect the copied array.
            ?*/
            //int[] arr1 = { 1, 2, 3, 4 };
            //int[] arr2 = arr1;
            //int[] arr3 = (int[])arr1.Clone();


            /* Problem: Write a program to:
            o Create a 2D array with student grades(3 students, 3 subjects each).
            o Take input from the user to fill the array.
            o Print the grades for each student using nested loops.*/
            //     int[,] arr4 = new int[3,3];
            //     for (int i = 0; i<arr4.GetLength(0); i++)
            //{
            //             for (int ij = 0; ij < arr4.GetLength(1); ij++)
            //             {
            //                 Console.WriteLine($"enter arr[{i},{ij}] varue ");
            //                 bool flag = int.TryParse(Console.ReadLine(),out arr4[i,ij]);
            //                 if (!flag || arr4[i, ij] < 0) { ij--; }
            //             }
            //}
            //     foreach(int i in arr4) Console.WriteLine(i);


            /*Problem: Write a program that:
            o Demonstrates at least 5 array methods (Sort, Reverse, IndexOf, Copy, Clear).
            o Explains the changes before and after applying each method.*/
            //int[] x = { 1, 2, 3, 4 };
            //int[] y = new int[4];
            //    Array.Copy(x, y,x.Length);
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(y[i]);
            //}
            //Array.Clear(y, 0, 2);
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(y[i]);
            //}
            //int[] z= { 0, 0, 0, 0 };
            //Array.ConstrainedCopy(x, 1,z, 2, 1); Console.WriteLine("helo");
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(z[i]);
            //}
            /*  Problem: Write a program to:
      o Sort an array of integers using Array.Sort().
      o Search for a specific value using Array.IndexOf() and Array.LastIndexOf().*/
            int[]x= { 6, 5, 4, 3 };
            Array.Sort(x);
            foreach(int i in x) Console.WriteLine(i);
            Console.WriteLine(Array.IndexOf(x,4));
            Console.WriteLine(Array.LastIndexOf(x,3)); // if 3 is repeated it will result index of last 3


        }
}
}
