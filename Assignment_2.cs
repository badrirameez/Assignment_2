using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Transactions;

namespace Assignment_2
{
    class Assignment_2
    {
        static void Main(string[] args)
        {
            /*int a;
            int[] numberArray = new int[10];
            numberArray[0] = 1;
            numberArray[1] = 2;
            numberArray[2] = 3;
            numberArray[3] = 4;
            numberArray[4] = 5;
            numberArray[5] = 6;
            numberArray[6] = 7;
            numberArray[7] = 8;
            numberArray[8] = 9;
            numberArray[9] = 10;

            Console.WriteLine( "Enter the number to view from the array : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here is the number that you chose : " + numberArray[a]);

            int[,] number2DArray = new int[4, 2] {{1,2},{3,4},{5,6},{7,8}};

            Console.WriteLine(number2DArray[2,1]);
*/

            /*            int[] numArray = new int[] { 100, 200, 300 };


                        for (int i = 0; i < numArray.Length; i++)
                        {
                            Console.WriteLine("the number at " + i + " location is " + numArray[i]);
                        }

                        //List Example

                        List<int> numLists = new List<int>();
                        numLists.Add(400);
                        numLists.Add(653);
                        numLists.Add(4454);

                        for (int i=0 ; i<numLists.Count ; i++)
                        { 
                            Console.WriteLine ("the number at " + i + " location is " + numLists[i]);
                        }

                        //Dictionary example
                        Dictionary<int, int> numberDictionary = new Dictionary<int, int>();
                        numberDictionary.Add(1, 234);
                        numberDictionary.Add(2, 3432);
                        numberDictionary.Add(3, 500);
                        numberDictionary.Add(7, 600);
                        numberDictionary.Add(6, 23455);
                        numberDictionary.Add(8, 345432);
                        numberDictionary.Add(9, 5500);
                        numberDictionary.Add(10, 5600);
                        int[] keysArray = numberDictionary.Keys.ToArray<int>();

                        for (int i = 0; i < numberDictionary.Count; i++)
                        {
                             Console.WriteLine("the number Dictionary at " + keysArray[i] + " location is " + numberDictionary[keysArray[i]]);
                        }*/

            //Search operations
            /*
                        int numbersToCheck = 100000;
                        Random random = new Random();
                        int n;

                        //our DS
                        int[] numberSearchArray = new int[numbersToCheck];
                        Dictionary<int, int> numberSearchDictionary = new Dictionary<int, int>();

                        //populate data

                        for (int i = 0; i < numbersToCheck; i++) 
                        {
                            n = random.Next();
                            numberSearchArray[i] = n;
                            numberSearchDictionary.TryAdd(n, n);

                        }
                        Console.WriteLine("Elements in Dictionary : " +numberSearchDictionary.Count());

                        // time the search

                        Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();

                        for (int i = 0; i < numbersToCheck; i++)
                        {
                            findInArray(random.Next(), numberSearchArray);
                        }
                        watch.Stop();

                        long arraySearchTimesMs = watch.ElapsedMilliseconds;
                        watch.Reset();
                        watch.Start();

                        for (int i = 0; i < numbersToCheck; i++)
                        {
                            numberSearchDictionary.TryGetValue(random.Next(), out n);
                        }
                        watch.Stop();
                        long dictionarySearchTimeMs = watch.ElapsedMilliseconds;

                        Console.WriteLine("Array search took " + arraySearchTimesMs + " Milliseconds");
                        Console.WriteLine("Dictionary search took " + dictionarySearchTimeMs + " Milliseconds");



                    }
                    public static int findInArray(int numberToFind, int[] numbersArray)
                    {
                        bool found = false;
                        int counter = 0;

                        while (!found && counter < numbersArray.Length)
                        {
                            if (numbersArray[counter] == numberToFind)
                            {
                                return 1;
                            }
                            else 
                            {
                                counter = counter + 1;
                            }
                        }

                        //number not found
                        return -1;

                    }*/

            Dictionary<int, int> numberSearch = new Dictionary<int, int>();
            int n,s;
            Console.WriteLine("Enter 10 numbers : ");

            for (int i = 0; i < 10; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                numberSearch.Add(i, n);

            }

            Console.WriteLine("Enter a number to search : ");

            s = Convert.ToInt32(Console.ReadLine());

            if (numberSearch.ContainsValue(s))
            {
                Console.WriteLine(" Number found! ");
            }
            else
            {
                Console.WriteLine(" Number not found! ");
            }
        }
    }
}
