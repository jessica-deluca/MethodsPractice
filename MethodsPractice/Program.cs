using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // int answer = Add(5, 7); // calling Add method (aka invoking; call by using their name)
            // Console.WriteLine(answer);

            //Console.WriteLine("Hello. Please enter the first nuumber to be added.");
            //int numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Hello. Please enter the second nuumber to be added.");
            //int numberTwo = int.Parse(Console.ReadLine());

            //int answer = Add(numberOne, numberTwo);
            //Console.WriteLine("The sum of your two numbers is " + answer);

            //RobotWarning("Will Robinson");
            //Useless();

            //string myBirthMonth = "September";
            //string myFriendBirthMonth = "December";
            //string myVehicle = Vehicle(myBirthMonth);
            //string myFriendVehicle = Vehicle(myFriendBirthMonth);

            //Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle {1}.", myVehicle, myFriendVehicle); // {0} and {1} are placeholders

            //string user = "Jessica";
            //string userFavoriteFood = "ice cream";
            //FavoriteFoods(user, userFavoriteFood);

            //int ageOfUser = 30;
            //RetirementCalculator(ageOfUser);

            //double hoursWorkedWeekly = 42.3d;
            //double hourlyWage = 12.50d;

            //Console.WriteLine("Your monthly wage is {0}.", WageCalculator(hoursWorkedWeekly, hourlyWage));

            //int numberOne = 1;
            //int numberTwo = 2;
            //int numberThree = 3;

            //Average(numberOne, numberTwo, numberThree);

            //SayHello("Jessica");
            //SayGoodbye();

            //int firstNumber = 8;
            //int secondNumber = 4;
            //int answer = SumIt(firstNumber, secondNumber);
            //Console.WriteLine(answer);

            //int integerNumber = 4;
            //Console.WriteLine(DoubleInt(integerNumber));

            //int[] numberInArray = { 4,5,10,12,23 };
            //Console.WriteLine("The sum of the example array is " + Sum(numberInArray));

        }

        // best practice is to have main method be the top method in your program class
        // Method header:
        // Access modifier (tells us what part of the program can access the method, i.e. public)
        // Return type (after method performs work, this is the type of info it will send back, i.e. int; can also be complex type, such as array or list; can be object)
        // Method name in pascal case (first letter of each word is capitalized, i.e. Add; should be descriptive & coorespond with the action it performs)
        // Parentheses, sometimes they contain parameters (parameters function inside the scope or body of the method; parameters can be a different data type then the return data type)
        // Static means we don't have to worry about objects

        //public static int Add(int firstNumber, int secondNumber) // firstNumber and secondNumber are temporary variables
        //{
        //    // Method body:
        //    // Complete method (header & body) is called a method declaration
        //    int sum = firstNumber + secondNumber;

        //    return sum; // returning an int, and the int i'm returning is the sum; "return" takes whatever value back to where i called my method
        //}

        // if you have a method that does not have a return value, you would use key word "void"
        // when we have a void return type, we don't need to use the keyword "return"

        //public static void RobotWarning(string name) // void doesn't do anything with it; it just takes it and uses it
        //{
        //    Console.WriteLine("Danger, " + name + "!!");
        //}

        //public static void Useless()
        //{
        //    Console.WriteLine("Blah blah blah");
        //}

        //public static string Vehicle(string birthMonth)
        //{
        //    string vehicleFortune;
        //    if (birthMonth.ToUpper() == "SEPTEMBER" || birthMonth.ToUpper() == "OCTOBER")
        //    {
        //        vehicleFortune = "Hoverboard";
        //    }
        //    else
        //    {
        //        vehicleFortune = "SUV";
        //    }
        //    return vehicleFortune;
        //}

        // Create a method called FavoriteFoods.
        // It should take two string parameters. One representing a name, and the other representing a favorite food.
        // The return type should be void.
        // The method should concatenate.

        //public static void FavoriteFoods(string name, string favoriteFood)
        //{
        //    Console.WriteLine(name + "'s favorite food" + " is " + favoriteFood);
        //}

        // Create a method called RetirementCalculator.
        // It should take an int as a parameter representing the user's age.
        // The method should calculate how many more years until the user retires using 65 as the age of retirement.
        // The return type should be void.
        // Once it calculates the user's retirement age it should print:
        // "The user will retire in X years" where X represents the value that was calculated.

        //public static void RetirementCalculator(int userAge)
        //{
        //    int yearsUntilRetirement = 65 - userAge;
        //    Console.WriteLine("The user will retire in " + yearsUntilRetirement + " years.");
        //}

        //public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
        //{
        //    double monthlyWage = (hoursWorkedWeekly * 52 * hourlyWage) / 12; // method will calculate the montly wage
        //    return monthlyWage;
        //}

        // Create two methods of your choosing.
        // At least one of the methods should have a non-void return type.
        // Both of the methods should take at least one parameter.
        // Remember when naming your method that it should represent what your method does.
        // Your method should only aim to accomplish one thing.
        // Be creative.

        //public static void Average(int numberOne, int numberTwo, int numberThree)
        //{
        //    int average = (numberOne + numberTwo + numberThree) / 3;
        //    Console.WriteLine(average);
        //}

        // If user enters QUIT, program says "Are you sure your want to quit?"

        //public static string QuitReponse(string userQuitRespsonseAnswer)
        //{
        //    string quitResponseOutput;
        //    if (userQuitRespsonseAnswer.ToUpper() == "YES")
        //    {
        //        quitResponseOutput = "Thanks for playing!";
        //    }
        //    else
        //    {
        //        quitResponseOutput = "Good luck!";
        //    }
        //    return quitResponseOutput;
        //}

        // Create a method to be called in main:
        // sayHello("Jessica");
        // sayGoodbye();

        //public static void SayHello(string name)
        //{
        //    Console.WriteLine("Hello, " + name);
        //}

        //public static void SayGoodbye()
        //{
        //    Console.WriteLine("Goodbye.");
        //}

        // Create a method to be called in main: 
        // Do something with sumIt(8,4)
        // sumIt(8,4);
        // "sumIt" must accept two integers as parameters
        // it must return an integer number (the sum of those two numbers). 

        //public static int SumIt( int firstNumber, int secondNumber)
        //{
        //    int sum = firstNumber + secondNumber;
        //    return sum;
        //}

        // Create a method to calculate the sum of the elements in an array.
        // Inside main should look like this:
        // int[] example = { 20, 10, 5, 2 };
        // Console.WriteLIne("The sum of the example array is " + sumIt(example)); 

        //public static int Sum(int[]myArray)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        sum += myArray[i];
        //    }
        //    return sum;
        //}

        // Create a method named "doubleIt" to calculate and return an integer number doubled
        // For example.doubleIt(7) should return 14.

        //public static int DoubleInt(int integerNumber)
        //{
        //    int intDoubled = integerNumber * 2;
        //    return intDoubled;
        //}

        // Create a method called sumDigits that receives a number and returns the sum of its digits.
        // For example, if the number is 123, the sum would be 6. 
        // Inside main should look like this:
        // Console.WriteLine( sumDigits(123) );

        // public static int SumDigits(int[] myArray)


        // Create a method which returns the greatest value stored in an array of numbers which is specified as parameter:
        // int[] data = { 87, 90, 23 }
        // float max = findMaximum(data);


    }
}
