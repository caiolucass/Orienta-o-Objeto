namespace Conta
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
            this.button_Depositar = new System.Windows.Forms.Button();
            this.button_Saque = new System.Windows.Forms.Button();
            this.button_Extrato = new System.Windows.Forms.Button();
            this.button_Transferência = new System.Windows.Forms.Button();
            this.button_Saldo = new System.Windows.Forms.Button();
            this.button_Excluir = new System.Windows.Forms.Button();
            this.button_Criar = new System.Windows.Forms.Button();
            this.label_CaixaEletronico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Depositar
            // 
            this.button_Depositar.Location = new System.Drawing.Point(3, 139);
            this.button_Depositar.Name = "button_Depositar";
            this.button_Depositar.Size = new System.Drawing.Size(75, 23);
            this.button_Depositar.TabIndex = 0;
            this.button_Depositar.Text = "Depósito";
            this.button_Depositar.UseVisualStyleBackColor = true;
            this.button_Depositar.Click += new System.EventHandler(this.button_Depositar_Click);
            // 
            // button_Saque
            // 
            this.button_Saque.Location = new System.Drawing.Point(97, 139);
            this.button_Saque.Name = "button_Saque";
            this.button_Saque.Size = new System.Drawing.Size(75, 23);
            this.button_Saque.TabIndex = 1;
            this.button_Saque.Text = "Saque";
            this.button_Saque.UseVisualStyleBackColor = true;
            this.button_Saque.Click += new System.EventHandler(this.button_Saque_Click);
            // 
            // button_Extrato
            // 
            this.button_Extrato.Location = new System.Drawing.Point(197, 139);
            this.button_Extrato.Name = "button_Extrato";
            this.button_Extrato.Size = new System.Drawing.Size(75, 23);
            this.button_Extrato.TabIndex = 2;
            this.button_Extrato.Text = "Extrato";
            this.button_Extrato.UseVisualStyleBackColor = true;
            this.button_Extrato.Click += new System.EventHandler(this.button_Extrato_Click);
            // 
            // button_Transferência
            // 
            this.button_Transferência.Location = new System.Drawing.Point(3, 188);
            this.button_Transferência.Name = "button_Transferência";
            this.button_Transferência.Size = new System.Drawing.Size(87, 23);
            this.button_Transferência.TabIndex = 3;
            this.button_Transferência.Text = "Transferência";
            this.button_Transferência.UseVisualStyleBackColor = true;
            this.button_Transferência.Click += new System.EventHandler(this.button_Transferência_Click);
            // 
            // button_Saldo
            // 
            this.button_Saldo.Location = new System.Drawing.Point(97, 188);
            this.button_Saldo.Name = "button_Saldo";
            this.button_Saldo.Size = new System.Drawing.Size(75, 23);
            this.button_Saldo.TabIndex = 4;
            this.button_Saldo.Text = "Saldo";
            this.button_Saldo.UseVisualStyleBackColor = true;
            this.button_Saldo.Click += new System.EventHandler(this.button_Saldo_Click);
            // 
            // button_Excluir
            // 
            this.button_Excluir.Location = new System.Drawing.Point(197, 188);
            this.button_Excluir.Name = "button_Excluir";
            this.button_Excluir.Size = new System.Drawing.Size(75, 23);
            this.button_Excluir.TabIndex = 5;
            this.button_Excluir.Text = "Excluir";
            this.button_Excluir.UseVisualStyleBackColor = true;
            this.button_Excluir.Click += new System.EventHandler(this.button_Excluir_Click);
            // 
            // button_Criar
            // 
            this.button_Criar.Location = new System.Drawing.Point(97, 227);
            this.button_Criar.Name = "button_Criar";
            this.button_Criar.Size = new System.Drawing.Size(75, 23);
            this.button_Criar.TabIndex = 6;
            this.button_Criar.Text = "Criar";
            this.button_Criar.UseVisualStyleBackColor = true;
            this.button_Criar.Click += new System.EventHandler(this.button_Criar_Click);
            // 
            // label_CaixaEletronico
            // 
            this.label_CaixaEletronico.AutoSize = true;
            this.label_CaixaEletronico.Location = new System.Drawing.Point(94, 57);
            this.label_CaixaEletronico.Name = "label_CaixaEletronico";
            this.label_CaixaEletronico.Size = new System.Drawing.Size(83, 13);
            this.label_CaixaEletronico.TabIndex = 7;
            this.label_CaixaEletronico.Text = "Caixa Eletrônico";
            this.label_CaixaEletronico.Click += new System.EventHandler(this.label_CaixaEletronico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label_CaixaEletronico);
            this.Controls.Add(this.button_Criar);
            this.Controls.Add(this.button_Excluir);
            this.Controls.Add(this.button_Saldo);
            this.Controls.Add(this.button_Transferência);
            this.Controls.Add(this.button_Extrato);
            this.Controls.Add(this.button_Saque);
            this.Controls.Add(this.button_Depositar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Depositar;
        private System.Windows.Forms.Button button_Saque;
        private System.Windows.Forms.Button button_Extrato;
        private System.Windows.Forms.Button button_Transferência;
        private System.Windows.Forms.Button button_Saldo;
        private System.Windows.Forms.Button button_Excluir;
        private System.Windows.Forms.Button button_Criar;
        private System.Windows.Forms.Label label_CaixaEletronico;
    }
}

