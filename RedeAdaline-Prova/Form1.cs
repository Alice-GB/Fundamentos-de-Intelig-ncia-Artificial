using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Prova1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Base de treinamento:  35 amostras
        double[,] X_VetoresTreinamento = new double[,] {    {0.4329, -1.3719, 0.7022, -0.8535, 1},
                                                            {0.3024, 0.2286, 0.863, 2.7909 , 1},
                                                            {0.1349, -0.6445, 1.053, 0.5687 , 1},
                                                            {0.3374, -1.7163, 0.367, -0.6283 , 1},
                                                            {1.1434, -0.0485 ,0.6637, 1.2606 , 1},
                                                            {1.3749, -0.5071, 0.4464, 1.3009 , 1},
                                                            {0.7221, -0.7587 ,0.7681, -0.5592 , 1},
                                                            {0.4403, -0.8072 ,0.5154, -0.3129 , 1},
                                                            {-0.5231, 0.3548, 0.2538, 1.5776 , 1},
                                                            {0.3255, -2, 0.7112, -1.1209 , 1},
                                                            {0.5824, 1.3915, -0.2291, 4.1735 , 1},
                                                            {0.134, 0.6081, 0.445, 3.223 , 1},
                                                            {0.148, -0.2988, 0.4778, 0.8649 , 1},
                                                            {0.7359, 0.1869 ,-0.0872, 2.3584 , 1},
                                                            {0.7115, -1.1469, 0.3394, 0.9573 , 1},
                                                            {0.8251, -1.284 ,0.8452, 1.2382 , 1},
                                                            {0.1569, 0.3712, 0.8825, 1.7633 , 1},
                                                            {0.0033, 0.6835, 0.5389, 2.8249 , 1},
                                                            {0.4243, 0.8313, 0.2634 ,3.5855 , 1},
                                                            {1.049, 0.1326 ,0.9138 ,1.9792 , 1},
                                                            {1.4276, 0.5331, -0.0145, 3.7286 , 1},
                                                            {0.5971, 1.4865, 0.2904 ,4.6069 , 1},
                                                            {0.8475, 2.1479, 0.3179, 5.8235 , 1},
                                                            {1.3967, -0.4171, 0.6443 ,1.3927 , 1},
                                                            {0.0044, 1.5378, 0.6099, 4.7755 , 1},
                                                            {0.2201, -0.5668, 0.0515, 0.7829 , 1},
                                                            {0.63, -1.248, 0.8591, 0.8093 , 1},
                                                            {-0.2479, 0.896, 0.0547, 1.7381 , 1},
                                                            {-0.3088, -0.0929, 0.8659, 1.5483 , 1},
                                                            {-0.518, 1, 0.5453, 2.3993 , 1},
                                                            {0.6833, 0.8266, 0.0829, 2.8864 , 1},
                                                            {0.4353, -1.4066, 0.4207, -0.4879 , 1},
                                                            {-0.1069, -3.2329, 0.1856, -2.4572 , 1},
                                                            {0.4662, 0.6261, 0.7304, 3.437 , 1},
                                                            {0.8298, -1.4089, 0.3119, 1.3235 , 1}};

        // 35 saidas desejadas: 1 para cada amostra de treinamento
        double[] Y_SaidaDesejada = new double[] { 1, -1, -1, -1, 1, 1, 1, 1, -1, 1, -1, -1, 1, 1, -1, -1, 1, -1, -1, 1, 1, -1, -1, 1, -1, 1, -1, 1, -1, 1, 1, 1, -1, -1, -1 };

        // Variaveis
        double ErroQuadraticoMedio = 1;
        double SomaErroQuadraticoCiclo = 0;
        double ErroQuadraticoMedioAtual = 0;
        double ErroQuadraticoMedioAnterior = 1;
        double Ciclos = 0;
        double[] W_Pesos = new double[] { 0, 0, 0, 0, 0 };
        string[] CicloPesoGrid = new string[6]; // Mostrar os pesos no grid em cada ciclo.
        double Erro = 0; // Inicializa o erro 
        double ErroMinimo = 0.0001;  // Nosso erro não pode ser exatamente 0, mas deve tender a 0, estar entre 0 e 1.
        int QuatidadeMaximaCiclos = 1000; // Numero maximo de ciclos 
        double TaxaAprendizagem = 0.001; // eta 



        // *********************************  Botão de treinamento *************************************

        private void Treinar_Click(object sender, EventArgs e)
        {
            while ((Math.Abs(ErroQuadraticoMedioAtual - ErroQuadraticoMedioAnterior) > ErroMinimo) && (Ciclos < QuatidadeMaximaCiclos))
            {
                SomaErroQuadraticoCiclo = 0;
                ErroQuadraticoMedioAnterior = ErroQuadraticoMedioAtual; // Armazenado do ciclo anterior

                // Atualiza os pesos para cada vetor de treinamento
                for (int i = 0; i < 35; i++) // Percorre todas as linhas da amostra
                {
                    double u = 0;

                    for (int j = 0; j < 5; j++)
                    {
                        u += X_VetoresTreinamento[i, j] * W_Pesos[j]; // Acumula a saída atual da rede
                    }
                 
                    // Calculo de erro
                    Erro = (Y_SaidaDesejada[i] - u ) * -1; // Verifica a margem de erro

                    // Atualizar os pesos e bias
                    for (int j = 0; j < 5; j++)
                    {
                        double DeltaW = TaxaAprendizagem * Erro * X_VetoresTreinamento[i, j];
                        W_Pesos[j] += DeltaW;
                    }
                    // Calculo de erro quadratico
                    SomaErroQuadraticoCiclo += Math.Pow(Erro, 2); // Total do erro quadratico (erro * erro)
                }

                // Calcula o erro quad. medio
                ErroQuadraticoMedio = SomaErroQuadraticoCiclo / 35;

                // Erro quad. medio recebe o erro no ciclo
                ErroQuadraticoMedioAtual = ErroQuadraticoMedio;

                Ciclos++; // Adiciona ao ciclo

                //chart1.Series[0].Points.Add(Math.Abs(ErroQuadraticoMedio)); // Adiciona ao Grafico

                CicloPesoGrid[0] = Ciclos.ToString();
                CicloPesoGrid[1] = W_Pesos[0].ToString("N10"); // Mostra 10 casas decimais após a virgula
                CicloPesoGrid[2] = W_Pesos[1].ToString("N10");
                CicloPesoGrid[3] = W_Pesos[2].ToString("N10");
                CicloPesoGrid[4] = W_Pesos[3].ToString("N10");
                CicloPesoGrid[5] = W_Pesos[4].ToString("N10");

                dataGridView1.Rows.Add(CicloPesoGrid); // Adiciona ao Grid
            } // Fim while
            label2.Text = Ciclos.ToString();
        }

                // *********************************  Botão de teste *******************************************

        private void Testar_Click(object sender, EventArgs e)
            {
                // Capturar as entradas das TextBoxes
                double P1 = Convert.ToDouble(TextBox1.Text);
                double P2 = Convert.ToDouble(textBox2.Text);
                double P3 = Convert.ToDouble(textBox3.Text);
                double P4 = Convert.ToDouble(textBox4.Text);

                //   double expectedOutput = Convert.ToDouble(textBox4.Text); // Saída esperada (1 ou -1)
                
                double somatorio;
                somatorio = W_Pesos[0] * P1 + W_Pesos[1] * P2 + W_Pesos[2] * P3 + W_Pesos[3] * P4 + 1 * W_Pesos[4];

                // Função de ativação -- Diagnóstico
                if (somatorio >= 0) labelDiagnostico.Text = "Tipo2"; //1
                else labelDiagnostico.Text = "Tipo1"; //-1
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }

    }

