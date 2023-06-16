
namespace Calculadoraz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.LabelOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(13, 12);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(312, 23);
            this.TxtResultado.TabIndex = 0;
            this.TxtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelOperacao
            // 
            this.LabelOperacao.AutoSize = true;
            this.LabelOperacao.Location = new System.Drawing.Point(277, 15);
            this.LabelOperacao.Name = "LabelOperacao";
            this.LabelOperacao.Size = new System.Drawing.Size(0, 15);
            this.LabelOperacao.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.LabelOperacao);
            this.Controls.Add(this.TxtResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label LabelOperacao;
    }
}

