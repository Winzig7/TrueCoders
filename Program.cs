// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;
            bool isAlive;
            char grade;
            decimal weight;
            double bankAmount;

            age = 24;
            name = "Tyler";
            isAlive = true;
            grade = 'A';
            weight = 222.22M;
            bankAmount = 2000;

            Console.WriteLine($"I am {age} years old. My name is {name}. The grades I get are {grade}. I weigh {weight}lbs. I have {bankAmount} dollars in my bank accounr. Is he alive {isAlive}");
        }
    }
}
