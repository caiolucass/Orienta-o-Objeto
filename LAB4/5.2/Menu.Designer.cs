namespace _5._2
{
    partial class Menu
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
            this.button1_cadastro = new System.Windows.Forms.Button();
            this.button2_deposito = new System.Windows.Forms.Button();
            this.button3_saque = new System.Windows.Forms.Button();
            this.button4_transferencia = new System.Windows.Forms.Button();
            this.button1_saldo = new System.Windows.Forms.Button();
            this.button1_excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_extrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_cadastro
            // 
            this.button1_cadastro.BackColor = System.Drawing.SystemColors.Control;
            this.button1_cadastro.Location = new System.Drawing.Point(12, 132);
            this.button1_cadastro.Name = "button1_cadastro";
            this.button1_cadastro.Size = new System.Drawing.Size(75, 23);
            this.button1_cadastro.TabIndex = 0;
            this.button1_cadastro.Text = "Cadastrar";
            this.button1_cadastro.UseVisualStyleBackColor = false;
            this.button1_cadastro.Click += new System.EventHandler(this.Button1_cadastro_Click);
            // 
            // button2_deposito
            // 
            this.button2_deposito.BackColor = System.Drawing.SystemColors.Control;
            this.button2_deposito.Location = new System.Drawing.Point(120, 132);
            this.button2_deposito.Name = "button2_deposito";
            this.button2_deposito.Size = new System.Drawing.Size(75, 23);
            this.button2_deposito.TabIndex = 1;
            this.button2_deposito.Text = "Depositar";
            this.button2_deposito.UseVisualStyleBackColor = false;
            this.button2_deposito.Click += new System.EventHandler(this.Button2_deposito_Click);
            // 
            // button3_saque
            // 
            this.button3_saque.BackColor = System.Drawing.SystemColors.Control;
            this.button3_saque.Location = new System.Drawing.Point(231, 132);
            this.button3_saque.Name = "button3_saque";
            this.button3_saque.Size = new System.Drawing.Size(75, 23);
            this.button3_saque.TabIndex = 2;
            this.button3_saque.Text = "Sacar";
            this.button3_saque.UseVisualStyleBackColor = false;
            this.button3_saque.Click += new System.EventHandler(this.Button3_saque_Click);
            // 
            // button4_transferencia
            // 
            this.button4_transferencia.BackColor = System.Drawing.SystemColors.Control;
            this.button4_transferencia.Location = new System.Drawing.Point(12, 200);
            this.button4_transferencia.Name = "button4_transferencia";
            this.button4_transferencia.Size = new System.Drawing.Size(75, 23);
            this.button4_transferencia.TabIndex = 3;
            this.button4_transferencia.Text = "Transferir";
            this.button4_transferencia.UseVisualStyleBackColor = false;
            this.button4_transferencia.Click += new System.EventHandler(this.Button4_transferencia_Click);
            // 
            // button1_saldo
            // 
            this.button1_saldo.BackColor = System.Drawing.SystemColors.Control;
            this.button1_saldo.Location = new System.Drawing.Point(120, 173);
            this.button1_saldo.Name = "button1_saldo";
            this.button1_saldo.Size = new System.Drawing.Size(75, 23);
            this.button1_saldo.TabIndex = 4;
            this.button1_saldo.Text = "Saldo";
            this.button1_saldo.UseVisualStyleBackColor = false;
            this.button1_saldo.Click += new System.EventHandler(this.Button1_saldo_Click);
            // 
            // button1_excluir
            // 
            this.button1_excluir.BackColor = System.Drawing.SystemColors.Control;
            this.button1_excluir.Location = new System.Drawing.Point(231, 200);
            this.button1_excluir.Name = "button1_excluir";
            this.button1_excluir.Size = new System.Drawing.Size(75, 23);
            this.button1_excluir.TabIndex = 5;
            this.button1_excluir.Text = "Excluir";
            this.button1_excluir.UseVisualStyleBackColor = false;
            this.button1_excluir.Click += new System.EventHandler(this.Button1_excluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Caixa Eletrônico";
            // 
            // button1_extrato
            // 
            this.button1_extrato.BackColor = System.Drawing.SystemColors.Control;
            this.button1_extrato.Location = new System.Drawing.Point(120, 220);
            this.button1_extrato.Name = "button1_extrato";
            this.button1_extrato.Size = new System.Drawing.Size(75, 23);
            this.button1_extrato.TabIndex = 7;
            this.button1_extrato.Text = "Extrato";
            this.button1_extrato.UseVisualStyleBackColor = false;
            this.button1_extrato.Click += new System.EventHandler(this.Button1_extrato_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(318, 255);
            this.Controls.Add(this.button1_extrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_excluir);
            this.Controls.Add(this.button1_saldo);
            this.Controls.Add(this.button4_transferencia);
            this.Controls.Add(this.button3_saque);
            this.Controls.Add(this.button2_deposito);
            this.Controls.Add(this.button1_cadastro);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_cadastro;
        private System.Windows.Forms.Button button2_deposito;
        private System.Windows.Forms.Button button3_saque;
        private System.Windows.Forms.Button button4_transferencia;
        private System.Windows.Forms.Button button1_saldo;
        private System.Windows.Forms.Button button1_excluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_extrato;
    }
}