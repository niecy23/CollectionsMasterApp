using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
     {
        static void Main(string[] args)
        {
            //DONE: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //DONE: Create an integer Array of size 50

            var numbers = new int[50];

            //DONE: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(numbers);

            //DONE: Print the first number of the array

            Console.WriteLine($"{numbers[0]}");

            //DONE: Print the last number of the array

            Console.WriteLine($"{numbers[numbers.Length - 1]}");

            Console.WriteLine("All Numbers Original");

            //DONE: UNCOMMENT this method to print out your numbers from arrays or lists

            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //DONE: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            /*Way #1
            Array.Reverse(numbers);
            NumberPrinter(numbers);
            */

            //Way #2
            ReverseArray(numbers);

            Console.WriteLine("-------------------");

            //DONE: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            //DONE: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //DONE: Create an integer List

            var numList = new List <int> ();

            //DONE: Print the capacity of the list to the console

            Console.WriteLine($"Capacity is: {numList.Capacity}");


            //DONE: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(numList);


            //DONE: Print the new capacity

            Console.WriteLine($"New Capacity is: {numList.Capacity}");

            Console.WriteLine("---------------------");

            //DONE: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!


            int userNumber;
            bool isANumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out userNumber);

            } while (isANumber == false);

            NumberChecker(numList, userNumber);
           

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //DONE - UNCOMMENT this method to print out your numbers from arrays or lists

            NumberPrinter(numList);

            Console.WriteLine("-------------------");


            //DONE: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(numList);
            
            Console.WriteLine("------------------");

            //DONE: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            numList.Sort();

            NumberPrinter(numList);

            Console.WriteLine("------------------");

            //DONE: Convert the list to an array and store that into a variable

            var newArray = numList.ToArray();

            //DONE: Clear the list

            numList.Clear();

            //Just to confirm that the list is empty.
            NumberPrinter(numList);

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

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }

            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Your number is on the list.");
            }
            else
            {
                Console.WriteLine($"Your number is NOT on the list."); 
            }

        }

        private static void Populater(List<int> numberList)
        {
            while (numberList.Count < 51)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);

                numberList.Add(number);
            }

            NumberPrinter(numberList);
        }

        private static void Populater(int[] numbers)
        {
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
