namespace CvetkovskiIvorBingo
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
            this.textBoxPrvi = new System.Windows.Forms.TextBox();
            this.textBoxDrugi = new System.Windows.Forms.TextBox();
            this.textBoxTreci = new System.Windows.Forms.TextBox();
            this.textBoxSesti = new System.Windows.Forms.TextBox();
            this.textBoxPeti = new System.Windows.Forms.TextBox();
            this.textBoxCetvrti = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.richTextBoxIspis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxPrvi
            // 
            this.textBoxPrvi.Location = new System.Drawing.Point(12, 12);
            this.textBoxPrvi.Name = "textBoxPrvi";
            this.textBoxPrvi.Size = new System.Drawing.Size(22, 20);
            this.textBoxPrvi.TabIndex = 0;
            // 
            // textBoxDrugi
            // 
            this.textBoxDrugi.Location = new System.Drawing.Point(40, 12);
            this.textBoxDrugi.Name = "textBoxDrugi";
            this.textBoxDrugi.Size = new System.Drawing.Size(22, 20);
            this.textBoxDrugi.TabIndex = 1;
            // 
            // textBoxTreci
            // 
            this.textBoxTreci.Location = new System.Drawing.Point(68, 12);
            this.textBoxTreci.Name = "textBoxTreci";
            this.textBoxTreci.Size = new System.Drawing.Size(22, 20);
            this.textBoxTreci.TabIndex = 2;
            // 
            // textBoxSesti
            // 
            this.textBoxSesti.Location = new System.Drawing.Point(153, 12);
            this.textBoxSesti.Name = "textBoxSesti";
            this.textBoxSesti.Size = new System.Drawing.Size(22, 20);
            this.textBoxSesti.TabIndex = 3;
            // 
            // textBoxPeti
            // 
            this.textBoxPeti.Location = new System.Drawing.Point(124, 12);
            this.textBoxPeti.Name = "textBoxPeti";
            this.textBoxPeti.Size = new System.Drawing.Size(22, 20);
            this.textBoxPeti.TabIndex = 4;
            // 
            // textBoxCetvrti
            // 
            this.textBoxCetvrti.Location = new System.Drawing.Point(96, 12);
            this.textBoxCetvrti.Name = "textBoxCetvrti";
            this.textBoxCetvrti.Size = new System.Drawing.Size(22, 20);
            this.textBoxCetvrti.TabIndex = 5;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(12, 38);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 6;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(100, 38);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(75, 23);
            this.btnIspisi.TabIndex = 7;
            this.btnIspisi.Text = "Ispisi sve";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBoxIspis
            // 
            this.richTextBoxIspis.Location = new System.Drawing.Point(12, 67);
            this.richTextBoxIspis.Name = "richTextBoxIspis";
            this.richTextBoxIspis.Size = new System.Drawing.Size(163, 223);
            this.richTextBoxIspis.TabIndex = 8;
            this.richTextBoxIspis.Text = "";
            this.richTextBoxIspis.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 300);
            this.Controls.Add(this.richTextBoxIspis);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.textBoxCetvrti);
            this.Controls.Add(this.textBoxPeti);
            this.Controls.Add(this.textBoxSesti);
            this.Controls.Add(this.textBoxTreci);
            this.Controls.Add(this.textBoxDrugi);
            this.Controls.Add(this.textBoxPrvi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrvi;
        private System.Windows.Forms.TextBox textBoxDrugi;
        private System.Windows.Forms.TextBox textBoxTreci;
        private System.Windows.Forms.TextBox textBoxSesti;
        private System.Windows.Forms.TextBox textBoxPeti;
        private System.Windows.Forms.TextBox textBoxCetvrti;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.RichTextBox richTextBoxIspis;
    }
}

