namespace Haromszogek
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
            this.btn_AdatokBetoltese = new System.Windows.Forms.Button();
            this.gb_HibaLista = new System.Windows.Forms.GroupBox();
            this.listBox_HibaLista = new System.Windows.Forms.ListBox();
            this.gb_DerekszoguHaromszogek = new System.Windows.Forms.GroupBox();
            this.listBox_HaromszogekLista = new System.Windows.Forms.ListBox();
            this.gb_HaromszogAdatai = new System.Windows.Forms.GroupBox();
            this.l_keruletLabel = new System.Windows.Forms.Label();
            this.l_teruletLabel = new System.Windows.Forms.Label();
            this.l_keruletErtek = new System.Windows.Forms.Label();
            this.l_teruletErtek = new System.Windows.Forms.Label();
            this.gb_HibaLista.SuspendLayout();
            this.gb_DerekszoguHaromszogek.SuspendLayout();
            this.gb_HaromszogAdatai.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AdatokBetoltese
            // 
            this.btn_AdatokBetoltese.Location = new System.Drawing.Point(12, 24);
            this.btn_AdatokBetoltese.Name = "btn_AdatokBetoltese";
            this.btn_AdatokBetoltese.Size = new System.Drawing.Size(139, 23);
            this.btn_AdatokBetoltese.TabIndex = 0;
            this.btn_AdatokBetoltese.Text = "Adatok betöltése";
            this.btn_AdatokBetoltese.UseVisualStyleBackColor = true;
            this.btn_AdatokBetoltese.Click += new System.EventHandler(this.btn_AdatokBetoltese_Click);
            // 
            // gb_HibaLista
            // 
            this.gb_HibaLista.Controls.Add(this.listBox_HibaLista);
            this.gb_HibaLista.Location = new System.Drawing.Point(12, 68);
            this.gb_HibaLista.Name = "gb_HibaLista";
            this.gb_HibaLista.Size = new System.Drawing.Size(508, 132);
            this.gb_HibaLista.TabIndex = 1;
            this.gb_HibaLista.TabStop = false;
            this.gb_HibaLista.Text = "Hibák a kiválasztott állományban";
            // 
            // listBox_HibaLista
            // 
            this.listBox_HibaLista.Enabled = false;
            this.listBox_HibaLista.FormattingEnabled = true;
            this.listBox_HibaLista.Location = new System.Drawing.Point(6, 19);
            this.listBox_HibaLista.Name = "listBox_HibaLista";
            this.listBox_HibaLista.Size = new System.Drawing.Size(496, 108);
            this.listBox_HibaLista.TabIndex = 1;
            // 
            // gb_DerekszoguHaromszogek
            // 
            this.gb_DerekszoguHaromszogek.Controls.Add(this.listBox_HaromszogekLista);
            this.gb_DerekszoguHaromszogek.Location = new System.Drawing.Point(12, 206);
            this.gb_DerekszoguHaromszogek.Name = "gb_DerekszoguHaromszogek";
            this.gb_DerekszoguHaromszogek.Size = new System.Drawing.Size(200, 159);
            this.gb_DerekszoguHaromszogek.TabIndex = 2;
            this.gb_DerekszoguHaromszogek.TabStop = false;
            this.gb_DerekszoguHaromszogek.Text = "Derékszögű háromszögek";
            // 
            // listBox_HaromszogekLista
            // 
            this.listBox_HaromszogekLista.FormattingEnabled = true;
            this.listBox_HaromszogekLista.Location = new System.Drawing.Point(6, 19);
            this.listBox_HaromszogekLista.Name = "listBox_HaromszogekLista";
            this.listBox_HaromszogekLista.Size = new System.Drawing.Size(188, 134);
            this.listBox_HaromszogekLista.TabIndex = 0;
            this.listBox_HaromszogekLista.SelectedIndexChanged += new System.EventHandler(this.listBox_HaromszogekLista_SelectedIndexChanged);
            // 
            // gb_HaromszogAdatai
            // 
            this.gb_HaromszogAdatai.Controls.Add(this.l_teruletErtek);
            this.gb_HaromszogAdatai.Controls.Add(this.l_keruletErtek);
            this.gb_HaromszogAdatai.Controls.Add(this.l_teruletLabel);
            this.gb_HaromszogAdatai.Controls.Add(this.l_keruletLabel);
            this.gb_HaromszogAdatai.Location = new System.Drawing.Point(218, 206);
            this.gb_HaromszogAdatai.Name = "gb_HaromszogAdatai";
            this.gb_HaromszogAdatai.Size = new System.Drawing.Size(302, 93);
            this.gb_HaromszogAdatai.TabIndex = 3;
            this.gb_HaromszogAdatai.TabStop = false;
            this.gb_HaromszogAdatai.Text = "Kiválasztott derékszögű háromszög adatai";
            // 
            // l_keruletLabel
            // 
            this.l_keruletLabel.AutoSize = true;
            this.l_keruletLabel.Location = new System.Drawing.Point(20, 31);
            this.l_keruletLabel.Name = "l_keruletLabel";
            this.l_keruletLabel.Size = new System.Drawing.Size(52, 13);
            this.l_keruletLabel.TabIndex = 0;
            this.l_keruletLabel.Text = "Kerület = ";
            // 
            // l_teruletLabel
            // 
            this.l_teruletLabel.AutoSize = true;
            this.l_teruletLabel.Location = new System.Drawing.Point(20, 56);
            this.l_teruletLabel.Name = "l_teruletLabel";
            this.l_teruletLabel.Size = new System.Drawing.Size(52, 13);
            this.l_teruletLabel.TabIndex = 1;
            this.l_teruletLabel.Text = "Terület = ";
            // 
            // l_keruletErtek
            // 
            this.l_keruletErtek.AutoSize = true;
            this.l_keruletErtek.Location = new System.Drawing.Point(65, 31);
            this.l_keruletErtek.Name = "l_keruletErtek";
            this.l_keruletErtek.Size = new System.Drawing.Size(13, 13);
            this.l_keruletErtek.TabIndex = 2;
            this.l_keruletErtek.Text = "0";
            // 
            // l_teruletErtek
            // 
            this.l_teruletErtek.AutoSize = true;
            this.l_teruletErtek.Location = new System.Drawing.Point(65, 56);
            this.l_teruletErtek.Name = "l_teruletErtek";
            this.l_teruletErtek.Size = new System.Drawing.Size(13, 13);
            this.l_teruletErtek.TabIndex = 3;
            this.l_teruletErtek.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 377);
            this.Controls.Add(this.gb_HaromszogAdatai);
            this.Controls.Add(this.gb_DerekszoguHaromszogek);
            this.Controls.Add(this.gb_HibaLista);
            this.Controls.Add(this.btn_AdatokBetoltese);
            this.Name = "Form1";
            this.Text = "Derékszögű háromszögek";
            this.gb_HibaLista.ResumeLayout(false);
            this.gb_DerekszoguHaromszogek.ResumeLayout(false);
            this.gb_HaromszogAdatai.ResumeLayout(false);
            this.gb_HaromszogAdatai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AdatokBetoltese;
        private System.Windows.Forms.GroupBox gb_HibaLista;
        private System.Windows.Forms.ListBox listBox_HibaLista;
        private System.Windows.Forms.GroupBox gb_DerekszoguHaromszogek;
        private System.Windows.Forms.ListBox listBox_HaromszogekLista;
        private System.Windows.Forms.GroupBox gb_HaromszogAdatai;
        private System.Windows.Forms.Label l_teruletLabel;
        private System.Windows.Forms.Label l_keruletLabel;
        private System.Windows.Forms.Label l_teruletErtek;
        private System.Windows.Forms.Label l_keruletErtek;
    }
}

