using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[,] Fontes = new double[21, 64] {{ -1,    -1, 1,  1,  -1, -1,   -1, -1, -1, -1, 1,  -1, -1, -1,     -1, -1, -1, 1,  -1, -1, -1,     -1, -1, 1,  -1, 1,  -1, -1,     -1, -1, 1,  -1, 1,  -1, -1, -1, 1,  1,  1,  1,  1,  -1, -1, 1,  -1, -1, -1, 1,  -1, -1, 1,  -1, -1, -1, 1,  -1, 1,  1,  1,  -1, 1,  1,  1,1}, // A1:
                                               {-1,    -1, -1, 1,  -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, 1,  -1, 1,  -1, -1,     -1, -1, 1,  -1, 1,  -1, -1, -1, 1,  1,  1,  1,  1,  -1, -1, 1,  -1, -1, -1, 1,  -1, -1, 1,  -1, -1, -1, 1,  -1, -1, 1,  -1, -1, -1, 1,  -1,1}, // A2: 
                                               {-1,    -1, -1, 1,  -1,     -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, 1,  -1, -1, -1, 1,  -1, -1, 1,  1,  1,  1,  1,  -1, 1,  -1, -1, -1, -1, -1, 1,  1,  -1, -1, -1, -1, -1, 1,  1,  1,  -1, -1, -1, 1,  1,1}, // A3:
                                               {1, 1,  1,  1,  1,  1,  -1, -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  1,  1,  1,  1,  -1, -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  1,  1,  1,  1,  1,  1,  -1,1}, // B1:
                                               {1, 1,  1,  1,  1,  1,  -1, 1,  -1, -1, -1, -1, -1, 1,  1,  -1, -1, -1, -1, -1, 1,  1,  1,  1,  1,  1,  1,  -1, 1,  1,  1,  1,  1,  1,  -1, 1,  -1, -1, -1, -1, -1, 1,  1,  -1, -1, -1, -1, -1, 1,  1,  -1, -1, -1, -1, -1, 1,  1,  1,  1,  1,  1,  1,  -1,1}, // B2:
                                               {1, 1,  1,  1,  1,  1,  -1, -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  1,  1,  1,  1,  -1, -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  1,  1,  1,  1,  1,  1,   -1,1}, //B3:
                                               {-1,   -1, 1,  1,  1,  1,  1,  -1, 1,  -1, -1, -1, -1, 1,  1,  -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, 1,  -1, -1, 1,  1,  1,  1,  1,1}, //C1:
                                               { -1,   -1, 1,  1,  1,  -1, -1, -1, 1,  -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, -1, 1,  1,  -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, 1,  -1, -1, -1, 1,  1,  1,  -1, -1,1}, //C2:
                                               { -1,   -1, 1,  1,  1,  -1, 1,  -1, 1,  -1, -1, -1, 1,  1,  1,  -1, -1, -1, -1, -1, 1,  1,  -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, -1, 1,  -1, -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, 1,  -1, -1, -1, 1,  1,  1,  -1, -1,1 }, //C3:
                                               {1, 1,  1,  1,  1,  -1, -1, -1, 1,  -1, -1, -1, 1,  -1, -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, 1,  -1, 1,  1,  1,  1,  1,  -1, -1,1}, //D1 
                                               {1, 1,  1,  1,  1,  -1, -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, -1, 1,  1,  -1, -1, -1, -1, -1, 1,  1,  -1, -1, -1, -1, -1, 1,  1,  -1, -1, -1, -1, -1, 1,  1,  -1, -1, -1, -1, -1, 1,  1,  -1, -1, -1, -1, 1,  -1, 1,  1,  1,  1,  1,  -1, -1,1}, //D2 
                                               {1,  1,  1,  1,  1,  -1, -1, -1, 1,  -1, -1, -1, 1,  -1, -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, -1, 1,  -1, 1,  -1, -1, -1, 1,  -1, 1,  1,  1,  1,  1,  -1, -1,1}, //D3
                                               {1, 1, 1, 1, 1, 1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, 1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, //e1
                                               {1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, 1}, //e2
                                               { 1, 1, 1, 1, 1, 1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, 1, -1, -1, -1, 1, 1, 1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, //e3
                                               { -1, -1, -1, 1, 1, 1, 1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, 1, 1, -1, -1, 1}, //j1
                                               { -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, 1, 1, -1, -1, 1}, //j2
                                               { -1, -1, -1, -1, 1, 1, 1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, 1, 1, -1, -1, 1}, //j3
                                               { 1, 1, 1, -1, -1, 1, 1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, 1, 1, 1, -1, -1, 1, 1, 1}, //k1
                                               { 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, -1, 1, -1, 1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, -1, 1, -1, 1}, //k2
                                               { 1, -1, -1, -1, -1, 1, 1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, 1, 1, 1, -1, -1, 1, 1, 1}};//k3

        double[,] Pesos = new double[7, 64]; // 1 conjunto de 64 pesos para cada 7 neuronios
        double TaxaAprendizagem = 0.002;
        double QuantidadeMaximaCiclos = 1000;
        double ErroMinimo = 0.0001;

        double[,] Saidas_Desejadas = new double[,]
        {
    { 1,-1,-1,-1,-1,-1,-1,1, -1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1 }, // A
    { -1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1 }, //B
    {-1,-1,1,-1,-1,-1,-1, -1,-1,1,-1,-1,-1,-1, -1,-1,1,-1,-1,-1,-1}, //C
    { -1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1 }, // D
    { -1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1, -1,-1,-1,-1,1,-1,-1 }, // E
    {-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1 }, // J
    {-1,-1,-1,-1,-1,-1,1, -1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1 }, //K
        };

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridVisualizacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridTeste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void comboBoxFonte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Ciclos_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void Fonte_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Inserir 9 Linhas 
            for (int i = 0; i < 9; i++)
            {
                //Visualiizaço
                dataGridVisualizacao.Rows.Add();
                dataGridVisualizacao.Rows[i].HeaderCell.Value = (i + 1).ToString();

                //Teste
                dataGridTeste.Rows.Add();
                dataGridTeste.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

            for (int Linha = 0; Linha < 9; Linha++)
            {
                for (int Coluna = 0; Coluna < 7; Coluna++)
                {
                    dataGridTeste.Rows[Linha].Cells[Coluna].Value = ".";
                }
            }

            //Preencher o grid Teste
            for (int Linha = 0; Linha < 9; Linha++)
            {
                for (int Coluna = 0; Coluna < 7; Coluna++)
                {
                    dataGridVisualizacao.Rows[Linha].Cells[Coluna].Value = ".";
                }
            }
           

            comboxFonte.SelectedIndex = 0; // ERRO: diz que o valor é inválido
            comboxLetra.SelectedIndex = 0;
            /* Tentei acrescentar itens, não deu certo: if (comboxFonte.Items.Count > 0)
            {
                comboxFonte.SelectedIndex = 0;
            }
             * Tentei:  comboxFonte.SelectedIndexChanged -= comboxFonte_SelectedIndexChanged;
             comboxFonte.SelectedIndex = 0;
             comboxFonte.SelectedIndexChanged += comboxFonte_SelectedIndexChanged;
            Não deu certo*/

            // Mostrar o grafico 
            GraficoErroQuadratico.Series[0].Points.Add(0, 0);

}
private void comboxFonte_SelectIndexChanged(object sender, EventArgs e)
{
 MostrarLetra();

}
private void comboxLetra_SelectIndexChanged(object sender, EventArgs e)
{
 MostrarLetra();

}
void MostrarLetra()
{
 int Fonte = comboxFonte.SelectedIndex;
 int Letra = comboxLetra.SelectedIndex;

 if (Fonte == 0) // Fonte 1
 {
     {
         if (Letra == 0) PreencherGrid(0); // A
         if (Letra == 1) PreencherGrid(3); // B
         if (Letra == 2) PreencherGrid(6); // C
         if (Letra == 3) PreencherGrid(9); // D
         if (Letra == 4) PreencherGrid(12); // E
         if (Letra == 5) PreencherGrid(15); // J
         if (Letra == 6) PreencherGrid(18); // K

     }
 }

 if (Fonte == 1) // Fonte 2
 {
     {
         if (Letra == 0) PreencherGrid(1); // A
         if (Letra == 1) PreencherGrid(4); // B
         if (Letra == 2) PreencherGrid(7); // C
         if (Letra == 3) PreencherGrid(10); // D
         if (Letra == 4) PreencherGrid(13); // E
         if (Letra == 5) PreencherGrid(16); // J
         if (Letra == 6) PreencherGrid(19); // K

     }
 }

 if (Fonte == 2) // Fonte 3
 {
     {
         if (Letra == 0) PreencherGrid(2); // A
         if (Letra == 1) PreencherGrid(5); // B
         if (Letra == 2) PreencherGrid(8); // C
         if (Letra == 3) PreencherGrid(11); // D
         if (Letra == 4) PreencherGrid(14); // E
         if (Letra == 5) PreencherGrid(17); // J
         if (Letra == 6) PreencherGrid(20); // K

     }
 }

}

void PreencherGrid(int index)
{

 int Linha, Coluna;
 Linha = 0;
 Coluna = 0;

 // em index está o caracter escolhido
 for (int i = 0; i < 63; i++)
 {
     if (Fontes[index, i] == 1) // Se for 1 então escrevemos #
     {
         //Coluna Linha
         dataGridTeste.Rows[Linha].Cells[Coluna].Value = "#";
     }
     else
     {
         dataGridTeste.Rows[Linha].Cells[Coluna].Value = ".";
     }

     Coluna++;
     if (Coluna == 7)
     {
         Coluna = 0;
         Linha++;
     }
 }
}

private void buttonTreinar_Click(object sender, EventArgs e)
{
 //zerar os pesos
 for (int i = 0; i < 7; i++)
 {
     for (int j = 0; j < 64; j++)
         Pesos[1, j] = 0;
 }

 //limpar o grafico
 GraficoErroQuadratico.Series[0].Points.Clear();

 double ErroQuadraticoMedio = 1;
 double SomaErroQuadraticoCiclo = 0;
 double ErroQuadraticoMedioAtual = 0;
 double ErroQuadraticoMedioAnterior = 1;
 int Ciclos = 0;

 double Erro = 0;

 while ((Math.Abs(ErroQuadraticoMedioAtual - ErroQuadraticoMedioAnterior) > ErroMinimo) && (Ciclos < QuantidadeMaximaCiclos))
 {
     SomaErroQuadraticoCiclo = 0;
     ErroQuadraticoMedioAnterior = ErroQuadraticoMedioAtual; //o que estava armazenado no ciclo anterior

     //para cada vetor amostra de treinamento, atualizar os pesos (são 21 linhas ---> cada linha é um vetor

     for (int AmostraTreinamento = 0; AmostraTreinamento < 21; AmostraTreinamento++)
     {
         for (int NeuronioSaida = 0; NeuronioSaida < 7; NeuronioSaida++)
         {
             double sinapse = 0;

             //verificar a Saída da Rede (Teste da rede com os pesos atuais)
             for (int j = 0; j < 64; j++)
             {
                 sinapse = sinapse + (Fontes[AmostraTreinamento, j] * Pesos[NeuronioSaida, j]); // somatorio
             }

             //calculo do erro
             Erro = Saidas_Desejadas[NeuronioSaida, AmostraTreinamento] - sinapse;

             //Atualização dos pesos
             for (int j = 0; j < 64; j++)
             {
                 double DeltaW = Fontes[AmostraTreinamento, j] * Erro * TaxaAprendizagem;
                 Pesos[NeuronioSaida, j] = Pesos[NeuronioSaida, j] + DeltaW;
             }

             //calculo erro quadratico
             SomaErroQuadraticoCiclo = SomaErroQuadraticoCiclo + Math.Pow(Erro, 2);
         }//fim dos neuronios de saida
     }//fim for do vetores de treinamento

     //calcular erro quadratico medio (21 amostras)
     ErroQuadraticoMedio = SomaErroQuadraticoCiclo / 21;

     //o erro quadratico atual receber o erro que foi calculado no ciclo
     ErroQuadraticoMedioAtual = ErroQuadraticoMedio;

     Ciclos++; //incrementar ciclo

     GraficoErroQuadratico.Series[0].Points.Add(Math.Abs(ErroQuadraticoMedio));
 }//fim fo while

 QuantidadedeCiclos.Text = Ciclos.ToString();

}
private void buttonTestar_Click(object sender, EventArgs e)
{
 int[] VetorParaSerTestado = new int[64];
 int PosicaoAtual = 0;
 double Resultado;
 int Y;
 string[] Letras = new string[] { "A", "B", "C", "D", "E", "J", "K" };

 //limpar o campo do resultado do teste
 labelRespostaRede.Text = "";

 //vamos varrer toda a matriz para preencher o nosso vetor de entrada
 for (int Linha = 0; Linha < 9; Linha++)
 {
     for (int Coluna = 0; Coluna < 7; Coluna++)
     {
         string entrada = dataGridTeste.Rows[Linha].Cells[Coluna].Value.ToString();
         if (entrada == "#")
             VetorParaSerTestado[PosicaoAtual] = 1;
         else if (entrada == ".")
             VetorParaSerTestado[PosicaoAtual] = -1;
         else
         {
             VetorParaSerTestado[PosicaoAtual] = 0;
         }

         //incrementar a posição atual do vetor
         PosicaoAtual += 1;
     }//for coluna
 }//for linha

 //considerar o bias
 VetorParaSerTestado[63] = 1; //o bias é sempre 1

 //agora vamos testar o vetor de entrada
 for (int NeuronioSaida = 0; NeuronioSaida < 7; NeuronioSaida++)
 {
     Resultado = 0;
     for (int i = 0; i < 64; i++)
     {
         Resultado = Resultado + (VetorParaSerTestado[i] * Pesos[NeuronioSaida, i]);
     }

     if (Resultado >= 0)
         labelRespostaRede.Text = labelRespostaRede.Text + " " + Letras[NeuronioSaida];
 }// for neuronio Saida
}
}
}
