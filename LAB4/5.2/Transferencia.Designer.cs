namespace _5._2
{
    partial class Transferencia
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
            this.label1_sacar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2_valor = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3_receber = new System.Windows.Forms.TextBox();
            this.button1_transferir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_sacar
            // 
            this.label1_sacar.AutoSize = true;
            this.label1_sacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_sacar.Location = new System.Drawing.Point(4, 112);
            this.label1_sacar.Name = "label1_sacar";
            this.label1_sacar.Size = new System.Drawing.Size(125, 13);
            this.label1_sacar.TabIndex = 0;
            this.label1_sacar.Text = "N° da conta a sacar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2_valor
            // 
            this.label2_valor.AutoSize = true;
            this.label2_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_valor.Location = new System.Drawing.Point(12, 148);
            this.label2_valor.Name = "label2_valor";
            this.label2_valor.Size = new System.Drawing.Size(87, 13);
            this.label2_valor.TabIndex = 2;
            this.label2_valor.Text = "Digite o valor:";
            this.label2_valor.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° da conta a receber:";
            // 
            // textBox3_receber
            // 
            this.textBox3_receber.Location = new System.Drawing.Point(147, 184);
            this.textBox3_receber.Name = "textBox3_receber";
            this.textBox3_receber.Size = new System.Drawing.Size(100, 20);
            this.textBox3_receber.TabIndex = 5;
            // 
            // button1_transferir
            // 
            this.button1_transferir.BackColor = System.Drawing.SystemColors.Control;
            this.button1_transferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_transferir.Location = new System.Drawing.Point(101, 231);
            this.button1_transferir.Name = "button1_transferir";
            this.button1_transferir.Size = new System.Drawing.Size(75, 23);
            this.button1_transferir.TabIndex = 6;
            this.button1_transferir.Text = "Transferir";
            this.button1_transferir.UseVisualStyleBackColor = false;
            this.button1_transferir.Click += new System.EventHandler(this.Button1_transferir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Transferência";
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(296, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_transferir);
            this.Controls.Add(this.textBox3_receber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2_valor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1_sacar);
            this.Name = "Transferencia";
            this.Text = "Transferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_sacar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2_valor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3_receber;
        private System.Windows.Forms.Button button1_transferir;
        private System.Windows.Forms.Label label1;
    }
}