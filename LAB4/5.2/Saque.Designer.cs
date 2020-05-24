namespace _5._2
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
            this.button1_saque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_saque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_conta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1_saque
            // 
            this.button1_saque.BackColor = System.Drawing.SystemColors.Control;
            this.button1_saque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_saque.Location = new System.Drawing.Point(96, 200);
            this.button1_saque.Name = "button1_saque";
            this.button1_saque.Size = new System.Drawing.Size(103, 23);
            this.button1_saque.TabIndex = 0;
            this.button1_saque.Text = "Finalizar Saque";
            this.button1_saque.UseVisualStyleBackColor = false;
            this.button1_saque.Click += new System.EventHandler(this.Button1_saque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o valor:";
            // 
            // textBox1_saque
            // 
            this.textBox1_saque.Location = new System.Drawing.Point(151, 152);
            this.textBox1_saque.Name = "textBox1_saque";
            this.textBox1_saque.Size = new System.Drawing.Size(100, 20);
            this.textBox1_saque.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° da conta:";
            // 
            // textBox1_conta
            // 
            this.textBox1_conta.Location = new System.Drawing.Point(151, 110);
            this.textBox1_conta.Name = "textBox1_conta";
            this.textBox1_conta.Size = new System.Drawing.Size(100, 20);
            this.textBox1_conta.TabIndex = 5;
            // 
            // Saque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(303, 249);
            this.Controls.Add(this.textBox1_conta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_saque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_saque);
            this.Name = "Saque";
            this.Text = "Saque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_saque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_saque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_conta;
    }
}