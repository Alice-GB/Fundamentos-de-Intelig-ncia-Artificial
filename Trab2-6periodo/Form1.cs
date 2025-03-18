using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trab2_6periodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         MATRIZ que irá armazenar as fontes
         São 21 linhas, cada uma terá uma letra que representa 63 caracteres + 1 Bias 
         Sequencia (AAABBBCCCDDDEEJJJKKK) (Fonte1, Fonte2, Fonte3)
         */

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
                    if (Letra == 1) PreencherGrid(1); // B
                    if (Letra == 2) PreencherGrid(2); // C
                    if (Letra == 3) PreencherGrid(3); // D
                    if (Letra == 4) PreencherGrid(4); // E
                    if (Letra == 5) PreencherGrid(5); // J
                    if (Letra == 6) PreencherGrid(6); // K

                }
            }

            if (Fonte == 1) // Fonte 2
            {
                {
                    if (Letra == 0) PreencherGrid(7); // A
                    if (Letra == 1) PreencherGrid(8); // B
                    if (Letra == 2) PreencherGrid(9); // C
                    if (Letra == 3) PreencherGrid(10); // D
                    if (Letra == 4) PreencherGrid(11); // E
                    if (Letra == 5) PreencherGrid(12); // J
                    if (Letra == 6) PreencherGrid(13); // K

                }
            }

            if (Fonte == 2) // Fonte 3
            {
                {
                    if (Letra == 0) PreencherGrid(14); // A
                    if (Letra == 1) PreencherGrid(15); // B
                    if (Letra == 2) PreencherGrid(16); // C
                    if (Letra == 3) PreencherGrid(17); // D
                    if (Letra == 4) PreencherGrid(18); // E
                    if (Letra == 5) PreencherGrid(19); // J
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
                    dataGridVisualizacao.Rows[Linha].Cells[Coluna].Value = "#";
                }
                else
                {
                    dataGridVisualizacao.Rows[Linha].Cells[Coluna].Value = ".";
                }

                Coluna++;
                if (Coluna == 7)
                {
                    Coluna = 0;
                    Linha++;
                }
            }
        }


            private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
