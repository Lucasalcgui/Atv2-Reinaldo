namespace Atv2_Reinaldo
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
            this.btSimularMedia = new System.Windows.Forms.Button();
            this.btNotaMinima = new System.Windows.Forms.Button();
            this.btPosExame = new System.Windows.Forms.Button();
            this.btCalculadora = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSimularMedia
            // 
            this.btSimularMedia.BackColor = System.Drawing.Color.SeaGreen;
            this.btSimularMedia.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimularMedia.Location = new System.Drawing.Point(95, 161);
            this.btSimularMedia.Name = "btSimularMedia";
            this.btSimularMedia.Size = new System.Drawing.Size(341, 60);
            this.btSimularMedia.TabIndex = 0;
            this.btSimularMedia.Text = "Simular Média";
            this.btSimularMedia.UseVisualStyleBackColor = false;
            this.btSimularMedia.Click += new System.EventHandler(this.btSimularMedia_Click);
            // 
            // btNotaMinima
            // 
            this.btNotaMinima.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btNotaMinima.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNotaMinima.Location = new System.Drawing.Point(95, 227);
            this.btNotaMinima.Name = "btNotaMinima";
            this.btNotaMinima.Size = new System.Drawing.Size(341, 60);
            this.btNotaMinima.TabIndex = 1;
            this.btNotaMinima.Text = "Nota Mínima Exame";
            this.btNotaMinima.UseVisualStyleBackColor = false;
            this.btNotaMinima.Click += new System.EventHandler(this.btNotaMinima_Click_1);
            // 
            // btPosExame
            // 
            this.btPosExame.BackColor = System.Drawing.Color.SpringGreen;
            this.btPosExame.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPosExame.Location = new System.Drawing.Point(95, 293);
            this.btPosExame.Name = "btPosExame";
            this.btPosExame.Size = new System.Drawing.Size(341, 60);
            this.btPosExame.TabIndex = 2;
            this.btPosExame.Text = "Media Final Após Exame";
            this.btPosExame.UseVisualStyleBackColor = false;
            this.btPosExame.Click += new System.EventHandler(this.btPosExame_Click_1);
            // 
            // btCalculadora
            // 
            this.btCalculadora.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btCalculadora.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculadora.Location = new System.Drawing.Point(95, 359);
            this.btCalculadora.Name = "btCalculadora";
            this.btCalculadora.Size = new System.Drawing.Size(341, 60);
            this.btCalculadora.TabIndex = 3;
            this.btCalculadora.Text = "Calculadora de Juros";
            this.btCalculadora.UseVisualStyleBackColor = false;
            this.btCalculadora.Click += new System.EventHandler(this.btCalculadora_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 81);
            this.label1.TabIndex = 4;
            this.label1.Text = "Feito por:\r\nEnrique Santos Santos\r\nLucas Alcantara Guimarães\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(539, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCalculadora);
            this.Controls.Add(this.btPosExame);
            this.Controls.Add(this.btNotaMinima);
            this.Controls.Add(this.btSimularMedia);
            this.Name = "Form1";
            this.Text = "Atividade 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSimularMedia;
        private System.Windows.Forms.Button btNotaMinima;
        private System.Windows.Forms.Button btPosExame;
        private System.Windows.Forms.Button btCalculadora;
        private System.Windows.Forms.Label label1;
    }
}

