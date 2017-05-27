using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Enemy
    {
        private int health = 01;
        private int damage = 02;
        private int gold = 03;
        private int healthPot = 04;

        

        public Enemy()
        {
           
        }


        public int Health
        {
            get { return health; }
            set { health = value; }
        }


        public int GetHealth()
        {
            return health;
        }



    }
}
