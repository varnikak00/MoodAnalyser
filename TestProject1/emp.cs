using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer1
{
     public class emp
    {
        public String AnalyseMood(String message)
        {
            if (message.Contains("Sad"))
                return "SAD";
            else
                return "HAPPY";
            {
                Console.WriteLine(message);

                }
        }
    }
    }


