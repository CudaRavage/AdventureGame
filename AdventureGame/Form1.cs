using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int health = 100;
        int gold = 0;
        int pots = 0;
        int enemyHP;
        int enemyAttack;
        int enemyGold;
        int enemyPots;
        bool enemyAlive = false;

        

        public void CreateEnemy() // create new instance of enemy class
        {
            enemyHP = rand.Next(75, 100);
            enemyAttack = rand.Next(5, 7);
            enemyGold = rand.Next(30, 50);
            enemyPots = rand.Next(1, 2);
            Enemy newEnemy = new Enemy(enemyHP, enemyAttack, enemyGold, enemyPots); //int health, int damage, int gold, int healhPot
            enemyAlive = true;

            DetailText.Text += "You encounter a foe with " + enemyHP + " hitpoints." + "\r\n"; 
            DetailText.SelectionStart = DetailText.Text.Length; 
            DetailText.ScrollToCaret();

        }



        public void UpdateStats() // update text labels 
        {
            HPText.Text = Convert.ToString(health);
            GoldText.Text = Convert.ToString(gold);
            PotsText.Text = Convert.ToString(pots);
        }


        public Form1()
        {
            // game start, window opens - display default health/inventory == update to read/write later  

            InitializeComponent();
            HPText.Text = Convert.ToString(health);
            GoldText.Text = Convert.ToString(gold);
            PotsText.Text = Convert.ToString(pots);

        }




        public void FightEnemy()
        {
            //enemyHP = rand.Next(75, 100);
            //enemyAttack = rand.Next(12, 17);

            int attack = rand.Next(8, 12);

            DetailText.Text += "You attack for " + attack + " damage." + "\r\n";
            DetailText.SelectionStart = DetailText.Text.Length;
            DetailText.ScrollToCaret();

            enemyHP -= attack;

            if (enemyHP <= 0)
            {
                DetailText.Text += "Enemy has been defeated!" + "\r\n";
                DetailText.SelectionStart = DetailText.Text.Length;
                DetailText.ScrollToCaret();
                enemyAlive = false;
                gold = enemyGold;
                pots = enemyPots;

            }

            else
            {
                DetailText.Text += "Enemy has " + enemyHP + " HP";
                DetailText.Text += " and attacks you for " + enemyAttack + " \r\n";
                health -= enemyAttack;
                DetailText.SelectionStart = DetailText.Text.Length;
                DetailText.ScrollToCaret();

            }
        }


        private void FightBtn_Click(object sender, EventArgs e) // what do Attack button click
        {


            // if currently fighting something
            // continue fighting



            // if not currently fighting
            // creat new thing to fight




            //-------------------- test code for textbox below
            if (enemyAlive == true)
            {

                FightEnemy();


            }

            else if (enemyAlive == false)
            {
                CreateEnemy();
                enemyAlive = true;
            }


            //DetailText.Text += newEnemy.Health;  //======================================== RBF



            UpdateStats();
            

            DetailText.SelectionStart = DetailText.Text.Length; // Scroll to new line in TextBox
            DetailText.ScrollToCaret();                         //

        }

        private void HPText_Click(object sender, EventArgs e)
        {

        }

        private void healthButton_Click(object sender, EventArgs e) // Health potion button
        {
            if (pots > 0)  
            {
                pots -= 1;
                health += 10;

                if (health > 100)
                {
                    health = 100;
                    DetailText.Text += "You are at full health." + "\r\n";
                    DetailText.SelectionStart = DetailText.Text.Length; // Scroll to new line in TextBox
                    DetailText.ScrollToCaret();
                    HPText.Text = Convert.ToString(health);
                    PotsText.Text = Convert.ToString(pots);
                    return;
                }

                DetailText.Text += "You have healed 10 Hit Points" + "\r\n";
                HPText.Text = Convert.ToString(health);
                PotsText.Text = Convert.ToString(pots);
                DetailText.SelectionStart = DetailText.Text.Length; // Scroll to new line in TextBox
                DetailText.ScrollToCaret();                         //
            }
            else
            {
                DetailText.Text += "You are out of Health Potions." + "\r\n";
                DetailText.SelectionStart = DetailText.Text.Length; // Scroll to new line in TextBox
                DetailText.ScrollToCaret();                         //
            }

        }

        private void PotBtn_Click(object sender, EventArgs e) // buy potion button
        {
            if (gold >= 10)
            {
                gold =- 10; // need fix later
                pots =+ 1;
            }


        }
    }
}
