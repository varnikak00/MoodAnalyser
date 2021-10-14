using System;
using static MoodAnalyzer2.MoodAnalyser;

namespace MoodAnalyzer2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To MoodAnalyzer");
            MoodAnalyser2 mood = new MoodAnalyser2();
            string res = MoodAnalyser("I am happy");
            Console.WriteLine(res);
        }

    }
}