using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //establishes score and answer values
            double score = 0;
            string answer;
            //asks for score, user inputs and code converts to double value
            Console.WriteLine("What is your numeric score? (0-100): ");
            score = Convert.ToDouble(Console.ReadLine());
            /* It took me a while, but I found out one way to do this with the switch statement. I'm not 100% sure on how it works, more like 90%,
             * but I also did a version of the same code with if statements that I tested and it works, so I included it so to show that I can
             * make the same code, but with switch statements I had to find ways online on how to make it. */
            switch (score)
            {
                /* What I've learned and understand of what I found online: (https://stackoverflow.com/questions/1554689/evaluate-expressions-in-switch-statements-in-c-sharp)
                 * From what I understand, the double variable simply tells the code that it is dealing with decimals, specifically from the score value.
                 * The _ value is actually only necessary for syntax reasons, as I just used score directly in the case statement instead of a placeholder.
                 * And the when statement makes the most sense, simply checking for certain situations like an if statement would. Hopefully using other things like this are ok for my own research. */
                case double _ when score < 59.5:
                    answer = "F";
                    break;
                    //Everything but the 'double _ when' part I already knew prior to finding that source, such as the && that you had shown us prior.
                case double _ when score >= 59.5 && score < 69.5:
                    answer = "D";
                    break;
                case double _ when score >= 69.5 && score < 79.5:
                    answer = "C";
                    break;
                case double _ when score >= 79.5 && score < 89.5:
                    answer = "B";
                    break;
                default:
                    answer = "A";
                    break;
            }
            //takes the answer value from the switch statement and outputs it for user
            Console.WriteLine("Your grade is: " + answer);
            Console.ReadLine();
            /*
            double score = 0;
            string answer;

            Console.Write("What is your numeric score? (0-100): ");
            score = Convert.ToDouble(Console.ReadLine());

            if (score < 59.5)
            {
                answer = "F";
            }
            else if (score >= 59.5 && score < 69.5)
            {
                answer = "D";
            }
            else if (score >= 69.5 && score < 79.5)
            {
                answer = "C";
            }
            else if (score >= 79.5 && score < 89.5)
            {
                answer = "B";
            }
            else
            {
                answer = "A";
            }
            Console.WriteLine("Your grade is: " + answer);
            Console.ReadLine();
            */

        }
    }
}
