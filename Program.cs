using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////declaring an array without initializing
            //int[] myFirstArray;
            ////declaring and initializing a second array
            //string[] myStringArray = { "First", "Second", "Third", "Fourth" };
            ////declare and initialize a char array with the letters of my last name
            //char[] myLastName = { 'D', 'i', 'x', 'o', 'n' };// single quotes for chars
            ////I want my console to print three elements of my array
            //Console.WriteLine(myLastName[0]);
            //Console.WriteLine(myLastName[3]);
            //Console.WriteLine(myLastName[1]); //this will print D, o, i to the screen
            ////create the following arrays and print using the correct index numbers:
            ////Array of top 10 vacation spots
            ////print the first and last vacation spots
            ////array of the ages of 3 children you know
            ////print each child's age
            ////Array of GPA's on a 4.0 scale of 8 students - you dont have to print
            ////Array of the first letter of 4 of your classmates names who are sitting near you
            ////Print all for on the same line

            //string[] myVacationSpots = { "Costa Rica", "Miami", "Las Vegas", "New York", "California", "Hawaii", "Arizona", "Texas", "Virgin Islands", "Bahamas" };
            //Console.WriteLine(myVacationSpots[0]);
            //Console.WriteLine(myVacationSpots[9]);
            //int[] childrenAges = {2, 7, 9}; //int not quotes around numbers
            //Console.WriteLine(childrenAges[0]);// if you cancantonate it will add the numbers together
            //Console.WriteLine(childrenAges[1]);
            //Console.WriteLine(childrenAges[2]);

            char[] classFirstLetters = { 'j', 'd', 'j', 'n' }; //print on same line.
            Console.WriteLine(classFirstLetters);// this will only work with a char because the computer thinks its a string
            Console.Write(classFirstLetters[0]);
            Console.Write(classFirstLetters[1]);
            Console.Write(classFirstLetters[2]);
            Console.Write(classFirstLetters[3]);

            Console.WriteLine("\n{0}", "{1}", "{2}", "{3}", classFirstLetters[0], classFirstLetters[1], classFirstLetters[2], classFirstLetters[3]);
        }
        }
    }
