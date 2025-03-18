namespace Trabalho2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.QuantidadedeCiclos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelRespostaRede = new System.Windows.Forms.Label();
            this.comboxFonte = new System.Windows.Forms.ComboBox();
            this.comboxLetra = new System.Windows.Forms.ComboBox();
            this.Fonte = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridVisualizacao = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridTeste = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GraficoErroQuadratico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonTreinar = new System.Windows.Forms.Button();
            this.buttonTestar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisualizacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoErroQuadratico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 666);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciclos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // QuantidadedeCiclos
            // 
            this.QuantidadedeCiclos.AutoSize = true;
            this.QuantidadedeCiclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantidadedeCiclos.Location = new System.Drawing.Point(84, 666);
            this.QuantidadedeCiclos.Name = "QuantidadedeCiclos";
            this.QuantidadedeCiclos.Size = new System.Drawing.Size(22, 16);
            this.QuantidadedeCiclos.TabIndex = 1;
            this.QuantidadedeCiclos.Text = "---";
            this.QuantidadedeCiclos.Click += new System.EventHandler(this.Ciclos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(461, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desenhe a letra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Treinamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(505, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resposta da Rede:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelRespostaRede
            // 
            this.labelRespostaRede.AutoSize = true;
            this.labelRespostaRede.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRespostaRede.Location = new System.Drawing.Point(583, 456);
            this.labelRespostaRede.Name = "labelRespostaRede";
            this.labelRespostaRede.Size = new System.Drawing.Size(22, 16);
            this.labelRespostaRede.TabIndex = 6;
            this.labelRespostaRede.Text = "---";
            // 
            // comboxFonte
            // 
            this.comboxFonte.FormattingEnabled = true;
            this.comboxFonte.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboxFonte.Location = new System.Drawing.Point(27, 104);
            this.comboxFonte.Name = "comboxFonte";
            this.comboxFonte.Size = new System.Drawing.Size(55, 24);
            this.comboxFonte.TabIndex = 7;
            this.comboxFonte.SelectedIndexChanged += new System.EventHandler(this.comboBoxFonte_SelectedIndexChanged);
            // 
            // comboxLetra
            // 
            this.comboxLetra.FormattingEnabled = true;
            this.comboxLetra.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "J",
            "K"});
            this.comboxLetra.Location = new System.Drawing.Point(27, 176);
            this.comboxLetra.Name = "comboxLetra";
            this.comboxLetra.Size = new System.Drawing.Size(55, 24);
            this.comboxLetra.TabIndex = 8;
            this.comboxLetra.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Fonte
            // 
            this.Fonte.AutoSize = true;
            this.Fonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fonte.Location = new System.Drawing.Point(24, 85);
            this.Fonte.Name = "Fonte";
            this.Fonte.Size = new System.Drawing.Size(51, 18);
            this.Fonte.TabIndex = 9;
            this.Fonte.Text = "Fonte";
            this.Fonte.Click += new System.EventHandler(this.Fonte_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Letra";
            // 
            // dataGridVisualizacao
            // 
            this.dataGridVisualizacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVisualizacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridVisualizacao.Location = new System.Drawing.Point(88, 64);
            this.dataGridVisualizacao.Name = "dataGridVisualizacao";
            this.dataGridVisualizacao.RowHeadersWidth = 51;
            this.dataGridVisualizacao.RowTemplate.Height = 24;
            this.dataGridVisualizacao.Size = new System.Drawing.Size(256, 262);
            this.dataGridVisualizacao.TabIndex = 11;
            this.dataGridVisualizacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVisualizacao_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column1.HeaderText = "1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 24;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column2.HeaderText = "2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 24;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column3.HeaderText = "3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 24;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column4.HeaderText = "4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 24;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column5.HeaderText = "5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 24;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column6.HeaderText = "6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 24;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column7.HeaderText = "7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 24;
            // 
            // dataGridTeste
            // 
            this.dataGridTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridTeste.Location = new System.Drawing.Point(464, 64);
            this.dataGridTeste.Name = "dataGridTeste";
            this.dataGridTeste.RowHeadersWidth = 51;
            this.dataGridTeste.RowTemplate.Height = 24;
            this.dataGridTeste.Size = new System.Drawing.Size(256, 262);
            this.dataGridTeste.TabIndex = 12;
            this.dataGridTeste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTeste_CellContentClick);
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column8.HeaderText = "1";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 24;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column9.HeaderText = "2";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 24;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column10.HeaderText = "3";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 24;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column11.HeaderText = "4";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 24;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column12.HeaderText = "5";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 24;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column13.HeaderText = "6";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 24;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column14.HeaderText = "7";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 24;
            // 
            // GraficoErroQuadratico
            // 
            chartArea1.Name = "ChartArea1";
            this.GraficoErroQuadratico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficoErroQuadratico.Legends.Add(legend1);
            this.GraficoErroQuadratico.Location = new System.Drawing.Point(27, 347);
            this.GraficoErroQuadratico.Name = "GraficoErroQuadratico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GraficoErroQuadratico.Series.Add(series1);
            this.GraficoErroQuadratico.Size = new System.Drawing.Size(436, 300);
            this.GraficoErroQuadratico.TabIndex = 13;
            this.GraficoErroQuadratico.Text = "chart1";
            this.GraficoErroQuadratico.Click += new System.EventHandler(this.chart1_Click);
            // 
            // buttonTreinar
            // 
            this.buttonTreinar.Location = new System.Drawing.Point(269, 659);
            this.buttonTreinar.Name = "buttonTreinar";
            this.buttonTreinar.Size = new System.Drawing.Size(75, 23);
            this.buttonTreinar.TabIndex = 14;
            this.buttonTreinar.Text = "Treinar";
            this.buttonTreinar.UseVisualStyleBackColor = true;
            this.buttonTreinar.Click += new System.EventHandler(this.buttonTreinar_Click);
            // 
            // buttonTestar
            // 
            this.buttonTestar.Location = new System.Drawing.Point(678, 659);
            this.buttonTestar.Name = "buttonTestar";
            this.buttonTestar.Size = new System.Drawing.Size(75, 23);
            this.buttonTestar.TabIndex = 15;
            this.buttonTestar.Text = "Testar";
            this.buttonTestar.UseVisualStyleBackColor = true;
            this.buttonTestar.Click += new System.EventHandler(this.buttonTestar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 714);
            this.Controls.Add(this.buttonTestar);
            this.Controls.Add(this.buttonTreinar);
            this.Controls.Add(this.GraficoErroQuadratico);
            this.Controls.Add(this.dataGridTeste);
            this.Controls.Add(this.dataGridVisualizacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Fonte);
            this.Controls.Add(this.comboxLetra);
            this.Controls.Add(this.comboxFonte);
            this.Controls.Add(this.labelRespostaRede);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuantidadedeCiclos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisualizacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoErroQuadratico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QuantidadedeCiclos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelRespostaRede;
        private System.Windows.Forms.ComboBox comboxFonte;
        private System.Windows.Forms.ComboBox comboxLetra;
        private System.Windows.Forms.Label Fonte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridVisualizacao;
        private System.Windows.Forms.DataGridView dataGridTeste;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoErroQuadratico;
        private System.Windows.Forms.Button buttonTreinar;
        private System.Windows.Forms.Button buttonTestar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}

