using System;
using System.Linq;

namespace Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array of numbers separeted by a space");


            string  rawnumbarray = Console.ReadLine();

            int[] numbarray = rawnumbarray.Split(' ').Select(elements => int.Parse(elements)).ToArray();
            
            Console.WriteLine("what number do you want to find?");
            int numbertobefound = int.Parse(Console.ReadLine());

            Array.Sort(numbarray);
            
            bool foundit = false;
            int midpoint = (numbarray.Length) / 2;
            int start = 0;
            int end = numbarray.Length - 1;


            for (int i = 0; foundit == false; i++)
            {
                if (numbarray[midpoint] == numbertobefound)
                {

                    foundit = true;

                }
                else if (numbarray[midpoint] > numbertobefound)
                {
                    end = midpoint;
                }
                else
                {
                    start = midpoint;
                }
                midpoint = (end - start) / 2;
            }
            Console.WriteLine($"YES!!!, I found {numbertobefound}  It was at index {midpoint}");

        }
        
    }
}
