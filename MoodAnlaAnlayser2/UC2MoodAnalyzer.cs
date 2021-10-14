using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnlaAnlayser2
{
    class MoodAnalyzer
    {
        string msg;
        public MoodAnalyzer(string msg)
        {
            this.msg = msg;
        }

        public string AnalyseMood()
        {
            try
            {

                if (msg.ToLower().Contains("any"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                return "happy";

            }


        }
    }
}
   