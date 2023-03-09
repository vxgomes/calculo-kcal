namespace calculo_kcal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.txtKcal = new System.Windows.Forms.TextBox();
            this.SelectAtividade = new System.Windows.Forms.ComboBox();
            this.numerTime = new System.Windows.Forms.NumericUpDown();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numerTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o tipo de atividade fisica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Informe seu peso em KG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quanto tempo você irá fazer o exercicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "O valor KCAL gasto é de: ";
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(343, 120);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(72, 22);
            this.txtKg.TabIndex = 1;
            // 
            // txtKcal
            // 
            this.txtKcal.Location = new System.Drawing.Point(343, 246);
            this.txtKcal.Name = "txtKcal";
            this.txtKcal.Size = new System.Drawing.Size(130, 22);
            this.txtKcal.TabIndex = 1;
            // 
            // SelectAtividade
            // 
            this.SelectAtividade.FormattingEnabled = true;
            this.SelectAtividade.Location = new System.Drawing.Point(436, 67);
            this.SelectAtividade.Name = "SelectAtividade";
            this.SelectAtividade.Size = new System.Drawing.Size(162, 24);
            this.SelectAtividade.TabIndex = 2;
            // 
            // numerTime
            // 
            this.numerTime.Location = new System.Drawing.Point(479, 181);
            this.numerTime.Name = "numerTime";
            this.numerTime.Size = new System.Drawing.Size(82, 22);
            this.numerTime.TabIndex = 3;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(112, 356);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(319, 356);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 4;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(523, 356);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = "SAIR";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.numerTime);
            this.Controls.Add(this.SelectAtividade);
            this.Controls.Add(this.txtKcal);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numerTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.TextBox txtKcal;
        private System.Windows.Forms.ComboBox SelectAtividade;
        private System.Windows.Forms.NumericUpDown numerTime;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSair;
    }
}

