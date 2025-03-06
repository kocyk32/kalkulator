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
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bwynik
            // 
            bwynik.Location = new Point(44, 172);
            bwynik.Name = "bwynik";
            bwynik.Size = new Size(84, 23);
            bwynik.TabIndex = 4;
            bwynik.Text = "=";
            bwynik.UseVisualStyleBackColor = true;
            // 
            // b9
            // 
            b9.Location = new Point(104, 80);
            b9.Name = "b9";
            b9.Size = new Size(24, 23);
            b9.TabIndex = 6;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            // 
            // b6
            // 
            b6.Location = new Point(104, 109);
            b6.Name = "b6";
            b6.Size = new Size(24, 23);
            b6.TabIndex = 7;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            b3.Location = new Point(104, 143);
            b3.Name = "b3";
            b3.Size = new Size(24, 23);
            b3.TabIndex = 8;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
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
            // 
            // b2
            // 
            b2.Location = new Point(74, 143);
            b2.Name = "b2";
            b2.Size = new Size(24, 23);
            b2.TabIndex = 12;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
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
            // 
            // b1
            // 
            b1.Location = new Point(44, 143);
            b1.Name = "b1";
            b1.Size = new Size(24, 23);
            b1.TabIndex = 16;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            // 
            // bdzielenie
            // 
            bdzielenie.Location = new Point(134, 80);
            bdzielenie.Name = "bdzielenie";
            bdzielenie.Size = new Size(24, 23);
            bdzielenie.TabIndex = 21;
            bdzielenie.Text = "÷";
            bdzielenie.UseVisualStyleBackColor = true;
            // 
            // bdodawanie
            // 
            bdodawanie.Location = new Point(134, 172);
            bdodawanie.Name = "bdodawanie";
            bdodawanie.Size = new Size(24, 23);
            bdodawanie.TabIndex = 20;
            bdodawanie.Text = "+";
            bdodawanie.UseVisualStyleBackColor = true;
            // 
            // bodejmowanie
            // 
            bodejmowanie.Location = new Point(134, 143);
            bodejmowanie.Name = "bodejmowanie";
            bodejmowanie.Size = new Size(24, 23);
            bodejmowanie.TabIndex = 19;
            bodejmowanie.Text = "-";
            bodejmowanie.UseVisualStyleBackColor = true;
            // 
            // bmnozenie
            // 
            bmnozenie.Location = new Point(134, 109);
            bmnozenie.Name = "bmnozenie";
            bmnozenie.Size = new Size(24, 23);
            bmnozenie.TabIndex = 18;
            bmnozenie.Text = "x";
            bmnozenie.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(114, 48);
            label1.TabIndex = 22;
            label1.Text = "WYNIK:";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(b5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bwynik);
            panel1.Controls.Add(bdzielenie);
            panel1.Controls.Add(b9);
            panel1.Controls.Add(bdodawanie);
            panel1.Controls.Add(b6);
            panel1.Controls.Add(bodejmowanie);
            panel1.Controls.Add(b3);
            panel1.Controls.Add(bmnozenie);
            panel1.Controls.Add(b8);
            panel1.Controls.Add(b1);
            panel1.Controls.Add(b2);
            panel1.Controls.Add(b4);
            panel1.Controls.Add(b7);
            panel1.Location = new Point(298, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 229);
            panel1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
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
        private Label label1;
        private Panel panel1;
    }
}
