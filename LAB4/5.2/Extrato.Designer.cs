namespace _5._2
{
    partial class Extrato
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
            this.button1_extrato = new System.Windows.Forms.Button();
            this.listBox1_extrato = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_conta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_extrato
            // 
            this.button1_extrato.BackColor = System.Drawing.SystemColors.Control;
            this.button1_extrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_extrato.Location = new System.Drawing.Point(89, 231);
            this.button1_extrato.Name = "button1_extrato";
            this.button1_extrato.Size = new System.Drawing.Size(75, 23);
            this.button1_extrato.TabIndex = 0;
            this.button1_extrato.Text = "Extrato";
            this.button1_extrato.UseVisualStyleBackColor = false;
            this.button1_extrato.Click += new System.EventHandler(this.Button1_extrato_Click);
            // 
            // listBox1_extrato
            // 
            this.listBox1_extrato.FormattingEnabled = true;
            this.listBox1_extrato.Location = new System.Drawing.Point(71, 116);
            this.listBox1_extrato.Name = "listBox1_extrato";
            this.listBox1_extrato.Size = new System.Drawing.Size(120, 95);
            this.listBox1_extrato.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N° da conta:";
            // 
            // textBox1_conta
            // 
            this.textBox1_conta.Location = new System.Drawing.Point(152, 84);
            this.textBox1_conta.Name = "textBox1_conta";
            this.textBox1_conta.Size = new System.Drawing.Size(93, 20);
            this.textBox1_conta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extrato";
            // 
            // Extrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(271, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_conta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1_extrato);
            this.Controls.Add(this.button1_extrato);
            this.Name = "Extrato";
            this.Text = "Extrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_extrato;
        private System.Windows.Forms.ListBox listBox1_extrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_conta;
        private System.Windows.Forms.Label label2;
    }
}