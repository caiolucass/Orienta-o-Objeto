namespace Conta
{
    partial class Saque
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
            this.label1_saque = new System.Windows.Forms.Label();
            this.label2_Nconta = new System.Windows.Forms.Label();
            this.textBox1_saque = new System.Windows.Forms.TextBox();
            this.textBox2_saque = new System.Windows.Forms.TextBox();
            this.button1_sacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_saque
            // 
            this.label1_saque.AutoSize = true;
            this.label1_saque.Location = new System.Drawing.Point(30, 76);
            this.label1_saque.Name = "label1_saque";
            this.label1_saque.Size = new System.Drawing.Size(69, 13);
            this.label1_saque.TabIndex = 0;
            this.label1_saque.Text = "Valor à sacar";
            this.label1_saque.Click += new System.EventHandler(this.label1_saque_Click);
            // 
            // label2_Nconta
            // 
            this.label2_Nconta.AutoSize = true;
            this.label2_Nconta.Location = new System.Drawing.Point(30, 148);
            this.label2_Nconta.Name = "label2_Nconta";
            this.label2_Nconta.Size = new System.Drawing.Size(90, 13);
            this.label2_Nconta.TabIndex = 1;
            this.label2_Nconta.Text = "Número da Conta";
            // 
            // textBox1_saque
            // 
            this.textBox1_saque.Location = new System.Drawing.Point(149, 73);
            this.textBox1_saque.Name = "textBox1_saque";
            this.textBox1_saque.Size = new System.Drawing.Size(100, 20);
            this.textBox1_saque.TabIndex = 2;
            this.textBox1_saque.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2_saque
            // 
            this.textBox2_saque.Location = new System.Drawing.Point(149, 145);
            this.textBox2_saque.Name = "textBox2_saque";
            this.textBox2_saque.Size = new System.Drawing.Size(100, 20);
            this.textBox2_saque.TabIndex = 3;
            // 
            // button1_sacar
            // 
            this.button1_sacar.Location = new System.Drawing.Point(104, 227);
            this.button1_sacar.Name = "button1_sacar";
            this.button1_sacar.Size = new System.Drawing.Size(75, 23);
            this.button1_sacar.TabIndex = 4;
            this.button1_sacar.Text = "Sacar";
            this.button1_sacar.UseVisualStyleBackColor = true;
            this.button1_sacar.Click += new System.EventHandler(this.button1_sacar_Click);
            // 
            // Saque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1_sacar);
            this.Controls.Add(this.textBox2_saque);
            this.Controls.Add(this.textBox1_saque);
            this.Controls.Add(this.label2_Nconta);
            this.Controls.Add(this.label1_saque);
            this.Name = "Saque";
            this.Text = "Saque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_saque;
        private System.Windows.Forms.Label label2_Nconta;
        private System.Windows.Forms.TextBox textBox1_saque;
        private System.Windows.Forms.TextBox textBox2_saque;
        private System.Windows.Forms.Button button1_sacar;
    }
}