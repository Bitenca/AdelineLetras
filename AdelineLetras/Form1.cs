using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdelineLetras
{

    public partial class Form1 : Form
    {
        Letras letras = new Letras();
        double[,] pesos = new double[7, 64];
        double[,] saidaDesejada = new double[7, 21];
        double[,] matrizTotal = new double[21, 64];
        double[] vetorGrid = new double[64];

        double soma = 0;
        double erro = 0;
        double deltaW = 0;
        double taxaAprendizagem = 0.02;
        double erroMinimo = 0.01;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                dataGridView1.Rows.Add();
            }

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            double[,] MatLetra = DescobreOpcao(letras);

            if (MatLetra == null)
            {
                MessageBox.Show("Defina uma letra!!!!");
            }
            else
            {
                PrintaLetra(MatLetra);
            }

        }

        private double[,] DescobreOpcao(Letras letras)
        {
            if (rbTipo1.Checked == true)
            {
                if (listBoxLetras.SelectedIndex == 0)
                {
                    return letras.ATipo1;
                }
                if (listBoxLetras.SelectedIndex == 1)
                {
                    return letras.BTipo1;
                }
                if (listBoxLetras.SelectedIndex == 2)
                {
                    return letras.CTipo1;
                }
                if (listBoxLetras.SelectedIndex == 3)
                {
                    return letras.DTipo1;
                }
                if (listBoxLetras.SelectedIndex == 4)
                {
                    return letras.ETipo1;
                }
                if (listBoxLetras.SelectedIndex == 5)
                {
                    return letras.JTipo1;
                }
                if (listBoxLetras.SelectedIndex == 6)
                {
                    return letras.KTipo1;
                }
            }
            else if (rbTipo2.Checked == true)
            {
                if (listBoxLetras.SelectedIndex == 0)
                {
                    return letras.ATipo2;
                }
                if (listBoxLetras.SelectedIndex == 1)
                {
                    return letras.BTipo2;
                }
                if (listBoxLetras.SelectedIndex == 2)
                {
                    return letras.CTipo2;
                }
                if (listBoxLetras.SelectedIndex == 3)
                {
                    return letras.DTipo2;
                }
                if (listBoxLetras.SelectedIndex == 4)
                {
                    return letras.ETipo2;
                }
                if (listBoxLetras.SelectedIndex == 5)
                {
                    return letras.JTipo2;
                }
                if (listBoxLetras.SelectedIndex == 6)
                {
                    return letras.KTipo2;
                }
            }
            else if (rbTipo3.Checked == true)
            {
                if (listBoxLetras.SelectedIndex == 0)
                {
                    return letras.ATipo3;
                }
                if (listBoxLetras.SelectedIndex == 1)
                {
                    return letras.BTipo3;
                }
                if (listBoxLetras.SelectedIndex == 2)
                {
                    return letras.CTipo3;
                }
                if (listBoxLetras.SelectedIndex == 3)
                {
                    return letras.DTipo3;
                }
                if (listBoxLetras.SelectedIndex == 4)
                {
                    return letras.ETipo3;
                }
                if (listBoxLetras.SelectedIndex == 5)
                {
                    return letras.JTipo3;
                }
                if (listBoxLetras.SelectedIndex == 6)
                {
                    return letras.KTipo3;
                }
            }
            return null;
        }

        private void PrintaLetra(double[,] letraTipo)
        {

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (letraTipo[i, j] == 1)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = "#";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j].Value = ".";
                    }
                }
            }
        }

        private void Treinar_Click(object sender, EventArgs e)
        {
            double MaiorErroQ = 1;
            pesos = letras.pesos;
            saidaDesejada = letras.saidadesejada;
            matrizTotal = letras.getMatrizTotal();
            double erroQCalculado;
            int ciclo = 0;

            while (MaiorErroQ > erroMinimo)
            {
                MaiorErroQ = -1000;

                for (int i = 0; i < 7; i++)//for percorrendo as 7 letras
                {

                    deltaW = 0;
                    for (int j = 0; j < 21; j++)
                    {
                        soma = 0;
                        for (int k = 0; k < 64; k++)//calculo da sinapse
                        {
                            soma += matrizTotal[j, k] * pesos[i, k];
                        }

                        erro = saidaDesejada[i, j] - soma;
                        erroQCalculado = (erro * erro) / 2;

                        if (erroQCalculado > MaiorErroQ)//descobrindo o maiorerro
                        {
                            MaiorErroQ = erroQCalculado;

                        }

                        for (int l = 0; l < 64; l++) //atualizacao dos pesos
                        {
                            deltaW = erro * matrizTotal[j, l] * taxaAprendizagem;
                            pesos[i, l] += deltaW;
                        }

                    }
                    this.chart1.Series["ErroQ"].Points.AddXY(ciclo, MaiorErroQ);
                    ciclo++;
                    progressBar1.Maximum = ciclo;
                    progressBar1.Value += 1;
                }
            }
        }

        private void Testar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            double[] somaLetra = new double[7] { 0, 0, 0, 0, 0, 0, 0 };
            int contRuido = GetMatLetra(cont);
            double ruido = 0.0;


            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 64; j++)
                {
                    somaLetra[i] += vetorGrid[j] * pesos[i, j];
                }
            }

            ruido = 100.0 * contRuido / 63;
            label2.Text = String.Format("( Ruído {0:N2}   % )", ruido);

            CheckRecognize(somaLetra);

        }

        private int GetMatLetra(int cont)
        {
            int contRuido = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.Equals("#"))
                    {
                        vetorGrid[cont] = 1;
                    }
                    else if (dataGridView1.Rows[i].Cells[j].Value.Equals("."))
                    {
                        vetorGrid[cont] = -1;
                    }
                    else
                    {
                        vetorGrid[cont] = 0;
                        contRuido++;
                    }
                    cont++;
                }
            }
            vetorGrid[63] = 1; // bias
            return contRuido;
        }

        private void CheckRecognize(double[] somaLetra)
        {
            tbFind.Text = string.Empty;
            if (ValidateLetra(somaLetra[0]) == 1)
            {
                tbFind.Text = tbFind.Text + "A ";
            }
            if (ValidateLetra(somaLetra[1]) == 1)
            {
                tbFind.Text = tbFind.Text + "B ";
            }
            if (ValidateLetra(somaLetra[2]) == 1)
            {
                tbFind.Text = tbFind.Text + "C ";
            }
            if (ValidateLetra(somaLetra[3]) == 1)
            {
                tbFind.Text = tbFind.Text + "D ";
            }
            if (ValidateLetra(somaLetra[4]) == 1)
            {
                tbFind.Text = tbFind.Text + "E ";
            }
            if (ValidateLetra(somaLetra[5]) == 1)
            {
                tbFind.Text = tbFind.Text + "J ";
            }
            if (ValidateLetra(somaLetra[6]) == 1)
            {
                tbFind.Text = tbFind.Text + "K ";
            }
        }

        private double ValidateLetra(double v)
        {
            if (v >= 0)
                return 1;
            else
                return -1;
        }
    }
}