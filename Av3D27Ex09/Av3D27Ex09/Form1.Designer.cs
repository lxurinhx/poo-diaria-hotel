namespace Av3D27Ex09
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncalc = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtdiarias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(34, 104);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(100, 23);
            this.btncalc.TabIndex = 0;
            this.btncalc.Text = "calcular preço";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(34, 39);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 1;
            // 
            // txtdiarias
            // 
            this.txtdiarias.Location = new System.Drawing.Point(34, 78);
            this.txtdiarias.Name = "txtdiarias";
            this.txtdiarias.Size = new System.Drawing.Size(100, 20);
            this.txtdiarias.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "quantidade de diárias:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "total da conta: R$";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(299, 81);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(13, 13);
            this.lblresult.TabIndex = 6;
            this.lblresult.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "nome:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(250, 42);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(0, 13);
            this.lblnome.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 162);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdiarias);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btncalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtdiarias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnome;
    }
}

