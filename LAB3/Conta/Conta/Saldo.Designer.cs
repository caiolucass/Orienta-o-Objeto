﻿namespace Conta
{
    partial class Saldo
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
            this.label1_saldo = new System.Windows.Forms.Label();
            this.textBox1_saldo = new System.Windows.Forms.TextBox();
            this.button1_saldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_saldo
            // 
            this.label1_saldo.AutoSize = true;
            this.label1_saldo.Location = new System.Drawing.Point(12, 121);
            this.label1_saldo.Name = "label1_saldo";
            this.label1_saldo.Size = new System.Drawing.Size(89, 13);
            this.label1_saldo.TabIndex = 0;
            this.label1_saldo.Text = "Número da conta";
            // 
            // textBox1_saldo
            // 
            this.textBox1_saldo.Location = new System.Drawing.Point(178, 118);
            this.textBox1_saldo.Name = "textBox1_saldo";
            this.textBox1_saldo.Size = new System.Drawing.Size(100, 20);
            this.textBox1_saldo.TabIndex = 1;
            // 
            // button1_saldo
            // 
            this.button1_saldo.Location = new System.Drawing.Point(101, 274);
            this.button1_saldo.Name = "button1_saldo";
            this.button1_saldo.Size = new System.Drawing.Size(75, 23);
            this.button1_saldo.TabIndex = 2;
            this.button1_saldo.Text = "Saldo";
            this.button1_saldo.UseVisualStyleBackColor = true;
            this.button1_saldo.Click += new System.EventHandler(this.button1_saldo_Click);
            // 
            // Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 332);
            this.Controls.Add(this.button1_saldo);
            this.Controls.Add(this.textBox1_saldo);
            this.Controls.Add(this.label1_saldo);
            this.Name = "Saldo";
            this.Text = "Saldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_saldo;
        private System.Windows.Forms.TextBox textBox1_saldo;
        private System.Windows.Forms.Button button1_saldo;
    }
}