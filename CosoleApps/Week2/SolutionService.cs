﻿using System;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Week2
{
    public static class SolutionService
    {
        private static void SolutionCaptionView()
        {
            Console.ForegroundColor = Helpers.SOLUTION_CAPTION_COLOR;
            Console.WriteLine("SOLUTION");
            Console.ForegroundColor = Helpers.TEXT_COLOR;
        }
        private static bool ExitSolutionMenuView()
        {
            Console.Write("\r\nPress 'a' key to run script again. \r\nPress any other key to return to previous menu :");
            ConsoleKeyInfo choice = Console.ReadKey();
            switch (choice.KeyChar)
            {
                case 'a':
                    return true;
                default:
                    return false;
            }
        }
        private static void WarningMessageView(string message)
        {
            Console.ForegroundColor = Helpers.WARNING_COLOR;
            Console.WriteLine(message);
            Console.ForegroundColor = Helpers.TEXT_COLOR;
        }
        private static int ReadIntFromInput(string inputMessage)
        {
            int value = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(inputMessage);
                isValid = Int32.TryParse(Console.ReadLine(), out value);
                if (!isValid)
                {
                    WarningMessageView("It is not valid number! Try again.");
                }
            }
            return value;
        }
        private static double ReadDoubleFromInput(string inputMessage)
        {
            double value = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(inputMessage);
                isValid = Double.TryParse(Console.ReadLine(), out value);
                if (!isValid)
                {
                    WarningMessageView("It is not valid number! Try again.");
                }
            }
            return value;
        }
        private static string ReadStringFromInput(string inputMessage)
        {
            string inputText = "";
            bool isEmpty = true;
            while (isEmpty)
            {
                Console.Write(inputMessage);
                inputText = Console.ReadLine();
                isEmpty = String.IsNullOrEmpty(inputText);
                if (isEmpty)
                {
                    WarningMessageView("You didn't provide any info! Try again.");
                }
            }
            return inputText;
        }
    public static void ShowExerciseSolution(int exerciseNumber, string lessonNumber)
        {

            if (exerciseNumber == 1 && lessonNumber == "Lesson4")
            {
                SolutionCaptionView();
                Console.WriteLine("There is no console output. Only code to review.");
                Console.ForegroundColor = Helpers.CODE_COLOR;
                Console.WriteLine(" \r\nstring name;\r\nstring surname;\r\nint age;\r\nchar sex;\r\nint personalIdNumber;\r\nstring employeeId;");
                Console.ForegroundColor = Helpers.TEXT_COLOR;
                Console.WriteLine("\r\nPress any key to return to the previous menu...");
                Console.ReadKey();
            }
            else if (exerciseNumber == 2 && lessonNumber == "Lesson4")
            {
                SolutionCaptionView();
                Console.WriteLine("Code to review.");
                Console.ForegroundColor = Helpers.CODE_COLOR;
                Console.WriteLine("\r\nchar a = \'a\';\r\nchar b = \'b\';\r\nchar c = \'c\';");
                Console.WriteLine("Console.WriteLine($\"{c} {b} {a}\");\r\n");
                Console.ForegroundColor = Helpers.SOLUTION_CAPTION_COLOR;
                Console.WriteLine("Console output:");
                Console.ForegroundColor = Helpers.TEXT_COLOR;

                char a = 'a'; char b = 'b'; char c = 'c';
                Console.WriteLine($"{c} {b} {a}");

                Console.WriteLine("\r\nPress any key to return to the previous menu...");
                Console.ReadKey();
            }
            else if (exerciseNumber == 3 && lessonNumber == "Lesson4")
            {
                SolutionCaptionView();
                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    double a = ReadDoubleFromInput("Give the length of side A of the rectangle: ");
                    double b = ReadDoubleFromInput("Give the length of side B of the rectangle: "); ;
                    double diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                    string result = diagonal.ToString("F2");
                    Console.WriteLine($"Your diagonal length is: {result}");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 4 && lessonNumber == "Lesson4")
            {
                SolutionCaptionView();
                Console.WriteLine("There is no console output. Only code to review.");
                Console.ForegroundColor = Helpers.CODE_COLOR;
                Console.WriteLine("\r\nint numberI = 10;\r\nstring text = \"Szkoła Dotneta\";\r\ndouble numberD = 12.5;\r\n");
                Console.ForegroundColor = Helpers.TEXT_COLOR;
                Console.WriteLine("\r\nPress any key to return to the previous menu...");
                Console.ReadKey();
            }
            else if (exerciseNumber == 5 && lessonNumber == "Lesson4")
            {
                SolutionCaptionView();
                Console.WriteLine("Welcome to the app! Please provide some information below.");
                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();

                    string name = ReadStringFromInput("What is your name: ");
                    string lastName = ReadStringFromInput("What is your last name: ");
                    string phoneNumber = ReadStringFromInput("Your phone number: ");
                    string email = ReadStringFromInput("Type your email address: ");
                    int age = ReadIntFromInput("What is your age in years: ");
                    double height = ReadDoubleFromInput("What is your height: ");
                    double weight = ReadDoubleFromInput("What is your weight in kg: ");
                                        
                    Console.WriteLine("\r\nBelow information you provided:");
                    Console.Write($"Your name is {name} {lastName}.\r\nYou are {age} years old.\r\nYour phone number is {phoneNumber}.\r\nYour email address is {email}.\r\nYou are {height}cm tall and your weight is {weight}kg.\r\n");
                    
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 1 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();
                
                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int number1 = ReadIntFromInput("Please write first number: ");
                    int number2 = ReadIntFromInput("Please write second number: ");
                                        
                    string result = (number1 == number2) ? "Numbers are equal" : "Numbers are not equal"; 
                    Console.WriteLine(result);                    
                    continueLoop = ExitSolutionMenuView();
                }                
            }
            else if (exerciseNumber == 2 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int number = ReadIntFromInput("Please type the number: ");
                    
                    string result = ( number % 2 != 0) ? "odd." : "even.";
                    Console.WriteLine($"{number} is {result}");                    
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 3 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int number = ReadIntFromInput("Please type the number: ");
                    string result = (number > 0) ? "positive number."
                        : (number < 0) ? "negative number."
                        : "just zero :)";
                    Console.WriteLine($"{number} is {result}");

                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 4 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int year = ReadIntFromInput("Please type the year: ");
                    string result = (year % 4 != 0) ? "not a leap year." : "a leap year.";
                    Console.WriteLine($"{year} is {result}");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 5 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int age = ReadIntFromInput("Please type the age: ");
                    string result = "";
                                        
                    if (age >= 35)
                    {
                        result = "you can become President, Prime Minister, Member of Parliament, and Senator.";
                    }
                    else if (age >= 30 && age < 35)
                    {
                        result = "you can become Prime Minister, Member of Parliament, and Senator.";
                    }
                    else if (age >= 21 && age < 30)
                    {
                        result = "you can become Prime Minister and Member of Parliament.";
                    }
                    else
                        result = "you do not meet the age requirements for any of the positions.";

                    Console.WriteLine($"At the age of {age}, {result}");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 6 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int height = ReadIntFromInput("Please type your height: ");
                    string result = "";
                    
                    if (height <= 140)
                    {
                        result = "you are dwarf :)";
                    }
                    else if (height > 140 && height <= 160)
                    {
                        result = "you are a bit of a taller dwarf :)";
                    }
                    else if (height > 160 && height <= 180)
                    {
                        result = "you are within the European average :)";
                    }
                    else if (height > 180 && height <= 200)
                    {
                        result = "you can call yourself tall.";
                    }
                    else
                        result = "you can play in NBA :)";

                    Console.WriteLine($"Having {height}cm, {result}");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 7 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {
                    Console.WriteLine();
                    int number1 = ReadIntFromInput("Please write number 1: ");
                    int number2 = ReadIntFromInput("Please write number 2: ");
                    int number3 = ReadIntFromInput("Please write number 3: ");
                 
                    int biggestNumber = number1;
                    if (number2 > biggestNumber)
                        biggestNumber = number2;
                    if (number3 > biggestNumber)
                        biggestNumber = number3;
                    
                    Console.WriteLine($"{biggestNumber} is the biggest number.");
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 8 && lessonNumber == "Lesson7")
            {
                SolutionCaptionView();

                bool continueLoop = true;
                while (continueLoop)
                {                    
                    Console.WriteLine();
                    int mathScore = ReadIntFromInput("Please write math score: ");
                    int physicsScore= ReadIntFromInput("Please write physic score: ");
                    int chemistryScore = ReadIntFromInput("Please write chemistry score: ");

                    if ((mathScore + physicsScore + chemistryScore) > 180 || (mathScore + physicsScore) >= 150 || (mathScore + chemistryScore >= 150))
                    {
                        Console.WriteLine("Candidate admitted to the recruitment process.");
                    }
                    else
                    {
                        Console.WriteLine("Candidate not admitted to the recruitment process.");
                    }
                    continueLoop = ExitSolutionMenuView();
                }
            }
            else if (exerciseNumber == 9 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 9 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 10 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 10 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 11 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 11 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 12 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 12 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 13 && lessonNumber == "Lesson7")
            {
                Console.WriteLine("Rozwiazanie zadania 13 lekcja 7");
                Console.ReadKey();
            }
            else if (exerciseNumber == 1 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 1 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 2 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 2 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 3 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 3 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 4 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 4 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 5 && lessonNumber == "Lesson6")
            {
                Console.WriteLine("Rozwiazanie zadania 5 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 6 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 6 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 7 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 7lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 8 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 8 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 9 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 9 lekcja 8");
                Console.ReadKey();
            }
            else if (exerciseNumber == 10 && lessonNumber == "Lesson8")
            {
                Console.WriteLine("Rozwiazanie zadania 10 lekcja 8");
                Console.ReadKey();
            }

        }

                
    }
}
