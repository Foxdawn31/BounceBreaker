using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BounceBreaker
{
    public static class Contexte
    {
        static int Score;
        static int Lives;

        static Contexte()
        {
            Score = 0;
            Lives = 4 ;
        }
    }
}
