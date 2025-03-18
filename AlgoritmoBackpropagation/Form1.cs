using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Prova2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            PrencherEntradas();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        // Variáveis 
        const int QuantidadeVetoresTreinamento = 100;
        const int QuantidadeNeuroriosEscondidos = 10; // Neuronios na camada escondida 

        public double[] pesoV = new double[QuantidadeNeuroriosEscondidos];
        public double[] pesoV_bias = new double[QuantidadeNeuroriosEscondidos];
        public double[] DeltaPesoV = new double[QuantidadeNeuroriosEscondidos];
        public double[] DeltaPesoV_bias = new double[QuantidadeNeuroriosEscondidos];

        public double[] pesoW = new double[QuantidadeNeuroriosEscondidos];
        public double[] pesoW_bias = new double[QuantidadeNeuroriosEscondidos];
        public double[] DeltaPesoW = new double[QuantidadeNeuroriosEscondidos]; // Variacao de pesos
        public double[] DeltaPesoW_bias = new double[QuantidadeNeuroriosEscondidos];

        double[] VetorEntradas_X = new double[QuantidadeVetoresTreinamento];
        double[] VetorSaindaDesejada_Y = new double[QuantidadeVetoresTreinamento];

        double[] z_in = new double[QuantidadeNeuroriosEscondidos];
        double[] z = new double[QuantidadeNeuroriosEscondidos];

        double m_TaxaAprendizagem = 0.002;

        // ************** FUNÇÃO DE ATIVAÇÃO SIGMOIDE ***************

        double FuncaoDeAtivacao(double x)
        {
            double y;
            double exponencial = Math.Exp(-1 * x);
            y = (double)((2.0 / (1.0 + exponencial)) - 1.0);

            return y;
        }
        void PrencherEntradas()
        {
            double pi = 3.1415;
            int PosicaoAtual = 0;
            double y;

            // Limpar os graficos
            GraficoFuncao.Series[0].Points.Clear();
           

            for (double i =0.0; i< (2*pi); i+= ((2*pi) / QuantidadeNeuroriosEscondidos))
            {
                y = Math.Sin(i) * Math.Sin(2 * i);
                VetorEntradas_X[PosicaoAtual] = i;
                VetorSaindaDesejada_Y[PosicaoAtual] = y;
                PosicaoAtual += 1;
                

                // Adiciona o ponto calculado na Série 0 (Funçao real)
                GraficoFuncao.Series[0].Points.AddXY(i,y);

                if (PosicaoAtual >= QuantidadeVetoresTreinamento) break;
            }
            return;
        }

        // ************** FUNÇÃO DE DERIVAÇÃO ***************

        double DerivadaFuncaoAtivacao(double x)
        {
            double funcaoX;
            double derivada;

            funcaoX = (double)((2.0 / (1.0 + Math.Exp(-1.0 * x))) - 1.0);
            derivada = (double)(0.5 * ((1.0 + funcaoX) * (1.0 - funcaoX)));

            return derivada;
        }

    // PASSO 0: INICIALIZAÇÃO DOS VALORES COM VALORES PEQUENOS

    void InicializarPesos(int QuantidadeNeuroniosEscondidos)
        {
            Random numAletatorio = new Random();

            for (int i = 0; i < QuantidadeNeuroniosEscondidos; i++)
            {
                pesoW[i] = ((Math.Pow(-1, numAletatorio.Next(10))) * numAletatorio.NextDouble()) / 3;
                pesoW_bias[i] = ((Math.Pow(-1, numAletatorio.Next(10))) * numAletatorio.NextDouble()) / 3;

                pesoV[i] = ((Math.Pow(-1, numAletatorio.Next(10))) * numAletatorio.NextDouble()) / 3;
                pesoV_bias[i] = ((Math.Pow(-1, numAletatorio.Next(10))) * numAletatorio.NextDouble()) / 3;
            }

            return;
        } // Final do void

        private DataGridView GetDataGridView1()
        {
            return dataGridView1;
        }

        // ************** FUNÇÃO DE ENTRADAS ***************/
        private void Treinar_Click(object sender, EventArgs e)
        {
            int Ciclos = 0;
            int QuatidadeMaximaCiclos;
            double t;
            double y_in;
            double y;
            double Deltinha;
            double Deltinha_in;
            double momento = 0.005;

            // Recolhe o valor da taxa de aprendizagem
            m_TaxaAprendizagem = Convert.ToDouble(textBoxTaxaAprendizagem.Text);

            // Recolhe os ciclos desejados
            QuatidadeMaximaCiclos = Convert.ToInt32(textBoxCiclos.Text);


            InicializarPesos(QuantidadeNeuroriosEscondidos); // Neuronios na camada escondida 

            // *************************** PASSO 1 *******************************

            double ErroParcial;

            while (Ciclos != QuatidadeMaximaCiclos)
            {

                Ciclos += 1; //incrementar ciclo

                ErroParcial = 0.0; // Zerar o erro parcial

                /************************* PASSO 2 **********************************/
                for (int VetorAtual = 0; VetorAtual < QuantidadeVetoresTreinamento; VetorAtual++)
                {


                    // ************************ PASSO 3 ***********************************/
                    double erro = 0;
                    y_in = VetorAtual * 0.1;
                    ErroParcial += erro * erro;

                    // ************** PASSO 4: Feedforward (calcular as saídas) **************/

                    // Camada escondida - z_inj = v0j + xi vij
                    for (int j = 0; j < QuantidadeNeuroriosEscondidos; j++)
                    {

                        z_in[j] += (VetorEntradas_X[VetorAtual] * pesoV[j]);
                        // Somar com o Bias
                        z_in[j] += pesoV_bias[j];

                        //Função de ativação aplicada
                        z[j] = FuncaoDeAtivacao(z_in[j]);

                        // ***************** PASSO 5 ************************


                        y_in += (z[j] * pesoW[j]);
                        // Somar com o Bias
                        y_in += pesoW_bias[j];
                    }


                    //Função de ativação aplicada
                    y = FuncaoDeAtivacao(y_in);

                    // Calculo do erro e acumulação em ErroParcial
                    t = VetorSaindaDesejada_Y[VetorAtual];
                    erro = t - y;
                    ErroParcial += 0.5 * erro * erro;

                    // Gradiente para o neurônio de saída
                    Deltinha = erro * DerivadaFuncaoAtivacao(y_in);

                    // *********************** PASSO 6 ************************

                    //calculando a saida desejada
                    t = VetorSaindaDesejada_Y[VetorAtual];

                    //calcular o sigma
                    Deltinha = (double)((t - y) * DerivadaFuncaoAtivacao(y_in));

                    
                    erro += (0.5) * ((t - y) * (t - y));
                    ErroParcial += erro * erro;

                    // Cálculo do Deltinha (Gradiente de saída)
                    Deltinha = erro * DerivadaFuncaoAtivacao(y_in);

                    // Atualização dos pesos da camada de saída
                    for (int i = 0; i < QuantidadeNeuroriosEscondidos; i++)
                    {
                        DeltaPesoW[i] = m_TaxaAprendizagem * Deltinha * z[i] + momento * DeltaPesoW[i];
                        pesoW[i] += DeltaPesoW[i];
                        DeltaPesoW_bias[i] = m_TaxaAprendizagem * Deltinha + momento * DeltaPesoW_bias[i];
                        pesoW_bias[i] += DeltaPesoW_bias[i];
                    }

                    // ************* Adicionar o Calculo ao gráfico **********************

                    double pi = 3.1415;
                    int PosicaoAtual = 0;

                    // Limpar os graficos
                    GraficoFuncao.Series[1].Points.Clear();

                    for (double i = 0.0; i < (2 * pi); i += ((2 * pi) / QuantidadeNeuroriosEscondidos))
                    {

                        VetorEntradas_X[PosicaoAtual] = i;
                        //VetorSaindaDesejada_Y[PosicaoAtual] = y;
                        PosicaoAtual += 1;


                        // Adiciona o ponto calculado na Série 1 (Função calculada)
                        GraficoFuncao.Series[1].Points.AddXY(i, Deltinha);

                        if (PosicaoAtual >= QuantidadeVetoresTreinamento) break;
                    }

                    // *********************** PASSO 7 ************************

                    // Backpropagation - atualização dos pesos da camada escondida
                    for (int i = 0; i < QuantidadeNeuroriosEscondidos; i++)
                    {
                        Deltinha_in = Deltinha * pesoW[i];
                        Deltinha = Deltinha_in * DerivadaFuncaoAtivacao(z_in[i]);

                        DeltaPesoV[i] = m_TaxaAprendizagem * Deltinha * VetorEntradas_X[VetorAtual] + momento * DeltaPesoV[i];
                        pesoV[i] += DeltaPesoV[i];
                        DeltaPesoV_bias[i] = m_TaxaAprendizagem * Deltinha + momento * DeltaPesoV_bias[i];
                        pesoV_bias[i] += DeltaPesoV_bias[i];
                    }
                }

                // *********************** PASSO 8 ************************

                //atualizar os pesos da camada de saída
                for (int i = 0; i < QuantidadeNeuroriosEscondidos; i++)
                    {
                        pesoW[i] += DeltaPesoW[i];
                        //atualizar o peso do bias
                        pesoW_bias[i] += DeltaPesoW_bias[i];
                    }


                // Média do erro parcial pelo número de vetores de treinamento
                ErroParcial /= QuantidadeVetoresTreinamento;
                GraficoErro.Series[0].Points.AddXY(Ciclos, ErroParcial);


                // Exibindo valores no DataGridView
                DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[0].Value = Ciclos;
                    row.Cells[1].Value = pesoV_bias[0].ToString("N10");
                    row.Cells[2].Value = pesoV[1].ToString("N10");
                    row.Cells[3].Value = pesoW_bias[2].ToString("N10");
                    row.Cells[4].Value = pesoW[3].ToString("N10");

                    dataGridView1.Rows.Add(row); // Adiciona a linha ao Grid
               
            }//fim fo while
            

        }
// fim botão treinar
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    } // fim do botão treinar


    }

