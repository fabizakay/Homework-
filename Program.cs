using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Arry_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            #region targil2

            //int[] numbers = new int[10] { 30, 50, 60, 70, 80, 90, 20, 10, 95, 100 };
            //int indexarryfirstnum = Array.IndexOf(numbers, 30);
            //int number = 0;
            //int counter=0;
            //for (int i = 0; i < numbers.Length; i++)
            //    {
            //    Console.WriteLine("please select a number of first arry");
            //    number = int.Parse(Console.ReadLine());
            //    int index = Array.IndexOf(numbers, number);
            //    if (index != indexarryfirstnum)
            //        {
            //            Console.WriteLine("you didnt select first number of arry - try again");
            //            counter++;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"yeeeeee you find the first number after {counter} trys");
            //        }
            //    }
            #endregion

            #region targil 3

            int[,] dimarry = 
            {
                {1,2,3,4,5},
                { 3,4,5,6,7},
                { 8,9,10,4,5},
                { 3,2,1,6,5},
                { 7,5,3,9,5},
            };
            int indexvalue = Array.IndexOf(dimarry,1);
            int numofvalue = int.Parse(Console.ReadLine());
            



            #endregion
        }
    }
}
