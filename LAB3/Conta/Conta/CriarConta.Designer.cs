namespace Conta
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
            this.label1_Criar = new System.Windows.Forms.Label();
            this.textBox1_Criar = new System.Windows.Forms.TextBox();
            this.button1_Criar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_Criar
            // 
            this.label1_Criar.AutoSize = true;
            this.label1_Criar.Location = new System.Drawing.Point(12, 125);
            this.label1_Criar.Name = "label1_Criar";
            this.label1_Criar.Size = new System.Drawing.Size(78, 13);
            this.label1_Criar.TabIndex = 0;
            this.label1_Criar.Text = "Nome do titular";
            this.label1_Criar.Click += new System.EventHandler(this.label1_Criar_Click);
            // 
            // textBox1_Criar
            // 
            this.textBox1_Criar.Location = new System.Drawing.Point(159, 125);
            this.textBox1_Criar.Name = "textBox1_Criar";
            this.textBox1_Criar.Size = new System.Drawing.Size(100, 20);
            this.textBox1_Criar.TabIndex = 1;
            this.textBox1_Criar.TextChanged += new System.EventHandler(this.textBox1_Criar_TextChanged);
            // 
            // button1_Criar
            // 
            this.button1_Criar.Location = new System.Drawing.Point(101, 199);
            this.button1_Criar.Name = "button1_Criar";
            this.button1_Criar.Size = new System.Drawing.Size(75, 23);
            this.button1_Criar.TabIndex = 2;
            this.button1_Criar.Text = "Criar Conta";
            this.button1_Criar.UseVisualStyleBackColor = true;
            this.button1_Criar.Click += new System.EventHandler(this.button1_Criar_Click);
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1_Criar);
            this.Controls.Add(this.textBox1_Criar);
            this.Controls.Add(this.label1_Criar);
            this.Name = "CriarConta";
            this.Text = "CriarConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Criar;
        private System.Windows.Forms.TextBox textBox1_Criar;
        private System.Windows.Forms.Button button1_Criar;
    }
}