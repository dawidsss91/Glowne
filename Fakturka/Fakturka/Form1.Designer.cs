namespace Fakturka
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
            this.Zapisz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nazwaSprzedawcy_tb = new System.Windows.Forms.TextBox();
            this.nowaFaktura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(475, 316);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(112, 32);
            this.Zapisz.TabIndex = 0;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
         //   this.Zapisz.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa sprzedawcy";
            // 
            // nazwaSprzedawcy_tb
            // 
            this.nazwaSprzedawcy_tb.Location = new System.Drawing.Point(119, 13);
            this.nazwaSprzedawcy_tb.Name = "nazwaSprzedawcy_tb";
            this.nazwaSprzedawcy_tb.Size = new System.Drawing.Size(100, 20);
            this.nazwaSprzedawcy_tb.TabIndex = 6;
            // 
            // nowaFaktura
            // 
            this.nowaFaktura.Location = new System.Drawing.Point(368, 324);
            this.nowaFaktura.Name = "nowaFaktura";
            this.nowaFaktura.Size = new System.Drawing.Size(75, 23);
            this.nowaFaktura.TabIndex = 11;
            this.nowaFaktura.Text = "NowaFaktura";
            this.nowaFaktura.UseVisualStyleBackColor = true;
           // this.nowaFaktura.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 360);
            this.Controls.Add(this.nowaFaktura);
            this.Controls.Add(this.nazwaSprzedawcy_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zapisz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazwaSprzedawcy_tb;
        private System.Windows.Forms.Button nowaFaktura;
    }
}

