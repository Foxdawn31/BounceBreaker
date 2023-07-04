using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public static class Contexte
    {
        public static int score { get; private set; }

        public static int lives;

        public static void AddScore(int points)
        {
            score += points; 
        }

        static Contexte()
        {
            score = 0;
            lives = 4 ;
        }
    }

