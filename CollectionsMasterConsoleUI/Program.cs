using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] numbers = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //Print the first number of the array
            Console.WriteLine($"{numbers[0]}");

            //Print the last number of the array
            Console.WriteLine($"{numbers[numbers.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var numberList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {numberList.Capacity}");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberList);

            //Print the new capacity
            Console.WriteLine($"New Capacity: {numberList.Capacity}");

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            var input = int.Parse(Console.ReadLine());
            NumberChecker(numberList, input);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            //var evens = new List<int>();
            //OddKiller(numberList, evens);
            OddKiller(numberList);

            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            numberList.Sort();
            NumberPrinter(numberList);

            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            Console.WriteLine("Turning List into Array");
            int[] listToArray = numberList.ToArray();

            for (int i = 0; i < listToArray.Length - 1; i++)
            {
                Console.WriteLine($"{listToArray[i]}");
            }

            //Clear the list
            numberList.Clear();

            #endregion
        }

       
        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            NumberPrinter(numbers);
        }

        //private static void OddKiller(List<int> numberList)
        //{
        //    for (int i = 0; i < numberList.Count; i++)
        //    {
        //        if (numberList[i] % 2 == 0)
        //        {
        //            Console.WriteLine(numberList[i]);
        //            continue;
        //        }
        //        else
        //        {
        //            numberList.Remove(i);
        //        }
        //    }
        //}

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.RemoveAt(i);
                }
            }
            NumberPrinter(numberList);
        }


        private static void NumberChecker(List<int> numberList, int searchNumber)
        {

            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"We found te number {searchNumber}");
            }
            else
            {
                Console.WriteLine($"Hmm {searchNumber} was not in the list");
            }
            //for (int i = 0; i < numberList.Count; i++)
            //{
            //    if (numberList[i] == searchNumber)
            //    {
            //        Console.WriteLine($"We found te number {searchNumber}");
            //    }
            //}
        }

        private static void Populater(List<int> numberList)
        {
            while (numberList.Count < 50)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);

                numberList.Add(number);
            }
            NumberPrinter(numberList);

        }

        private static void Populater(int[] numbers)
        {
            //Create a method to populate the number array with
            //50 random numbers that are between 0 and 50

            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);

            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
