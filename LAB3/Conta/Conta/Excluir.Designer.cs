namespace Conta
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
            this.label1_excluir = new System.Windows.Forms.Label();
            this.textBox1_excluir = new System.Windows.Forms.TextBox();
            this.button1_excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_excluir
            // 
            this.label1_excluir.AutoSize = true;
            this.label1_excluir.Location = new System.Drawing.Point(29, 123);
            this.label1_excluir.Name = "label1_excluir";
            this.label1_excluir.Size = new System.Drawing.Size(89, 13);
            this.label1_excluir.TabIndex = 0;
            this.label1_excluir.Text = "Número da conta";
            // 
            // textBox1_excluir
            // 
            this.textBox1_excluir.Location = new System.Drawing.Point(161, 123);
            this.textBox1_excluir.Name = "textBox1_excluir";
            this.textBox1_excluir.Size = new System.Drawing.Size(100, 20);
            this.textBox1_excluir.TabIndex = 1;
            // 
            // button1_excluir
            // 
            this.button1_excluir.Location = new System.Drawing.Point(101, 224);
            this.button1_excluir.Name = "button1_excluir";
            this.button1_excluir.Size = new System.Drawing.Size(75, 23);
            this.button1_excluir.TabIndex = 2;
            this.button1_excluir.Text = "Excluir";
            this.button1_excluir.UseVisualStyleBackColor = true;
            this.button1_excluir.Click += new System.EventHandler(this.button1_excluir_Click);
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 312);
            this.Controls.Add(this.button1_excluir);
            this.Controls.Add(this.textBox1_excluir);
            this.Controls.Add(this.label1_excluir);
            this.Name = "Excluir";
            this.Text = "Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_excluir;
        private System.Windows.Forms.TextBox textBox1_excluir;
        private System.Windows.Forms.Button button1_excluir;
    }
}