namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bwynik = new Button();
            b9 = new Button();
            b6 = new Button();
            b3 = new Button();
            b8 = new Button();
            b5 = new Button();
            b2 = new Button();
            b7 = new Button();
            b4 = new Button();
            b1 = new Button();
            bdzielenie = new Button();
            bdodawanie = new Button();
            bodejmowanie = new Button();
            bmnozenie = new Button();
            wynik = new Label();
            kalkulator = new Panel();
            clear = new Button();
            b0 = new Button();
            kalkulator.SuspendLayout();
            SuspendLayout();
            // 
            // bwynik
            // 
            bwynik.Location = new Point(134, 80);
            bwynik.Name = "bwynik";
            bwynik.Size = new Size(24, 23);
            bwynik.TabIndex = 4;
            bwynik.Text = "=";
            bwynik.UseVisualStyleBackColor = true;
            bwynik.Click += bwynik_Click;
            // 
            // b9
            // 
            b9.Location = new Point(104, 80);
            b9.Name = "b9";
            b9.Size = new Size(24, 23);
            b9.TabIndex = 6;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b6
            // 
            b6.Location = new Point(104, 109);
            b6.Name = "b6";
            b6.Size = new Size(24, 23);
            b6.TabIndex = 7;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b3
            // 
            b3.Location = new Point(104, 143);
            b3.Name = "b3";
            b3.Size = new Size(24, 23);
            b3.TabIndex = 8;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b8
            // 
            b8.Location = new Point(74, 80);
            b8.Name = "b8";
            b8.Size = new Size(24, 23);
            b8.TabIndex = 10;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += button10_Click;
            // 
            // b5
            // 
            b5.Location = new Point(74, 109);
            b5.Name = "b5";
            b5.Size = new Size(24, 23);
            b5.TabIndex = 11;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b2
            // 
            b2.Location = new Point(74, 143);
            b2.Name = "b2";
            b2.Size = new Size(24, 23);
            b2.TabIndex = 12;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b7
            // 
            b7.Location = new Point(44, 80);
            b7.Name = "b7";
            b7.Size = new Size(24, 23);
            b7.TabIndex = 14;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += button14_Click;
            // 
            // b4
            // 
            b4.Location = new Point(44, 109);
            b4.Name = "b4";
            b4.Size = new Size(24, 23);
            b4.TabIndex = 15;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b1
            // 
            b1.Location = new Point(44, 143);
            b1.Name = "b1";
            b1.Size = new Size(24, 23);
            b1.TabIndex = 16;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // bdzielenie
            // 
            bdzielenie.Location = new Point(134, 109);
            bdzielenie.Name = "bdzielenie";
            bdzielenie.Size = new Size(24, 23);
            bdzielenie.TabIndex = 21;
            bdzielenie.Text = "÷";
            bdzielenie.UseVisualStyleBackColor = true;
            bdzielenie.Click += bdzielenie_Click;
            // 
            // bdodawanie
            // 
            bdodawanie.Location = new Point(104, 172);
            bdodawanie.Name = "bdodawanie";
            bdodawanie.Size = new Size(24, 23);
            bdodawanie.TabIndex = 20;
            bdodawanie.Text = "+";
            bdodawanie.UseVisualStyleBackColor = true;
            bdodawanie.Click += bdodawanie_Click;
            // 
            // bodejmowanie
            // 
            bodejmowanie.Location = new Point(134, 172);
            bodejmowanie.Name = "bodejmowanie";
            bodejmowanie.Size = new Size(24, 23);
            bodejmowanie.TabIndex = 19;
            bodejmowanie.Text = "-";
            bodejmowanie.UseVisualStyleBackColor = true;
            bodejmowanie.Click += bodejmowanie_Click;
            // 
            // bmnozenie
            // 
            bmnozenie.Location = new Point(134, 143);
            bmnozenie.Name = "bmnozenie";
            bmnozenie.Size = new Size(24, 23);
            bmnozenie.TabIndex = 18;
            bmnozenie.Text = "x";
            bmnozenie.UseVisualStyleBackColor = true;
            bmnozenie.Click += bmnozenie_Click;
            // 
            // wynik
            // 
            wynik.ForeColor = SystemColors.ActiveCaptionText;
            wynik.Location = new Point(44, 29);
            wynik.Name = "wynik";
            wynik.Size = new Size(114, 48);
            wynik.TabIndex = 22;
            wynik.Text = "WYNIK:";
            wynik.TextAlign = ContentAlignment.TopCenter;
            wynik.UseMnemonic = false;
            wynik.Click += label1_Click;
            // 
            // kalkulator
            // 
            kalkulator.Controls.Add(b0);
            kalkulator.Controls.Add(clear);
            kalkulator.Controls.Add(b5);
            kalkulator.Controls.Add(wynik);
            kalkulator.Controls.Add(bwynik);
            kalkulator.Controls.Add(bdzielenie);
            kalkulator.Controls.Add(b9);
            kalkulator.Controls.Add(bdodawanie);
            kalkulator.Controls.Add(b6);
            kalkulator.Controls.Add(bodejmowanie);
            kalkulator.Controls.Add(b3);
            kalkulator.Controls.Add(bmnozenie);
            kalkulator.Controls.Add(b8);
            kalkulator.Controls.Add(b1);
            kalkulator.Controls.Add(b2);
            kalkulator.Controls.Add(b4);
            kalkulator.Controls.Add(b7);
            kalkulator.Location = new Point(1, 1);
            kalkulator.Name = "kalkulator";
            kalkulator.Size = new Size(200, 229);
            kalkulator.TabIndex = 23;
            // 
            // clear
            // 
            clear.Location = new Point(44, 172);
            clear.Name = "clear";
            clear.Size = new Size(24, 23);
            clear.TabIndex = 23;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += button1_Click_1;
            // 
            // b0
            // 
            b0.Location = new Point(74, 172);
            b0.Name = "b0";
            b0.Size = new Size(24, 23);
            b0.TabIndex = 24;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 229);
            Controls.Add(kalkulator);
            Name = "Form1";
            Text = "Form1";
            kalkulator.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button bwynik;
        private Button b9;
        private Button b6;
        private Button b3;
        private Button b8;
        private Button b5;
        private Button b2;
        private Button b7;
        private Button b4;
        private Button b1;
        private Button bdzielenie;
        private Button bdodawanie;
        private Button bodejmowanie;
        private Button bmnozenie;
        private Label wynik;
        private Panel kalkulator;
        private Button clear;
        private Button b0;
    }
}
