using System;
using System.Collections.Generic;

namespace App3
{
    public class Questions
    {
        private Questions(string whatWhouldYouLikeToUseInABattle)
        {
            
        }

        public Questions(String prompt, String left, String right, int affirmtive, int negative)
        {
            Prompt = prompt;
            Left = left;
            Right = right;
            Affirmative = affirmtive;
            Negative = negative;
        }

        public String Prompt { private set; get; }
        public String Left { private set; get; }
        public String Right { private set; get; }
        public int Affirmative { private set; get; }
        
        public int Negative {private set; get;}

        static Questions()
        {
            List<Questions> all = new List<Questions>
            {
                new Questions("What whould you like to use in a battle?", "Wepens made of steel","Magic", 0,4),
                new Questions("What is your best atubute", "your stranth", "your charm",0,4)
                
            };
            All = all;

        }
        
        public static IList<Questions> All { private set; get; }
    }
}