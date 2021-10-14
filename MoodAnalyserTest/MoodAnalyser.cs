using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer2
{
    public class MoodAnalyser
    {
        public class MoodAnalyser2
        {
            public string AnalyseMood(string msg)
            {
                if (msg.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else if (msg.ToLower().Contains("any"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
        }

    }
}