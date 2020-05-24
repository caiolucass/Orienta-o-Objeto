namespace _5._2
{
    partial class CriarConta
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
            this.label1_cadastro = new System.Windows.Forms.Label();
            this.textBox1_cadastro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_cadastro
            // 
            this.button1_cadastro.BackColor = System.Drawing.SystemColors.Control;
            this.button1_cadastro.Location = new System.Drawing.Point(82, 200);
            this.button1_cadastro.Name = "button1_cadastro";
            this.button1_cadastro.Size = new System.Drawing.Size(117, 23);
            this.button1_cadastro.TabIndex = 0;
            this.button1_cadastro.Text = "Finalizar Cadastro";
            this.button1_cadastro.UseVisualStyleBackColor = false;
            this.button1_cadastro.Click += new System.EventHandler(this.Button1_cadastro_Click);
            // 
            // label1_cadastro
            // 
            this.label1_cadastro.AutoSize = true;
            this.label1_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_cadastro.Location = new System.Drawing.Point(23, 133);
            this.label1_cadastro.Name = "label1_cadastro";
            this.label1_cadastro.Size = new System.Drawing.Size(102, 13);
            this.label1_cadastro.TabIndex = 1;
            this.label1_cadastro.Text = "Cadastrar Conta:";
            // 
            // textBox1_cadastro
            // 
            this.textBox1_cadastro.Location = new System.Drawing.Point(155, 130);
            this.textBox1_cadastro.Name = "textBox1_cadastro";
            this.textBox1_cadastro.Size = new System.Drawing.Size(100, 20);
            this.textBox1_cadastro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Novo Cliente";
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(287, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_cadastro);
            this.Controls.Add(this.label1_cadastro);
            this.Controls.Add(this.button1_cadastro);
            this.Name = "CriarConta";
            this.Text = "CriarConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_cadastro;
        private System.Windows.Forms.Label label1_cadastro;
        private System.Windows.Forms.TextBox textBox1_cadastro;
        private System.Windows.Forms.Label label1;
    }
}