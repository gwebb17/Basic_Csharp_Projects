using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

        List<int> testScores = new List<int>() { 98, 48, 85, 77, 38, 99 };
        List<int> passingScores = new List<int>();  //blank list to have passing values from above list inserted into (like a temp)

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        Console.WriteLine(passingScores.Count);
            
        Console.ReadLine();
        }
    }

