namespace Conta
{
    partial class Transferência
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
            this.label1_transferir = new System.Windows.Forms.Label();
            this.label2_Nconta = new System.Windows.Forms.Label();
            this.button1_transferir = new System.Windows.Forms.Button();
            this.textBox1_transferir = new System.Windows.Forms.TextBox();
            this.textBox2_transferir = new System.Windows.Forms.TextBox();
            this.label1_Ncontareceber = new System.Windows.Forms.Label();
            this.textBox1_NcontaReceber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1_transferir
            // 
            this.label1_transferir.AutoSize = true;
            this.label1_transferir.Location = new System.Drawing.Point(19, 106);
            this.label1_transferir.Name = "label1_transferir";
            this.label1_transferir.Size = new System.Drawing.Size(83, 13);
            this.label1_transferir.TabIndex = 0;
            this.label1_transferir.Text = "Valor à transferir";
            // 
            // label2_Nconta
            // 
            this.label2_Nconta.AutoSize = true;
            this.label2_Nconta.Location = new System.Drawing.Point(19, 56);
            this.label2_Nconta.Name = "label2_Nconta";
            this.label2_Nconta.Size = new System.Drawing.Size(90, 13);
            this.label2_Nconta.TabIndex = 1;
            this.label2_Nconta.Text = "Número da Conta";
            // 
            // button1_transferir
            // 
            this.button1_transferir.Location = new System.Drawing.Point(98, 227);
            this.button1_transferir.Name = "button1_transferir";
            this.button1_transferir.Size = new System.Drawing.Size(75, 23);
            this.button1_transferir.TabIndex = 2;
            this.button1_transferir.Text = "Transferir";
            this.button1_transferir.UseVisualStyleBackColor = true;
            this.button1_transferir.Click += new System.EventHandler(this.button1_transferir_Click);
            // 
            // textBox1_transferir
            // 
            this.textBox1_transferir.Location = new System.Drawing.Point(155, 106);
            this.textBox1_transferir.Name = "textBox1_transferir";
            this.textBox1_transferir.Size = new System.Drawing.Size(100, 20);
            this.textBox1_transferir.TabIndex = 3;
            this.textBox1_transferir.TextChanged += new System.EventHandler(this.textBox1_transferir_TextChanged);
            // 
            // textBox2_transferir
            // 
            this.textBox2_transferir.Location = new System.Drawing.Point(155, 53);
            this.textBox2_transferir.Name = "textBox2_transferir";
            this.textBox2_transferir.Size = new System.Drawing.Size(100, 20);
            this.textBox2_transferir.TabIndex = 4;
            // 
            // label1_Ncontareceber
            // 
            this.label1_Ncontareceber.AutoSize = true;
            this.label1_Ncontareceber.Location = new System.Drawing.Point(12, 170);
            this.label1_Ncontareceber.Name = "label1_Ncontareceber";
            this.label1_Ncontareceber.Size = new System.Drawing.Size(137, 13);
            this.label1_Ncontareceber.TabIndex = 5;
            this.label1_Ncontareceber.Text = "Número da conta à receber";
            // 
            // textBox1_NcontaReceber
            // 
            this.textBox1_NcontaReceber.Location = new System.Drawing.Point(155, 167);
            this.textBox1_NcontaReceber.Name = "textBox1_NcontaReceber";
            this.textBox1_NcontaReceber.Size = new System.Drawing.Size(100, 20);
            this.textBox1_NcontaReceber.TabIndex = 6;
            // 
            // Transferência
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1_NcontaReceber);
            this.Controls.Add(this.label1_Ncontareceber);
            this.Controls.Add(this.textBox2_transferir);
            this.Controls.Add(this.textBox1_transferir);
            this.Controls.Add(this.button1_transferir);
            this.Controls.Add(this.label2_Nconta);
            this.Controls.Add(this.label1_transferir);
            this.Name = "Transferência";
            this.Text = "Transferência";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_transferir;
        private System.Windows.Forms.Label label2_Nconta;
        private System.Windows.Forms.Button button1_transferir;
        private System.Windows.Forms.TextBox textBox1_transferir;
        private System.Windows.Forms.TextBox textBox2_transferir;
        private System.Windows.Forms.Label label1_Ncontareceber;
        private System.Windows.Forms.TextBox textBox1_NcontaReceber;
    }
}