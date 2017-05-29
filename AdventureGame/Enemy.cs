using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Enemy
    {
        private int health;
        private int damage;
        private int gold;
        private int healthPot;

        

        public Enemy(int health, int damage, int gold, int healhPot)
        {

        this.health = health;
        this.damage = damage;
        this.gold = gold;
        this.healthPot = healthPot;

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
