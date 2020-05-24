namespace Conta
{
    partial class Extrato
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_Extrato = new System.Windows.Forms.TextBox();
            this.button1_Extrato = new System.Windows.Forms.Button();
            this.listBox1_Extrato = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da conta:";
            // 
            // textBox1_Extrato
            // 
            this.textBox1_Extrato.Location = new System.Drawing.Point(172, 27);
            this.textBox1_Extrato.Name = "textBox1_Extrato";
            this.textBox1_Extrato.Size = new System.Drawing.Size(100, 20);
            this.textBox1_Extrato.TabIndex = 1;
            // 
            // button1_Extrato
            // 
            this.button1_Extrato.Location = new System.Drawing.Point(92, 215);
            this.button1_Extrato.Name = "button1_Extrato";
            this.button1_Extrato.Size = new System.Drawing.Size(75, 23);
            this.button1_Extrato.TabIndex = 2;
            this.button1_Extrato.Text = "Extrato";
            this.button1_Extrato.UseVisualStyleBackColor = true;
            this.button1_Extrato.Click += new System.EventHandler(this.button1_Extrato_Click);
            // 
            // listBox1_Extrato
            // 
            this.listBox1_Extrato.FormattingEnabled = true;
            this.listBox1_Extrato.Location = new System.Drawing.Point(72, 86);
            this.listBox1_Extrato.Name = "listBox1_Extrato";
            this.listBox1_Extrato.Size = new System.Drawing.Size(120, 95);
            this.listBox1_Extrato.TabIndex = 3;
            this.listBox1_Extrato.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Extrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBox1_Extrato);
            this.Controls.Add(this.button1_Extrato);
            this.Controls.Add(this.textBox1_Extrato);
            this.Controls.Add(this.label1);
            this.Name = "Extrato";
            this.Text = "Extrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_Extrato;
        private System.Windows.Forms.Button button1_Extrato;
        private System.Windows.Forms.ListBox listBox1_Extrato;
    }
}