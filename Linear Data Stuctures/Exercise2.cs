using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;



//Exercise 2 
class Exercise2
{
    static void Main()
    {
        Console.WriteLine("Choose Your Exercise");
        Console.WriteLine("1: Exercise 2");
        Console.WriteLine("2: Exercise 7");
        Console.WriteLine("3: Exercise 9");

        string menuopt = Console.ReadLine();

        switch (menuopt) {
            case "1":
                ExerciseTwo(); break;
            case "2":
                ExerciseSeven(); break;
            case "3":
                ExerciseNine(); break;
        }




    }

    static void ExerciseTwo()
    {
        Console.Write("How many numbers would you like to reverse?: ");
        int n = int.Parse(Console.ReadLine());


        Stack<int> stack = new Stack<int>();

        Console.WriteLine("Enter the numbers (Enter one at a time pressing enter after each number until desired number count is reached0): ");
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            stack.Push(num);
        }

        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

    }


    static void ExerciseSeven()
    {

    }

    static void ExerciseNine()
        { }
}



