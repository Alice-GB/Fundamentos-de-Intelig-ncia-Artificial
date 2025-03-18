namespace Prova1
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
            this.Treinar = new System.Windows.Forms.Button();
            this.GraficoErro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wBias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.P4 = new System.Windows.Forms.Label();
            this.P3 = new System.Windows.Forms.Label();
            this.labelDiagnostico = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Testar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Treinar
            // 
            this.Treinar.Location = new System.Drawing.Point(12, 675);
            this.Treinar.Name = "Treinar";
            this.Treinar.Size = new System.Drawing.Size(75, 23);
            this.Treinar.TabIndex = 0;
            this.Treinar.Text = "Treinar";
            this.Treinar.UseVisualStyleBackColor = true;
            this.Treinar.Click += new System.EventHandler(this.Treinar_Click);
            // 
            // GraficoErro
            // 
            this.GraficoErro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea1.Name = "ChartArea1";
            this.GraficoErro.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficoErro.Legends.Add(legend1);
            this.GraficoErro.Location = new System.Drawing.Point(12, 338);
            this.GraficoErro.Name = "GraficoErro";
            this.GraficoErro.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GraficoErro.Series.Add(series1);
            this.GraficoErro.Size = new System.Drawing.Size(803, 300);
            this.GraficoErro.TabIndex = 1;
            this.GraficoErro.Text = "Erros";
            this.GraficoErro.Click += new System.EventHandler(this.GraficoErro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ciclo,
            this.w1,
            this.w2,
            this.w3,
            this.w4,
            this.wBias});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 249);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ciclo
            // 
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.MinimumWidth = 6;
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.Width = 125;
            // 
            // w1
            // 
            this.w1.HeaderText = "w1";
            this.w1.MinimumWidth = 6;
            this.w1.Name = "w1";
            this.w1.Width = 125;
            // 
            // w2
            // 
            this.w2.HeaderText = "w2";
            this.w2.MinimumWidth = 6;
            this.w2.Name = "w2";
            this.w2.Width = 125;
            // 
            // w3
            // 
            this.w3.HeaderText = "w3";
            this.w3.MinimumWidth = 6;
            this.w3.Name = "w3";
            this.w3.Width = 125;
            // 
            // w4
            // 
            this.w4.HeaderText = "w4";
            this.w4.MinimumWidth = 6;
            this.w4.Name = "w4";
            this.w4.Width = 125;
            // 
            // wBias
            // 
            this.wBias.HeaderText = "wBias";
            this.wBias.MinimumWidth = 6;
            this.wBias.Name = "wBias";
            this.wBias.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(867, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Propriedades Físico-químicas do oléo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Location = new System.Drawing.Point(870, 99);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(26, 16);
            this.P1.TabIndex = 6;
            this.P1.Text = "P1:";
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Location = new System.Drawing.Point(870, 132);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(26, 16);
            this.P2.TabIndex = 7;
            this.P2.Text = "P2:";
            // 
            // P4
            // 
            this.P4.AutoSize = true;
            this.P4.Location = new System.Drawing.Point(870, 200);
            this.P4.Name = "P4";
            this.P4.Size = new System.Drawing.Size(26, 16);
            this.P4.TabIndex = 8;
            this.P4.Text = "P4:";
            // 
            // P3
            // 
            this.P3.AutoSize = true;
            this.P3.Location = new System.Drawing.Point(870, 166);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(26, 16);
            this.P3.TabIndex = 9;
            this.P3.Text = "P3:";
            // 
            // labelDiagnostico
            // 
            this.labelDiagnostico.AutoSize = true;
            this.labelDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiagnostico.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDiagnostico.Location = new System.Drawing.Point(919, 313);
            this.labelDiagnostico.Name = "labelDiagnostico";
            this.labelDiagnostico.Size = new System.Drawing.Size(40, 29);
            this.labelDiagnostico.TabIndex = 10;
            this.labelDiagnostico.Text = "---";
            this.labelDiagnostico.Click += new System.EventHandler(this.labelDiagnostico_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(924, 93);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 22);
            this.TextBox1.TabIndex = 11;
            this.TextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(924, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(924, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(924, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 14;
            // 
            // Testar
            // 
            this.Testar.Location = new System.Drawing.Point(853, 615);
            this.Testar.Name = "Testar";
            this.Testar.Size = new System.Drawing.Size(75, 23);
            this.Testar.TabIndex = 15;
            this.Testar.Text = "Testar";
            this.Testar.UseVisualStyleBackColor = true;
            this.Testar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(220, 685);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "---";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(870, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Classificação de pureza:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 682);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total de Ciclos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 710);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Testar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.labelDiagnostico);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.P4);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GraficoErro);
            this.Controls.Add(this.Treinar);
            this.Name = "Form1";
            this.Text = "Rede Adaline";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GraficoErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Treinar;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoErro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn w1;
        private System.Windows.Forms.DataGridViewTextBoxColumn w2;
        private System.Windows.Forms.DataGridViewTextBoxColumn w3;
        private System.Windows.Forms.DataGridViewTextBoxColumn w4;
        private System.Windows.Forms.DataGridViewTextBoxColumn wBias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Label P4;
        private System.Windows.Forms.Label P3;
        private System.Windows.Forms.Label labelDiagnostico;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Testar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

