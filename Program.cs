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

            //char[] classFirstLetters = { 'j', 'd', 'j', 'n' }; //print on same line.
            //Console.WriteLine(classFirstLetters);// this will only work with a char because the computer thinks its a string
            //Console.Write(classFirstLetters[0]);
            //Console.Write(classFirstLetters[1]);
            //Console.Write(classFirstLetters[2]);
            //Console.Write(classFirstLetters[3]);

            //Console.WriteLine("\n{0}", "{1}", "{2}", "{3}", classFirstLetters[0], classFirstLetters[1], classFirstLetters[2], classFirstLetters[3]);


            //dataType[] nameOfArray = new datatType[#ofElements];
            // int[] numberOfSeats = new int[21];
            // string[] studentsInClass = new string[21];
            // //nameofArray[index] = Element;
            // studentsInClass[0] = "Jordan";

            // Console.WriteLine("Please enter in the mane of he next student.");

            // studentsInClass[1] = Console.ReadLine();
            // Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]);
            // //ask user for input
            // Console.WriteLine("Please enter the age of the person in the first seat.");
            // //Create a new int array with 21 spots and call it ageOfStudentsInClass
            // int[] ageOfStudentsInClass = new int[21];
            ////Assign the value of the int at the 0 index of ageOfStudentsInClass to...
            ////...the users input converted into an int
            // ageOfStudentsInClass[0] = int.Parse(Console.ReadLine()); // INT.PARSE turns the ageOfStudents from a STRING to an INT for the console.readline. Console.Readline takes in a string.
            // Console.WriteLine("The age of the student in the first seat is " + ageOfStudentsInClass[0]);
            // //Create a new string variable and set it equal to the int at the index of 0
            // //and convert it into a string
            // string firstIndex = ageOfStudentsInClass[0].ToString();

            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Chic Fil-a" };
            //Console.WriteLine(restaurantsInMall.Length);
            ////For Review
            ////Declare and not initialize
            //int[] myIntArrayAgain;
            ////Declare and initialize an array when I know the elements
            //char[] lettersInFirstName = { 'D', 'i', 'x', 'o', 'n' };
            ////Declare and Initialize an Array when I dont know the elements but I know how many
            //string[] variableName = new string[42];

            //To practice using .Length, creat an char array of the letters in your middle name
            //char[] myMiddleName = { 'J', 'E', 'r', 'n', 'e', 'L', 'L' };
            ////...and print the number of chars to the console.
            //Console.WriteLine(myMiddleName.Length);

            //Declare and initialize a string array.
            //Using the Length property, print the Second to Last element in the array
            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chic Fil-a" };
            //Console.WriteLine(restaurantsInMall[restaurantsInMall.Length - 2]);// 0, 1, 2, 3, 4, 5  -2 will give you the second to the last

            //IndexOf is a method used to search an array for a specified value and returns 
            //the index position of the first matching value found.
            //int[] bestYearsEver = {1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));
            ////LastIndexOf is a method used to search an array for a specified value and returns the index position of the last matching value found.
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));

            //Reverse Method
            int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(palindromeNumbers[0]);
            Array.Reverse(palindromeNumbers);
            Console.WriteLine(palindromeNumbers[0]);
            
        }
    }
}
