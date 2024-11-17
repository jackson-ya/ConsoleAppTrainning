// See https://aka.ms/new-console-template for more information
using ConsoleAppTrainning;
using ConsoleAppTrainning.Types;
using static System.Math;


internal class Program
{
    private static void Main(string[] args)
    {
        var number = new Numbers();
        /* var task1 = new Homework1(); */

        Console.WriteLine(number.firstNumbers);


        static void Task1()
        {
            Console.WriteLine("Write two numbers with space between them");

            string userNumbers = Console.ReadLine();
            string firstNumber = userNumbers.Trim().Split(' ')[0];
            string secondNumber = userNumbers.Trim().Split(' ')[1];
            int sum = int.Parse(firstNumber) + int.Parse(secondNumber);
            Console.WriteLine(sum);
        } Task1();

        static void Task2()
        {
            Console.WriteLine("What is you First Name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is you Last Name?");
            string lastName = Console.ReadLine();
            string fullName = lastName + ", " + firstName;
            Console.WriteLine(fullName);
        } Task2();

        static void Task3()
        {
            Console.WriteLine("Enter a sentence...");
            string userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Invalid input. The sentence cannot be empty.");
                return;
            }
            string[] words = userInput.Trim().Split(" ");
            if (words.Length == 0)
            {
                Console.WriteLine("Use space between words. No words found in the sentence.");
                return;
            }
            string lastWord = words[words.Length - 1].Trim();
            string upper = lastWord.ToUpper();
            Console.WriteLine("Last word is: " + upper + " (Using Split)");

            int firstWordIndex = userInput.IndexOf(" ");
            string firstWord = userInput.Substring(0, firstWordIndex).Trim();
            string firstWordUpper = firstWord.ToUpper();
            Console.WriteLine("First word is: " + firstWordUpper + "(Using Substring)");
        } Task3();

        static void Task4()
        {
            Console.WriteLine("Input radius");

            string userNumber = Console.ReadLine();
            double radius = double.Parse(userNumber);
            double area = 3.14 * radius * radius;
            double roundedArea = Round(area, 2);
            Console.WriteLine(roundedArea);
        }
        Task4();


        static void Task5()
        {
            Console.WriteLine("Input your age");
            string userAge = Console.ReadLine();
            if (int.TryParse(userAge, out int age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Age cannot be negative");
                    return;
                } else if (age > 99) 
                {
                    Console.WriteLine("You can't be that old!");
                    return;
                }
                else
                {
                    Console.WriteLine("Your age is: " + age);
                }
                
            }
            
            else
            {
                Console.WriteLine("Invalid age entered.");
                return;
            }
            
        }
        Task5();
    }
}