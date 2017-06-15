namespace PrekiuSarasas
{
    partial class Naujas
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
            this.labelPav = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelKodas = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelKaina = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelSavikaina = new System.Windows.Forms.Label();
            this.buttonGerai = new System.Windows.Forms.Button();
            this.buttonAtsaukti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPav
            // 
            this.labelPav.AutoSize = true;
            this.labelPav.Location = new System.Drawing.Point(23, 25);
            this.labelPav.Name = "labelPav";
            this.labelPav.Size = new System.Drawing.Size(67, 13);
            this.labelPav.TabIndex = 0;
            this.labelPav.Text = "Pavadinimas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // labelKodas
            // 
            this.labelKodas.AutoSize = true;
            this.labelKodas.Location = new System.Drawing.Point(23, 51);
            this.labelKodas.Name = "labelKodas";
            this.labelKodas.Size = new System.Drawing.Size(37, 13);
            this.labelKodas.TabIndex = 2;
            this.labelKodas.Text = "Kodas";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // labelKaina
            // 
            this.labelKaina.AutoSize = true;
            this.labelKaina.Location = new System.Drawing.Point(23, 77);
            this.labelKaina.Name = "labelKaina";
            this.labelKaina.Size = new System.Drawing.Size(34, 13);
            this.labelKaina.TabIndex = 4;
            this.labelKaina.Text = "Kaina";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(84, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // labelSavikaina
            // 
            this.labelSavikaina.AutoSize = true;
            this.labelSavikaina.Location = new System.Drawing.Point(23, 103);
            this.labelSavikaina.Name = "labelSavikaina";
            this.labelSavikaina.Size = new System.Drawing.Size(54, 13);
            this.labelSavikaina.TabIndex = 6;
            this.labelSavikaina.Text = "Savikaina";
            // 
            // buttonGerai
            // 
            this.buttonGerai.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonGerai.Location = new System.Drawing.Point(47, 152);
            this.buttonGerai.Name = "buttonGerai";
            this.buttonGerai.Size = new System.Drawing.Size(75, 23);
            this.buttonGerai.TabIndex = 8;
            this.buttonGerai.Text = "Gerai";
            this.buttonGerai.UseVisualStyleBackColor = true;
            this.buttonGerai.Click += new System.EventHandler(this.buttonGerai_Click);
            // 
            // buttonAtsaukti
            // 
            this.buttonAtsaukti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAtsaukti.Location = new System.Drawing.Point(158, 151);
            this.buttonAtsaukti.Name = "buttonAtsaukti";
            this.buttonAtsaukti.Size = new System.Drawing.Size(75, 23);
            this.buttonAtsaukti.TabIndex = 9;
            this.buttonAtsaukti.Text = "Atsaukti";
            this.buttonAtsaukti.UseVisualStyleBackColor = true;
            // 
            // Naujas
            // 
            this.AcceptButton = this.buttonGerai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAtsaukti;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonAtsaukti);
            this.Controls.Add(this.buttonGerai);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelSavikaina);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelKaina);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelKodas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPav);
            this.Name = "Naujas";
            this.Text = "Naujas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPav;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelKodas;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelKaina;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelSavikaina;
        private System.Windows.Forms.Button buttonGerai;
        private System.Windows.Forms.Button buttonAtsaukti;
    }
}