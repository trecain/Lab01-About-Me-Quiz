using System;

namespace Lab01_About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Invokes all questions methods in the class and logs them to the console.
            Console.WriteLine(QuestionOne());
            Console.WriteLine(QuestionTwo());
            Console.WriteLine(QuestionThree());
            Console.WriteLine(QuestionFour());
            Console.WriteLine(QuestionFive());
        }

        static string QuestionOne()
        {
            //Logs question to and sets the users answer to the variable answerOne
            string answerOne;
            Console.WriteLine("Where was my first football game attended?");
            answerOne = Console.ReadLine().ToLower();
            //Conditional compare users answer to the correct answer and logs response to the user.
            if (answerOne == "california")
                return $"{answerOne} is correct!";
            else
                return "Nice try, california is the correct answer.";
        }

        static bool QuestionTwo()
        {
            //Logs question to and sets the users answer to the variable answerTwo
            string answerTwo;
            Console.WriteLine("True or False, Do I like pasta?");
            answerTwo = Console.ReadLine().ToLower();
            //Conditional statement compares user input to the correct answer and returns a boolean if it's correct.
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
            //Logs question to and sets the users answer to the variable answerThree
            string answerThree;
            Console.WriteLine("What's my favorite number?");
            answerThree = Console.ReadLine();

            //Compares user answer to the string of my favorite number
            if (answerThree == "3")
            {
                //logs and converts users input to an integer
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
            //Logs question to and sets the users answer to the variable answerFour
            string answerFour;
            Console.WriteLine("What's my favorite food to eat?");
            answerFour = Console.ReadLine().ToLower();

            if (answerFour == "arroz con pollo")
                return $"That's correct {answerFour} is my favorite food!";
            else
                return $"Nope, {answerFour} is not my favorite food";
        }

        static string QuestionFive()
        {
            //Logs question to and sets the users answer to the variable answerFive
            string answerFive;
            Console.WriteLine("What did I want to grow up to be?");
            answerFive = Console.ReadLine().ToLower();
            //Compares users input to correct answer and logs to console.
            if (answerFive == "police sketch artist")
                return $"That's correct! {answerFive} is what I wanted to be when I grew up!";
            else
                return $"Nope, {answerFive} is not what I wanted to be when I grew up.";
        }
    }
}
