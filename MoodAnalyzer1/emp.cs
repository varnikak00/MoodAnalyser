using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer1
{
    class emp
    {
        public String analyseMood(String message)
        {
            if (message.Contains("Sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
    }


