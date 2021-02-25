using System;

namespace DevE_L02_conditions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi Maks! Please choose the task:");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
 
            if (taskNumber == 1 || taskNumber == 2)
            {
                Console.WriteLine("Put first number:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Put second number:");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                TwoDigitsTask(firstNumber, secondNumber, taskNumber);
            }
            else if (taskNumber == 3 || taskNumber == 4)
            {
                Console.WriteLine("Put first number:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Put second number:");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Put third number:");
                int thirdNumber = Convert.ToInt32(Console.ReadLine());

                ThreeDigits(firstNumber, secondNumber, thirdNumber, taskNumber);
            }
            else if (taskNumber == 5)
            {
                Console.WriteLine("Put 2digits number:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                OneDigit(firstNumber);
            }
            else
            {
                Console.WriteLine("Was it some joke?");
            }

        }

        static void TwoDigitsTask(int a, int b, int c)
        {
            int firstNumber = a;
            int secondNumber = b;
            int task = c;
            int result = 0;

            if (c == 1)
            {
                if (firstNumber > secondNumber)
                {
                    result = firstNumber + secondNumber;
                }
                else if (firstNumber == secondNumber)
                {
                    result = firstNumber * secondNumber;
                }
                else if (firstNumber < secondNumber)
                {
                    result = firstNumber - secondNumber;
                }
            }
            else if (c == 2)
            {
                if (firstNumber < 0)
                {
                    result = secondNumber < 0 ?  3 : 4;
                }
                else if(firstNumber > 0)
                {
                    result = secondNumber < 0 ? 2 : 1;
                }
            }
            Console.WriteLine($"Result of the {task} task: {result}");   
        }

        static void ThreeDigits(int a, int b, int c, int d)
        {
            int [] numbers = {a, b, c}; 
            int firstNumber = a;
            int secondNumber = b;
            int thirdNumber = c;
            int task = d;
            double result_1 = 0.00;
            double result_2 = 0.00;

            if (task == 3)
            {
                Array.Sort(numbers);
                for(int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i]);
                }
            }
            if (task == 4)
            {
                double diskriminant = secondNumber * secondNumber - 4 * firstNumber * thirdNumber;

                if(diskriminant > 0)
                {
                    result_1 = (-secondNumber + Math.Sqrt(diskriminant)) / (2 * firstNumber);
                    result_2 = (-secondNumber - Math.Sqrt(diskriminant)) / (2 * firstNumber);
                    Console.WriteLine($"Result: X1 = {result_1}, X2 = {result_2}");
                }
                else if (diskriminant == 0)
                {
                    result_1 = -secondNumber / (2 * firstNumber);
                    Console.WriteLine($"Result: X = {result_1}");
                }
                else
                {
                    Console.WriteLine("Oops, try again with other digits");
                }
            }
        }

        static void OneDigit(int a)
        {
            int inputNumber = a;
            string result = "";
            string[] unit = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] teen = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (inputNumber < 20)
                result += unit[inputNumber];
            else
            {
                result += teen[inputNumber / 10];
                if ((inputNumber % 10) > 0)
                    result += " " + unit[inputNumber % 10];
            }
            Console.WriteLine(result);

        }
    }
}
