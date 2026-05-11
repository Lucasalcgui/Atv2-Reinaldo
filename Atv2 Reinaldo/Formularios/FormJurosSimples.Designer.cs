namespace AppAtividade2.Formularios
{
    partial class FormJurosSimples
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
            this.components = new System.ComponentModel.Container();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCapital = new System.Windows.Forms.Label();
            this.lbTaxa = new System.Windows.Forms.Label();
            this.lbTempo = new System.Windows.Forms.Label();
            this.lbJuros = new System.Windows.Forms.Label();
            this.lbMontante = new System.Windows.Forms.Label();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCalcular.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(94, 499);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(176, 49);
            this.btCalcular.TabIndex = 0;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btLimpar.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(320, 499);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(176, 49);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(320, 232);
            this.txtCapital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(177, 22);
            this.txtCapital.TabIndex = 3;
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(320, 297);
            this.txtTaxa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(177, 22);
            this.txtTaxa.TabIndex = 4;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(320, 368);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(177, 22);
            this.txtTempo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "CALCULADORA DE JUROS";
            // 
            // lbCapital
            // 
            this.lbCapital.AutoSize = true;
            this.lbCapital.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapital.Location = new System.Drawing.Point(90, 235);
            this.lbCapital.Name = "lbCapital";
            this.lbCapital.Size = new System.Drawing.Size(80, 23);
            this.lbCapital.TabIndex = 7;
            this.lbCapital.Text = "Capital:";
            // 
            // lbTaxa
            // 
            this.lbTaxa.AutoSize = true;
            this.lbTaxa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaxa.Location = new System.Drawing.Point(90, 297);
            this.lbTaxa.Name = "lbTaxa";
            this.lbTaxa.Size = new System.Drawing.Size(201, 23);
            this.lbTaxa.TabIndex = 8;
            this.lbTaxa.Text = "Taxa (porcentagem):";
            // 
            // lbTempo
            // 
            this.lbTempo.AutoSize = true;
            this.lbTempo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempo.Location = new System.Drawing.Point(90, 368);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(157, 23);
            this.lbTempo.TabIndex = 9;
            this.lbTempo.Text = "Tempo (meses):";
            // 
            // lbJuros
            // 
            this.lbJuros.AutoSize = true;
            this.lbJuros.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJuros.Location = new System.Drawing.Point(90, 441);
            this.lbJuros.Name = "lbJuros";
            this.lbJuros.Size = new System.Drawing.Size(64, 23);
            this.lbJuros.TabIndex = 11;
            this.lbJuros.Text = "Juros:";
            // 
            // lbMontante
            // 
            this.lbMontante.AutoSize = true;
            this.lbMontante.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontante.Location = new System.Drawing.Point(90, 169);
            this.lbMontante.Name = "lbMontante";
            this.lbMontante.Size = new System.Drawing.Size(104, 23);
            this.lbMontante.TabIndex = 13;
            this.lbMontante.Text = "Montante:";
            // 
            // txtMontante
            // 
            this.txtMontante.BackColor = System.Drawing.SystemColors.Window;
            this.txtMontante.Location = new System.Drawing.Point(320, 164);
            this.txtMontante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontante.Name = "txtMontante";
            this.txtMontante.Size = new System.Drawing.Size(177, 22);
            this.txtMontante.TabIndex = 12;
            // 
            // txtJuros
            // 
            this.txtJuros.BackColor = System.Drawing.SystemColors.Window;
            this.txtJuros.Location = new System.Drawing.Point(320, 436);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(177, 22);
            this.txtJuros.TabIndex = 14;
            // 
            // ComboBox
            // 
            this.ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "CALCULAR O MONTANTE SIMPLES",
            "CALCULAR O CAPITAL",
            "CALCULAR A TAXA",
            "CALCULAR O TEMPO",
            "CALCULAR JUROS"});
            this.ComboBox.Location = new System.Drawing.Point(93, 106);
            this.ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(404, 24);
            this.ComboBox.TabIndex = 15;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Selecione o que desejar calcular:";
            // 
            // FormJurosSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(569, 598);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.lbMontante);
            this.Controls.Add(this.txtMontante);
            this.Controls.Add(this.lbJuros);
            this.Controls.Add(this.lbTempo);
            this.Controls.Add(this.lbTaxa);
            this.Controls.Add(this.lbCapital);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCalcular);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormJurosSimples";
            this.Text = "Calculadora De Juros Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCapital;
        private System.Windows.Forms.Label lbTaxa;
        private System.Windows.Forms.Label lbTempo;
        private System.Windows.Forms.Label lbJuros;
        private System.Windows.Forms.Label lbMontante;
        private System.Windows.Forms.TextBox txtMontante;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label label7;
    }
}