using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTrainning.Types
{
    public class Homework1
    {
        static string userNumbers = Console.ReadLine();
        static string firstNumber = userNumbers.Trim().Split(' ')[0];
        static string secondNumber = userNumbers.Trim().Split(' ')[1];
        public int sum = int.Parse(firstNumber) + int.Parse(secondNumber);
    }
}
