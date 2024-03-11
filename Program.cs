/*
* Author: Joaquin Gomez
* Course: COMP-003A
* Purpose: Lecture activity for variables, type system, Math, and Console properties
* Reference: The C# Player's Guide (4e) by RB Whitaker
*/
using System.Xml.Linq;

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Give the console a title
            Console.Title = "COMP-003A - Assignment 2";
            // Give the console a background color
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            // Give the console a foreground color
            Console.ForegroundColor = ConsoleColor.White;
            // This is first section
            Console.WriteLine("**************************************************");
            Console.WriteLine("Console Section ");
            Console.WriteLine("**************************************************\n");
            //Getting the users first name
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            //Getting the users middle name
            Console.Write("Enter Middle Name: ");
            string middlename = Console.ReadLine();
            //Getting the users last name
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            //Getting the users age and the year the user was born
            Console.Write("Enter age in 2023: ");
            string inputAge = Console.ReadLine();
            // converts string to the int
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            // recall the info 
            Console.WriteLine($"Hello, {firstName} {middlename} {lastName}. You were born in {yearBorn}.\n"); ;
            // Math section
            Console.WriteLine("**************************************************");
            Console.WriteLine("Math Section ");
            Console.WriteLine("**************************************************\n");
            // input for math
            Console.WriteLine("Enter an Integer for integer1: ");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an Integer for integer2:");
            int integer2 = Convert.ToInt32(Console.ReadLine());
            // input for 'math
            // this will show the additon
            Console.WriteLine("This is the results of Additon: ");
            // this will show the results
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            // this will show the subtraiton
            Console.WriteLine("This is the results of Subtration: ");
            // this will show the results
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            // this will show the multiplication
            Console.WriteLine("This is the results of Multiplication: ");
            // this will show the results
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            // this will show the disvion
            Console.WriteLine("This is the results of Disvion: ");
            // this will show the results
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            // this will show the remainder
            Console.WriteLine("This is the results of Remainder: ");
            // this will show the results
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");
            Console.WriteLine("\n");
            // Circle & Circumference Section
            Console.WriteLine("**************************************************");
            Console.WriteLine("Circle Area & Circumference Section ");
            Console.WriteLine("**************************************************\n");
            // Here we ask for you to enter a Number for a Radius
            Console.WriteLine("Enter Radius: ");
            // We do the math here
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            // this will show the results
            Console.WriteLine($"The area is {area}.");
            Console.WriteLine($"The cricumference is {circumference}.");
            Console.ReadKey();
        }
        
    }
}