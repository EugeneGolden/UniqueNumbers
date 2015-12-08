using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfElements;
            ArrayList uniqueList = new ArrayList();

            Console.Write("How many elements of array do you expect to have? (enter integer number) ");
            amountOfElements = int.Parse(Console.ReadLine());

            string[] originalArray = new string[amountOfElements];

            //fill the array with elements manually
            for (int i = 0; i < amountOfElements; i++)
            {
                Console.Write("Enter the " + i + " element of the array: ");
                string arrayItem = Console.ReadLine();
                originalArray[i] = arrayItem;
            }

            //now let's add to ArrayList only unique values
            Console.Write("The unique elements of the array are ");

            for (int i = 0; i < amountOfElements; i++)
            {
                if (!uniqueList.Contains(originalArray[i]))
                {
                    uniqueList.Add(originalArray[i]);
                    Console.Write(originalArray[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
