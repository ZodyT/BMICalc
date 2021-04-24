using System;

namespace BMICalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your height in inches?");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your weight?");
            int weight = Convert.ToInt32(Console.ReadLine());

            int bmi = (weight / height * height);

            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Overweight");
            }
            else if (bmi >= 30)
            {
                Console.WriteLine("Obese");
            }
        }
    }
}
