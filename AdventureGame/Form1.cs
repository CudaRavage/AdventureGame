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

        public void TextBox()
        {
            DetailText.Text += "test\r\n";
           
        }


        public void FightEnemy()
        {
            enemyHP = rand.Next(75, 100);
            enemyAttack = rand.Next(12, 17);

            DetailText.Text += "Enemy has " + enemyHP + " HP\r\n";
            

            //DetailText.ScrollToEnd();



        }


        private void FightBtn_Click(object sender, EventArgs e)
        {
    

            // if currently fighting something
                // continue fighting



            // if not currently fighting
                // creat new thing to fight




            //-------------------- test code for textbox below


            TextBox();
            FightEnemy();


            gold += 1;
            pots++;

            UpdateStats();
            

            DetailText.SelectionStart = DetailText.Text.Length;
            DetailText.ScrollToCaret();

        }

        private void HPText_Click(object sender, EventArgs e)
        {

        }
    }
}
