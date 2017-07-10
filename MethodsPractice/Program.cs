﻿using System;
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

            double hoursWorkedWeekly = 42.3d;
            double hourlyWage = 12.50d;

            Console.WriteLine("Your monthly wage is {0}.", WageCalculator(hoursWorkedWeekly, hourlyWage));

    }

        // best practice is to have main method be the top method in your program class
        // Method header:
        // Access modifier (tells us what part of the program can access the method, i.e. public)
        // Return type (after method performs work, this is the type of info it will send back, i.e. int; can also be complex type, such as array or list; can be object)
        // Method name in pascal case (first letter of each word is capitalized, i.e. Add; should be descriptive & coorespond with the action it performs)
        // Parentheses, sometimes they contain parameters (parameters function inside the scope or body of the method; parameters can be a different data type then the return data type)
        // Static means we don't have to worry about objects

        public static int Add(int firstNumber, int secondNumber) // firstNumber and secondNumber are temporary variables
        {
            // Method body:
            // Complete method (header & body) is called a method declaration
            int sum = firstNumber + secondNumber;

            return sum; // returning an int, and the int i'm returning is the sum; "return" takes whatever value back to where i called my method
        }

        // if you have a method that does not have a return value, you would use key word "void"
        // when we have a void return type, we don't need to use the keyword "return"

        public static void RobotWarning(string name) // void doesn't do anything with it; it just takes it and uses it
        {
            Console.WriteLine("Danger, " + name + "!!");
        }

        public static void Useless()
        {
            Console.WriteLine("Blah blah blah");
        }

        public static string Vehicle(string birthMonth)
        {
            string vehicleFortune;
            if (birthMonth.ToUpper() == "SEPTEMBER" || birthMonth.ToUpper() == "OCTOBER")
            {
                vehicleFortune = "Hoverboard";
            }
            else
            {
                vehicleFortune = "SUV";
            }
            return vehicleFortune;
        }

        // Create a method called FavoriteFoods.
        // It should take two string parameters. One representing a name, and the other representing a favorite food.
        // The return type should be void.
        // The method should concatenate.

        public static void FavoriteFoods(string name, string favoriteFood)
        {
            Console.WriteLine(name + "'s favorite food" + " is " + favoriteFood);
        }

        // Create a method called RetirementCalculator.
        // It should take an int as a parameter representing the user's age.
        // The method should calculate how many more years until the user retires using 65 as the age of retirement.
        // The return type should be void.
        // Once it calculates the user's retirement age it should print:
        // "The user will retire in X years" where X represents the value that was calculated.

        public static void RetirementCalculator(int userAge)
        {
            int yearsUntilRetirement = 65 - userAge;
            Console.WriteLine("The user will retire in " + yearsUntilRetirement + " years.");
        }

        public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
        {
            // This method should calculate the monthly wage
            double monthlyWage = (hoursWorkedWeekly * 52 * hourlyWage) / 12;
            return monthlyWage;
        }

    }
}
