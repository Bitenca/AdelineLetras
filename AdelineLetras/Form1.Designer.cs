namespace AdelineLetras
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.rbTipo3 = new System.Windows.Forms.RadioButton();
            this.rbTipo2 = new System.Windows.Forms.RadioButton();
            this.rbTipo1 = new System.Windows.Forms.RadioButton();
            this.listBoxLetras = new System.Windows.Forms.ListBox();
            this.btnMostra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Treinar = new System.Windows.Forms.Button();
            this.Testar = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.rbTipo3);
            this.groupbox.Controls.Add(this.rbTipo2);
            this.groupbox.Controls.Add(this.rbTipo1);
            this.groupbox.Location = new System.Drawing.Point(12, 19);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(78, 102);
            this.groupbox.TabIndex = 0;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Fonte";
            // 
            // rbTipo3
            // 
            this.rbTipo3.AutoSize = true;
            this.rbTipo3.Location = new System.Drawing.Point(7, 79);
            this.rbTipo3.Name = "rbTipo3";
            this.rbTipo3.Size = new System.Drawing.Size(55, 17);
            this.rbTipo3.TabIndex = 2;
            this.rbTipo3.TabStop = true;
            this.rbTipo3.Text = "Tipo 3";
            this.rbTipo3.UseVisualStyleBackColor = true;
            // 
            // rbTipo2
            // 
            this.rbTipo2.AutoSize = true;
            this.rbTipo2.Location = new System.Drawing.Point(7, 50);
            this.rbTipo2.Name = "rbTipo2";
            this.rbTipo2.Size = new System.Drawing.Size(55, 17);
            this.rbTipo2.TabIndex = 1;
            this.rbTipo2.TabStop = true;
            this.rbTipo2.Text = "Tipo 2";
            this.rbTipo2.UseVisualStyleBackColor = true;
            // 
            // rbTipo1
            // 
            this.rbTipo1.AutoSize = true;
            this.rbTipo1.Location = new System.Drawing.Point(7, 21);
            this.rbTipo1.Name = "rbTipo1";
            this.rbTipo1.Size = new System.Drawing.Size(55, 17);
            this.rbTipo1.TabIndex = 0;
            this.rbTipo1.TabStop = true;
            this.rbTipo1.Text = "Tipo 1";
            this.rbTipo1.UseVisualStyleBackColor = true;
            // 
            // listBoxLetras
            // 
            this.listBoxLetras.FormattingEnabled = true;
            this.listBoxLetras.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "J",
            "K"});
            this.listBoxLetras.Location = new System.Drawing.Point(96, 26);
            this.listBoxLetras.Name = "listBoxLetras";
            this.listBoxLetras.Size = new System.Drawing.Size(49, 95);
            this.listBoxLetras.TabIndex = 1;
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(11, 127);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(133, 42);
            this.btnMostra.TabIndex = 2;
            this.btnMostra.Text = "Mostrar>>";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.btnMostra_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(174, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.Size = new System.Drawing.Size(212, 221);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 25;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 25;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 25;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 25;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "6";
            this.Column6.Name = "Column6";
            this.Column6.Width = 25;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "7";
            this.Column7.Name = "Column7";
            this.Column7.Width = 25;
            // 
            // Treinar
            // 
            this.Treinar.Location = new System.Drawing.Point(36, 111);
            this.Treinar.Name = "Treinar";
            this.Treinar.Size = new System.Drawing.Size(126, 29);
            this.Treinar.TabIndex = 4;
            this.Treinar.Text = "Treinar";
            this.Treinar.UseVisualStyleBackColor = true;
            this.Treinar.Click += new System.EventHandler(this.Treinar_Click);
            // 
            // Testar
            // 
            this.Testar.Location = new System.Drawing.Point(11, 242);
            this.Testar.Name = "Testar";
            this.Testar.Size = new System.Drawing.Size(133, 44);
            this.Testar.TabIndex = 5;
            this.Testar.Text = "Testar";
            this.Testar.UseVisualStyleBackColor = true;
            this.Testar.Click += new System.EventHandler(this.Testar_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(174, 266);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(212, 20);
            this.tbFind.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Caracter Reconhecido: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "( Ruído 0,00   % )";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Treinar);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 293);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treinamento da rede";
            // 
            // chart1
            // 
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BorderColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 76.38806F;
            chartArea6.Position.Width = 100F;
            chartArea6.Position.Y = 23.61194F;
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Alignment = System.Drawing.StringAlignment.Center;
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.MaximumAutoSize = 30F;
            legend6.Name = "teste";
            legend6.Title = "Erro Quadrático X Ciclo";
            legend6.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(9, 147);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "teste";
            series6.Name = "ErroQ";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(478, 135);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(9, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 87);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Características da rede";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "-Taxa de Aprendizagem: 0.02";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Adaline ( Regra Delta )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "-Algorítmo usado no treinamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "-21 entradas para treinamento (3 fontes)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "-Erro Mínimo: 0.0001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "-Utiliza-se o Bias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "-Número dos neurônios de entrada: 63";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(196, 113);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(245, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupbox);
            this.groupBox3.Controls.Add(this.listBoxLetras);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnMostra);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.tbFind);
            this.groupBox3.Controls.Add(this.Testar);
            this.groupBox3.Location = new System.Drawing.Point(513, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 293);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teste da Rede";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 318);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Adeline Letras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.RadioButton rbTipo3;
        private System.Windows.Forms.RadioButton rbTipo2;
        private System.Windows.Forms.RadioButton rbTipo1;
        private System.Windows.Forms.ListBox listBoxLetras;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button Treinar;
        private System.Windows.Forms.Button Testar;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

