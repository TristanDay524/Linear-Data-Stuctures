using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;



//Exercise 2 
class LinearDataExercises
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

        Console.WriteLine("Enter the numbers (Enter one at a time pressing enter after each number until desired number count is reached): ");
       
 
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            stack.Push(number);
        }

        while (stack.Count > 0)
        {

            Console.WriteLine(" ");
            Console.WriteLine(stack.Pop());
            Main();
        }

    }


    static void ExerciseSeven()
    {
        int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
        Dictionary<int, int> counter = new Dictionary<int, int>();

        foreach (int number in array)
        {
            if (counter.ContainsKey(number))
            {
                counter[number]++;
            }
            else
            {
                counter[number] = 1;
            }
        }
            foreach (var pair in counter)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} times");
                
            }
           


        }    
    

    static void ExerciseNine()
        {
        Console.Write("Enter Beginning Number: ");
        int n = int.Parse(Console.ReadLine());

        Queue<int> queue = new Queue<int>();
        List<int> queseq = new List<int>();

        queue.Enqueue(n);

        while (queseq.Count < 50)

        {
            int curnum = queue.Dequeue();
            queseq.Add(curnum);
            queue.Enqueue(curnum + 1);
            queue.Enqueue(2 * curnum + 1);
            queue.Enqueue(curnum + 2);
        }

        Console.WriteLine("First 50 then Break");
        for (int i = 0; i < 50; i++)
        {
            Console.Write(queseq[i] + " ");
        }
    
    }
}



