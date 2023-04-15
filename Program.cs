using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            printMenu();
        }

        private static void printMenu()
        {
            bool end = false;
            int actionNumber;
            string[] answers = null;
            Programmer programmer = null;
            while (!end)
            {
                Console.Write("Input actionNumber: 1 - Create programmer or 2 - correctProgrammer / 3 - exit: ");
                actionNumber = int.Parse(Console.ReadLine());
                {
                    switch (actionNumber)
                    {
                        case 1:
                            answers = readAnswers();
                            programmer = new Programmer(answers[0], int.Parse(answers[1]), int.Parse(answers[2]));
                            Console.WriteLine(programmer.ToString());
                            break;
                        case 2:
                            answers = readAnswers();
                            Console.Write("Input a number of number of correct programs: ");
                            int numberOfCorrectPrograms = int.Parse(Console.ReadLine());
                            if (numberOfCorrectPrograms <= int.Parse(answers[1]))
                            {
                                programmer = new CorrectProgrammer(answers[0], int.Parse(answers[1]), int.Parse(answers[2]), numberOfCorrectPrograms);
                                Console.WriteLine(programmer.ToString());
                            }
                            else
                            {
                                Console.WriteLine("Number of correct programs should be less than number of all programs!");
                                Environment.Exit(-1);
                            }
                            break;
                        case 3:
                            end = true;
                            break;
                        default:
                            Console.WriteLine("You have chosen an incorrect number!");
                            Environment.Exit(-1);
                            break;
                    }
                }
            }
        }

        private static string[] readAnswers()
        {
            Console.Write("Input lastName: ");
            string lastName = Console.ReadLine();
            Console.Write("Input a number of written programs: ");
            string numberOfWrittenPrograms = Console.ReadLine();
            Console.Write("Input a number of programming languages: ");
            string numberOfProgrammingLanguages = Console.ReadLine();
            string[] answers = {lastName, numberOfWrittenPrograms, numberOfProgrammingLanguages};
            return answers;
        }
    }
}
