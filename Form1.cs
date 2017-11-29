using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //generated est un string qui désigne le nom de la couleur généré aléatoirement
        //colorgen string globale, couleur généré aussi
        //score le score du joueur


        int score = 0;
        string colorgen = "";

        public Form1()
        {
            
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        //bouton Bleu
        private void button1_Click(object sender, EventArgs e)
        {
            if ("Bleu" == colorgen)
            {
                score += 1;
                label2.Text = "score : " + score.ToString();
            }

        }
        //bouton Rouge
        private void buttonRouge_Click(object sender, EventArgs e)
        {
           if ("Rouge" == colorgen)
           {
                score += 1;
                label2.Text = "score : " + score.ToString();
           }
            
        }
        //bouton Rose
        private void buttonRose_Click(object sender, EventArgs e)
        {
            if ("Rose" == colorgen)
            {
                score += 1;
                label2.Text = "score : " + score.ToString();
            }
        }
        //bouton Vert
        private void button2_Click(object sender, EventArgs e)
        {
            int j = 0;
            if ("Vert" == colorgen && j < 1)
            {
                score += 1;
                label2.Text = "score : " + score.ToString();
                
            }
        }
        //bouton OK
        private void buttonrst_Click(object sender, EventArgs e)
        {
            colorgen = fctgennum();
            Score();
        }

        public int Score()
        {

            label2.Text = "score : " + score.ToString();
            return score;
        }

        public string fctgennum()
        {
            string[] str = { "Rouge", "Bleu", "Rose", "Vert" };

            Random rng = new Random();

            int i = rng.Next(0, str.Length);
            string generated = str[i];

            //affiche le nom de la couleur
            label1.Text = generated;

            //retourne le nb généré
            return generated;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        

        

        private void fontDialog2_Apply(object sender, EventArgs e)
        {

        }

        int time = 15;
        private void tpsjeu_Tick(object sender, EventArgs e)
        {
            time--;
            if (time == 0)
            {
                DialogResult result = MessageBox.Show("TIME'S OUT!!" +
                    " voulez-vous réessayer ??", "Un Titre", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
                   
            }
        }

        private void intervallecouleur_Tick(object sender, EventArgs e)
        {
            t++;
            if (t % 2 == 1)
            {

                colorgen = fctgennum();
            }
        }
    }
}
