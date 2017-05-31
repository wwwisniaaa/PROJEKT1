namespace PROJEKT1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gracz1 = new System.Windows.Forms.PictureBox();
            this.pilka = new System.Windows.Forms.PictureBox();
            this.gracz2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.punkty1 = new System.Windows.Forms.Label();
            this.punkty2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gracz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz2)).BeginInit();
            this.SuspendLayout();
            // 
            // gracz1
            // 
            this.gracz1.BackColor = System.Drawing.Color.Blue;
            this.gracz1.Location = new System.Drawing.Point(12, 215);
            this.gracz1.Name = "gracz1";
            this.gracz1.Size = new System.Drawing.Size(20, 150);
            this.gracz1.TabIndex = 0;
            this.gracz1.TabStop = false;
            // 
            // pilka
            // 
            this.pilka.BackColor = System.Drawing.Color.Red;
            this.pilka.Location = new System.Drawing.Point(200, 287);
            this.pilka.Name = "pilka";
            this.pilka.Size = new System.Drawing.Size(15, 15);
            this.pilka.TabIndex = 1;
            this.pilka.TabStop = false;
            // 
            // gracz2
            // 
            this.gracz2.BackColor = System.Drawing.Color.Lime;
            this.gracz2.Location = new System.Drawing.Point(396, 215);
            this.gracz2.Name = "gracz2";
            this.gracz2.Size = new System.Drawing.Size(20, 150);
            this.gracz2.TabIndex = 2;
            this.gracz2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // punkty1
            // 
            this.punkty1.AutoSize = true;
            this.punkty1.BackColor = System.Drawing.Color.Black;
            this.punkty1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punkty1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.punkty1.Location = new System.Drawing.Point(6, 9);
            this.punkty1.Name = "punkty1";
            this.punkty1.Size = new System.Drawing.Size(32, 32);
            this.punkty1.TabIndex = 3;
            this.punkty1.Text = "0";
            // 
            // punkty2
            // 
            this.punkty2.AutoSize = true;
            this.punkty2.BackColor = System.Drawing.Color.Black;
            this.punkty2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punkty2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.punkty2.Location = new System.Drawing.Point(384, 9);
            this.punkty2.Name = "punkty2";
            this.punkty2.Size = new System.Drawing.Size(32, 32);
            this.punkty2.TabIndex = 4;
            this.punkty2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(428, 594);
            this.Controls.Add(this.punkty2);
            this.Controls.Add(this.punkty1);
            this.Controls.Add(this.gracz2);
            this.Controls.Add(this.pilka);
            this.Controls.Add(this.gracz1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gracz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gracz1;
        private System.Windows.Forms.PictureBox pilka;
        private System.Windows.Forms.PictureBox gracz2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label punkty1;
        private System.Windows.Forms.Label punkty2;
    }
}

