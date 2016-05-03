namespace WinAPP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioAtual = new System.Windows.Forms.TextBox();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnCalcularAumento = new System.Windows.Forms.Button();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario Atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aumento";
            // 
            // txtSalarioAtual
            // 
            this.txtSalarioAtual.Location = new System.Drawing.Point(98, 29);
            this.txtSalarioAtual.Name = "txtSalarioAtual";
            this.txtSalarioAtual.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioAtual.TabIndex = 2;
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(98, 58);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(100, 20);
            this.txtAumento.TabIndex = 3;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(26, 116);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(10, 13);
            this.lblResposta.TabIndex = 4;
            this.lblResposta.Text = "-";
            // 
            // btnCalcularAumento
            // 
            this.btnCalcularAumento.Location = new System.Drawing.Point(180, 96);
            this.btnCalcularAumento.Name = "btnCalcularAumento";
            this.btnCalcularAumento.Size = new System.Drawing.Size(92, 38);
            this.btnCalcularAumento.TabIndex = 5;
            this.btnCalcularAumento.Text = "Calcular";
            this.btnCalcularAumento.UseVisualStyleBackColor = true;
            this.btnCalcularAumento.Click += new System.EventHandler(this.btnCalcularAumento_Click);
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Location = new System.Drawing.Point(26, 143);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(10, 13);
            this.lblResultado2.TabIndex = 6;
            this.lblResultado2.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.btnCalcularAumento);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtAumento);
            this.Controls.Add(this.txtSalarioAtual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcular Novo Salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioAtual;
        private System.Windows.Forms.TextBox txtAumento;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnCalcularAumento;
        private System.Windows.Forms.Label lblResultado2;
    }
}

