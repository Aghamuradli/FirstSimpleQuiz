using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Quiz
{
    internal class Program
    {

        static void Main(string[] args)
        {
            FirstQuestion();
        }

        static void FirstQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------" + DateTime.Now + "-------------------------");

            Console.WriteLine("\n                  *** Welcome My C# Quiz ***");
            bool count = true;
            while (count)
            {

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n1.What is a correct syntax to output \"Hello World\" in C# ?");

                Console.WriteLine("     A)Console.WriteLine(\"Hello World\")");
                Console.WriteLine("     B) print (\"Hello World\");");
                Console.WriteLine("     C)System.out.println(\"Hello World\");");

                string answer = Console.ReadLine();


                if (answer == "A" || answer == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations. The answer is correct.");
                    Thread.Sleep(1000);
                    count = false;
                    Console.Clear();
                    SecondQuestion();
                    break;

                }
                else if (answer == "B" || answer == "b")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine("true answer : A ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    SecondQuestion();
                    break;
                }
                else if (answer == "C" || answer == "c")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine("true answer : A ");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    SecondQuestion();
                    break;
                }
                else
                {
                    Console.WriteLine("Pleace chose a b c !");
                    Thread.Sleep(1000);
                    count = true;
                    Console.Clear();
                }
            }
        }

        static void SecondQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------" + DateTime.Now + "-------------------------");

            Console.WriteLine("\n                  *** Welcome My C# Quiz ***");
            bool count = true;
            while (count)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n2. How do you insert COMMENTS in C# code?");
                Console.WriteLine("     A)/* This is a comment");
                Console.WriteLine("     B) // This is a comment");
                Console.WriteLine("     C) # This is a comment");

                string answer = Console.ReadLine();


                if (answer == "B" || answer == "b")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations. The answer is correct.");
                    Thread.Sleep(1000);
                    count = false;
                    Console.Clear();
                    ThirdQuestion();
                    break;

                }
                else if (answer == "A" || answer == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine("true answer : B ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    ThirdQuestion();
                    break;
                }
                else if (answer == "C" || answer == "c")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine("true answer : B ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    ThirdQuestion();
                    break;
                }
                else
                {
                    Console.WriteLine("Pleace chose a b c !");
                    Thread.Sleep(1000);
                    count = true;
                    Console.Clear();
                }
            }
        }

        static void ThirdQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------" + DateTime.Now + "-------------------------");

            Console.WriteLine("\n                  *** Welcome My C# Quiz ***");
            bool count = true;
            while (count)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n3.Which data type is used to create a variable that should store text?");
                Console.WriteLine("     A)/* str");
                Console.WriteLine("     B) // MyString");
                Console.WriteLine("     C) # string");

                string answer = Console.ReadLine();


                if (answer == "C" || answer == "c")
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations. The answer is correct.");
                    Thread.Sleep(1000);
                    count = false;
                    Console.Clear();
                    FourthQuestion();
                    break;

                }
                else if (answer == "B" || answer == "b")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine("true answer : C ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    FourthQuestion();
                    break;

                }
                else if (answer == "A" || answer == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine("true answer : C ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    FourthQuestion();
                    break;
                }
                else
                {
                    Console.WriteLine("Pleace chose a b c !");
                    Thread.Sleep(1000);
                    count = true;
                    Console.Clear();
                }
            }
        }

        static void FourthQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------" + DateTime.Now + "-------------------------");

            Console.WriteLine("\n                  *** Welcome My C# Quiz ***");
            bool count = true;
            while (count)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n4. How do you create a variable with the numeric value 5??");
                Console.WriteLine("     A) num x = 5 ;");
                Console.WriteLine("     B) int x = 5 ;");
                Console.WriteLine("     C) x = 5");

                string answer = Console.ReadLine();


                if (answer == "B" || answer == "b")
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations. The answer is correct.");
                    Thread.Sleep(1000);
                    count = false;
                    Console.Clear();
                    FifthQuestion();
                    break;


                }
                else if (answer == "A" || answer == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine("true answer : B ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    FifthQuestion();
                    break;
                }
                else if (answer == "C" || answer == "c")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine("true answer : B ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    FifthQuestion();
                    break;
                }
                else
                {
                    Console.WriteLine("Pleace chose a b c !");
                    Thread.Sleep(1000);
                    count = true;
                    Console.Clear();
                }
            }

        }

        static void FifthQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------" + DateTime.Now + "-------------------------");

            Console.WriteLine("\n                  *** Welcome My C# Quiz ***");
            bool count = true;
            while (count)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n5.C# is an alias of C++");
                Console.WriteLine("     A)true ");
                Console.WriteLine("     B)False");
                string answer = Console.ReadLine();


                if (answer == "B" || answer == "b")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations. The answer is correct.");
                    Thread.Sleep(1000);
                    count = false;
                    Console.Clear();
                    Console.WriteLine("Soon Next Quiz ...");
                    Thread.Sleep(3000);
                    break;

                }
                else if (answer == "A" || answer == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine("true answer : B ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Soon Next Quiz ...");
                    Thread.Sleep(3000);
                    break;
                }
                else
                {
                    Console.WriteLine("Pleace chose a b c !");
                    Thread.Sleep(1000);
                    count = true;
                    Console.Clear();
                }
            }

        }
    }

}