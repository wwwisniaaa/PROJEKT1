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
       

        int g1Pred;
        int g2Pred;

        int pPredX = 2;
        int pPredY = 2;

        int g1Punkty;
        int g2Punkty;

        TextBox pole_tekstowe1 = new TextBox();
        TextBox pole_tekstowe2 = new TextBox();

        bool pauza = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();

            Form okno = new Form();
            okno.Width = 300;
            okno.Height = 300;
            okno.Text = "Imiona graczy";
            okno.BackColor = Color.Beige;
            okno.MaximumSize = new System.Drawing.Size(300, 300);
            okno.MinimumSize = new System.Drawing.Size(300, 300);
            okno.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;


            Label etykieta1 = new Label();
            etykieta1.Text = "Imię pierwszego gracza";
            etykieta1.Font = new System.Drawing.Font("Arial", 5, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            etykieta1.Location = new Point(10, 10);
            etykieta1.Width = 300;
            etykieta1.Height = 30;

            
            pole_tekstowe1.Width = 200;
            pole_tekstowe1.Location = new Point(10, 50);

            Label etykieta2 = new Label();
            etykieta2.Text = "Imię drugiego gracza";
            etykieta2.Font = new System.Drawing.Font("Arial", 5, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            etykieta2.Location = new Point(10, 100);
            etykieta2.Width = 300;
            etykieta2.Height = 30;

            
            pole_tekstowe2.Width = 200;
            pole_tekstowe2.Location = new Point(10, 150);

            Button przycisk = new Button();
            przycisk.Width = 100;
            przycisk.Height = 35;
            przycisk.Location = new Point(10, 200);
            przycisk.Text = "GRAJ";
            przycisk.Font = new System.Drawing.Font("Arial", 6, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            przycisk.BackColor = Color.HotPink;
            przycisk.DialogResult = DialogResult.OK;


            okno.Controls.Add(etykieta1);
            okno.Controls.Add(pole_tekstowe1);
            okno.Controls.Add(etykieta2);
            okno.Controls.Add(pole_tekstowe2);
            okno.Controls.Add(przycisk);

            okno.ShowDialog();

            timer1.Start();
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

            

            if (g1Punkty == 5 || g2Punkty ==5)
            {
                Form okno1 = new Form();
                okno1.Width = 300;
                okno1.Height = 300;
                okno1.Text = "Koniec Gry";
                okno1.BackColor = Color.Beige;
                okno1.MaximumSize = new System.Drawing.Size(300, 300);
                okno1.MinimumSize = new System.Drawing.Size(300, 300);
                okno1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                timer1.Stop();

                Label etykieta3 = new Label();
                etykieta3.Text = "Zwycięzca:";
                etykieta3.Font = new System.Drawing.Font("Arial", 8, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
                etykieta3.Location = new Point(10, 50);
                etykieta3.Width = 300;
                etykieta3.Height = 40;
                etykieta3.ForeColor = Color.Black;

                Label etykieta4 = new Label();
                if (g1Punkty == 5)
                {
                    etykieta4.Text = pole_tekstowe1.Text;
                }
                else if (g2Punkty == 5)
                {
                    etykieta4.Text = pole_tekstowe2.Text;
                }

                etykieta4.Font = new System.Drawing.Font("Arial", 8, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
                etykieta4.Location = new Point(10, 100);
                etykieta4.Width = 300;
                etykieta4.Height = 40;
                etykieta4.ForeColor = Color.DarkViolet;

                okno1.Controls.Add(etykieta3);
                okno1.Controls.Add(etykieta4);
                okno1.ShowDialog();
            }


            if (pilka.Location.Y > gracz2.Location.Y && pilka.Location.Y + pilka.Height < gracz2.Location.Y + gracz2.Height && pilka.Location.X + pilka.Width > gracz2.Location.X)
            {
                pPredX *= -1;
            }

            if (pilka.Location.Y > gracz1.Location.Y && pilka.Location.Y + pilka.Height < gracz1.Location.Y + gracz1.Height && pilka.Location.X < gracz1.Location.X + gracz1.Width)
            {
                pPredX *= -1;
            }

            if (pilka.Location.Y < 0 )
            {
                pPredY *= -1;
            }

            if(pilka.Location.Y + 5*(pilka.Height) > this.Height)
            {
                pPredY *= -1;
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
