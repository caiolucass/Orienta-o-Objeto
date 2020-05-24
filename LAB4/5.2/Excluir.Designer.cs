namespace _5._2
{
    partial class Excluir
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
            this.textBox1_conta = new System.Windows.Forms.TextBox();
            this.button1_excluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° da conta:";
            // 
            // textBox1_conta
            // 
            this.textBox1_conta.Location = new System.Drawing.Point(119, 140);
            this.textBox1_conta.Name = "textBox1_conta";
            this.textBox1_conta.Size = new System.Drawing.Size(100, 20);
            this.textBox1_conta.TabIndex = 1;
            // 
            // button1_excluir
            // 
            this.button1_excluir.BackColor = System.Drawing.SystemColors.Control;
            this.button1_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_excluir.Location = new System.Drawing.Point(86, 215);
            this.button1_excluir.Name = "button1_excluir";
            this.button1_excluir.Size = new System.Drawing.Size(75, 23);
            this.button1_excluir.TabIndex = 2;
            this.button1_excluir.Text = "Excluir";
            this.button1_excluir.UseVisualStyleBackColor = false;
            this.button1_excluir.Click += new System.EventHandler(this.Button1_excluirClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Excluir";
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(253, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1_excluir);
            this.Controls.Add(this.textBox1_conta);
            this.Controls.Add(this.label1);
            this.Name = "Excluir";
            this.Text = "Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_conta;
        private System.Windows.Forms.Button button1_excluir;
        private System.Windows.Forms.Label label2;
    }
}