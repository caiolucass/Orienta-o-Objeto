namespace Conta
{
    partial class Depósito
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
            this.label1_Depósito = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1_Depositar = new System.Windows.Forms.Button();
            this.label2_deposito = new System.Windows.Forms.Label();
            this.textBox2_Nconta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1_Depósito
            // 
            this.label1_Depósito.AutoSize = true;
            this.label1_Depósito.Location = new System.Drawing.Point(21, 76);
            this.label1_Depósito.Name = "label1_Depósito";
            this.label1_Depósito.Size = new System.Drawing.Size(89, 13);
            this.label1_Depósito.TabIndex = 0;
            this.label1_Depósito.Text = "Valor do depósito";
            this.label1_Depósito.Click += new System.EventHandler(this.label1_Depósito_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1_Depositar
            // 
            this.button1_Depositar.Location = new System.Drawing.Point(101, 227);
            this.button1_Depositar.Name = "button1_Depositar";
            this.button1_Depositar.Size = new System.Drawing.Size(75, 23);
            this.button1_Depositar.TabIndex = 2;
            this.button1_Depositar.Text = "Depositar";
            this.button1_Depositar.UseVisualStyleBackColor = true;
            this.button1_Depositar.Click += new System.EventHandler(this.button1_Depositar_Click);
            // 
            // label2_deposito
            // 
            this.label2_deposito.AutoSize = true;
            this.label2_deposito.Location = new System.Drawing.Point(21, 149);
            this.label2_deposito.Name = "label2_deposito";
            this.label2_deposito.Size = new System.Drawing.Size(89, 13);
            this.label2_deposito.TabIndex = 3;
            this.label2_deposito.Text = "Número da conta";
            this.label2_deposito.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2_Nconta
            // 
            this.textBox2_Nconta.Location = new System.Drawing.Point(157, 149);
            this.textBox2_Nconta.Name = "textBox2_Nconta";
            this.textBox2_Nconta.Size = new System.Drawing.Size(100, 20);
            this.textBox2_Nconta.TabIndex = 4;
            this.textBox2_Nconta.TextChanged += new System.EventHandler(this.textBox2_Nconta_TextChanged);
            // 
            // Depósito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox2_Nconta);
            this.Controls.Add(this.label2_deposito);
            this.Controls.Add(this.button1_Depositar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1_Depósito);
            this.Name = "Depósito";
            this.Text = "Depósito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Depósito;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_Depositar;
        private System.Windows.Forms.Label label2_deposito;
        private System.Windows.Forms.TextBox textBox2_Nconta;
    }
}