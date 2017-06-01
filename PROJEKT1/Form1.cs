using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT1
{
    public partial class Form1 : Form
    {

        int szybkoscgracza = 7;
        int szybkoscpilki;

        int g1Pred;
        int g2Pred;

        int pPredX = 2;
        int pPredY = 2;

        int g1Punkty;
        int g2Punkty;


        bool pauza = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void punkty1_Click(object sender, EventArgs e)
        {

        }

        private void gracz1_Click(object sender, EventArgs e)
        {

        }

        private void pilka_Click(object sender, EventArgs e)
        {

        }

        private void gracz2_Click(object sender, EventArgs e)
        {

        }

        private void punkty2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!pauza)
            {
                pilka.Location = new Point(pilka.Location.X + pPredX, pilka.Location.Y + pPredY);
                gracz1.Location = new Point(gracz1.Location.X, gracz1.Location.Y + g1Pred);
                gracz2.Location = new Point(gracz2.Location.X, gracz2.Location.Y + g2Pred);
            }

            if (pilka.Location.X < 0)
            {
                g2Punkty++;
                pilka.Location = new Point(this.Width / 2, this.Height / 2);
            }
            if (pilka.Location.X > this.Width)
            {
                g1Punkty++;
                pilka.Location = new Point(this.Width / 2, this.Height / 2);

            }

            if (pilka.Location.Y > gracz2.Location.Y && pilka.Location.Y + pilka.Height < gracz2.Location.Y + gracz2.Height && pilka.Location.X + pilka.Width > gracz2.Location.X)
            {
                pPredX *= -1;
            }

            if (pilka.Location.Y > gracz1.Location.Y && pilka.Location.Y + pilka.Height < gracz1.Location.Y + gracz1.Height && pilka.Location.X < gracz1.Location.X + gracz1.Width)
            {
                pPredX *= -1;
            }

            punkty1.Text = g1Punkty.ToString();
            punkty2.Text = g2Punkty.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                g2Pred = szybkoscgracza;
            }
            else if (e.KeyCode == Keys.Up)
            {
                g2Pred = -szybkoscgracza;
            }
            else if (e.KeyCode == Keys.S)
            {
                g1Pred = szybkoscgracza;
            }
            else  if (e.KeyCode == Keys.W)
            {
                g1Pred = - szybkoscgracza;
            }
            else if (e.KeyCode == Keys.P)
            {
                if (!pauza)
                {
                    pauza = true;
                }
                else if (pauza)
                {
                    pauza = false;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                g2Pred = 0;
            }
            else if (e.KeyCode == Keys.Up)
            {
                g2Pred = 0;
            }
            else if (e.KeyCode == Keys.S)
            {
                g1Pred = 0;
            }
            else if (e.KeyCode == Keys.W)
            {
                g1Pred = 0;
            }
        }
    }
}
