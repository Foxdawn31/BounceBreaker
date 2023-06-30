using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BounceBreaker
{
    public static class Contexte
    {
        public static int score { get; private set; }
        static int Lives;

        public static int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                if (score > 1500)
                    Lives++;

            }
        }

        static Contexte()
        {
            score = 0;
            Lives = 4 ;
        }
    }
}
