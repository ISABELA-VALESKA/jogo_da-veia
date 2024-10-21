using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Form1 : Form
    {
        int vezes = 0;
        char[,] matriz = new char[3, 3];
        public Form1()
        {
            InitializeComponent();

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            lblJogo.Text = " ";

            int coluna = int.Parse(txtColuna.Text) - 1;
            int linha = int.Parse(txtLinha.Text) - 1;
            char jogador;

            if (coluna > 2 || linha > 2 || coluna < 0 || linha < 0)
            {
                MessageBox.Show("Por favor, digite um valor válido!", "AVISO!");

            }
            if (matriz[linha, coluna] == 'X' || matriz[linha, coluna] == 'O')
            {
                MessageBox.Show("A célula já está ocupada! Escolha outra.", "AVISO!");
                return; 
            }
            if (vezes % 2 == 0)
            {
                jogador = 'X';

            }
            else
            {
                jogador = 'O';
            }
                    vezes++;

                    lblJogador.Text = jogador.ToString();

                    matriz[linha, coluna] = jogador;

                    if (vezes > 5)
                    {
                        if (matriz[0, 0] == jogador && matriz[1, 1] == jogador && matriz[2, 2] == jogador)
                        {
                            lblResultado.Text = jogador.ToString();
                        }
                        else if (matriz[2, 0] == jogador && matriz[1, 1] == jogador && matriz[0, 2] == jogador)
                        {
                            lblResultado.Text = jogador.ToString();
                        }
                        else {
                            for (int i = 0; i < 3; i++)
                            {
                                if (matriz[i, 0] == jogador && matriz[i, 1] == jogador && matriz[i, 2] == jogador)
                                {
                                    lblResultado.Text = jogador.ToString();
                                }
                                else if (matriz[0, i] == jogador && matriz[1, i] == jogador && matriz[2, i] == jogador)
                                {
                                    lblResultado.Text = jogador.ToString();
                                }
                            }
                        }
                    }
                
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i,j] == 'X'|| matriz[i, j] == 'O')
                    {
                        lblJogo.Text += matriz[i, j] + " ";
                    }
                    else
                    {
                        lblJogo.Text +=  "   ";
                    }
                    
                }

                lblJogo.Text += "\n";


            }


            if (vezes % 2 == 0)
            {
                jogador = 'X';

            }
            else
            {
                jogador = 'O';
            }

            lblJogador.Text = jogador.ToString();



        }

        private void limpa_Click(object sender, EventArgs e)
        {
            txtColuna.Clear();
            txtLinha.Clear();

        }
    }
}
