namespace KlasesSarasas
{
    partial class NaujasAuto
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
            this.textBoxMarke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModelis = new System.Windows.Forms.TextBox();
            this.textBoxMetai = new System.Windows.Forms.TextBox();
            this.textBoxDarbinisTuris = new System.Windows.Forms.TextBox();
            this.textBoxKuras = new System.Windows.Forms.TextBox();
            this.buttonGerai = new System.Windows.Forms.Button();
            this.buttonAtsaukti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMarke
            // 
            this.textBoxMarke.Location = new System.Drawing.Point(82, 19);
            this.textBoxMarke.Name = "textBoxMarke";
            this.textBoxMarke.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarke.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Metai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Darbinis turis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kuro tipas";
            // 
            // textBoxModelis
            // 
            this.textBoxModelis.Location = new System.Drawing.Point(82, 47);
            this.textBoxModelis.Name = "textBoxModelis";
            this.textBoxModelis.Size = new System.Drawing.Size(100, 20);
            this.textBoxModelis.TabIndex = 6;
            // 
            // textBoxMetai
            // 
            this.textBoxMetai.Location = new System.Drawing.Point(82, 74);
            this.textBoxMetai.Name = "textBoxMetai";
            this.textBoxMetai.Size = new System.Drawing.Size(100, 20);
            this.textBoxMetai.TabIndex = 7;
            // 
            // textBoxDarbinisTuris
            // 
            this.textBoxDarbinisTuris.Location = new System.Drawing.Point(82, 102);
            this.textBoxDarbinisTuris.Name = "textBoxDarbinisTuris";
            this.textBoxDarbinisTuris.Size = new System.Drawing.Size(100, 20);
            this.textBoxDarbinisTuris.TabIndex = 8;
            // 
            // textBoxKuras
            // 
            this.textBoxKuras.Location = new System.Drawing.Point(82, 132);
            this.textBoxKuras.Name = "textBoxKuras";
            this.textBoxKuras.Size = new System.Drawing.Size(100, 20);
            this.textBoxKuras.TabIndex = 9;
            // 
            // buttonGerai
            // 
            this.buttonGerai.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonGerai.Location = new System.Drawing.Point(19, 178);
            this.buttonGerai.Name = "buttonGerai";
            this.buttonGerai.Size = new System.Drawing.Size(75, 23);
            this.buttonGerai.TabIndex = 10;
            this.buttonGerai.Text = "Gerai";
            this.buttonGerai.UseVisualStyleBackColor = true;
            this.buttonGerai.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAtsaukti
            // 
            this.buttonAtsaukti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAtsaukti.Location = new System.Drawing.Point(125, 178);
            this.buttonAtsaukti.Name = "buttonAtsaukti";
            this.buttonAtsaukti.Size = new System.Drawing.Size(75, 23);
            this.buttonAtsaukti.TabIndex = 11;
            this.buttonAtsaukti.Text = "Atsaukti";
            this.buttonAtsaukti.UseVisualStyleBackColor = true;
            // 
            // NaujasAuto
            // 
            this.AcceptButton = this.buttonGerai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAtsaukti;
            this.ClientSize = new System.Drawing.Size(489, 319);
            this.Controls.Add(this.buttonAtsaukti);
            this.Controls.Add(this.buttonGerai);
            this.Controls.Add(this.textBoxKuras);
            this.Controls.Add(this.textBoxDarbinisTuris);
            this.Controls.Add(this.textBoxMetai);
            this.Controls.Add(this.textBoxModelis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMarke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NaujasAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NaujasAuto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMarke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxModelis;
        private System.Windows.Forms.TextBox textBoxMetai;
        private System.Windows.Forms.TextBox textBoxDarbinisTuris;
        private System.Windows.Forms.TextBox textBoxKuras;
        private System.Windows.Forms.Button buttonGerai;
        private System.Windows.Forms.Button buttonAtsaukti;
    }
}