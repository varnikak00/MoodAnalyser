using System;

namespace MoodAnlaAnlayser2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To MoodAnalyzer");
            MoodAnalyser mood = new MoodAnalyser(" ");
            string res = mood.AnalyseMood();
            Console.WriteLine(res);
        }
    }
}
