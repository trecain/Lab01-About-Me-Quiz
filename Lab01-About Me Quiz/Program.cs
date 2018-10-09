using System;

namespace Lab01_About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(QuestionOne());
            Console.WriteLine(QuestionTwo());
            Console.WriteLine(QuestionThree());
            Console.WriteLine(QuestionFour());
            Console.WriteLine(QuestionFive());
        }

        static string QuestionOne()
        {
            string answerOne;
            Console.WriteLine("Where was my first football game attended?");
            answerOne = Console.ReadLine();

            if (answerOne == "california")
                return $"{answerOne} is correct!";
            else
                return "Nice try, california is the correct answer.";
        }

        static bool QuestionTwo()
        {
            string answerTwo;
            Console.WriteLine("True or False, Do I like pasta?");
            answerTwo = Console.ReadLine();

            if (answerTwo == "false")
            {
                Console.Write("That's correct! the answer is ");
                return true;
            }
            else
            {
                Console.Write("That's incorrect! the answer is not ");
                return false;
            }
        }

        static int QuestionThree()
        {
            string answerThree;
            Console.WriteLine("What's my favorite number?");
            answerThree = Console.ReadLine();

            if (answerThree == "3")
            {
                Console.Write("That's the correct number: ");
                return Convert.ToInt32(answerThree);
            }
            else
            {
                Console.Write("That's the incorrect number, correct number is: ");
                return Convert.ToInt32(answerThree);
            }
        }

        static string QuestionFour()
        {
            string answerFour;
            Console.WriteLine("What's my favorite food to eat?");
            answerFour = Console.ReadLine();

            if (answerFour == "arroz con pollo")
                return $"That's correct {answerFour} is my favorite food!";
            else
                return $"Nope, {answerFour} is not my favorite food";
        }

        static string QuestionFive()
        {
            string answerFive;
            Console.WriteLine("What did I want to grow up to be?");
            answerFive = Console.ReadLine();

            if (answerFive == "police sketch artist")
                return $"That's correct! {answerFive} is what I wanted to be when I grew up!";
            else
                return $"Nope, {answerFive} is not what I wanted to be when I grew up.";
        }
    }
}
