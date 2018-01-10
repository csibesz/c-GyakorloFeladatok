namespace _4.Feladat___Tippeles
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
            this.tippel = new System.Windows.Forms.Button();
            this.ujjatek = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tippel
            // 
            this.tippel.Enabled = false;
            this.tippel.Location = new System.Drawing.Point(12, 12);
            this.tippel.Name = "tippel";
            this.tippel.Size = new System.Drawing.Size(75, 23);
            this.tippel.TabIndex = 0;
            this.tippel.Text = "Tippel";
            this.tippel.UseVisualStyleBackColor = true;
            this.tippel.Click += new System.EventHandler(this.tippel_Click);
            // 
            // ujjatek
            // 
            this.ujjatek.Location = new System.Drawing.Point(12, 41);
            this.ujjatek.Name = "ujjatek";
            this.ujjatek.Size = new System.Drawing.Size(75, 23);
            this.ujjatek.TabIndex = 1;
            this.ujjatek.Text = "Új Játék";
            this.ujjatek.UseVisualStyleBackColor = true;
            this.ujjatek.Click += new System.EventHandler(this.ujjatek_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(259, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(418, 342);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ujjatek);
            this.Controls.Add(this.tippel);
            this.Name = "Form1";
            this.Text = "Tippelj és Nyerj";
            this.Load += new System.EventHandler(this.ujjatek_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tippel;
        private System.Windows.Forms.Button ujjatek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

