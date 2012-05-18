using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarefa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] valores = {10, 5, 6, 3, 8, 33, 25, 78, 99, 45, 23, 67, 88};

            int quantidade = 0;
            double soma = 0;
            int menorValor = 100;
            int maiorValor = 1;
            double media = 0;
            
            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
                quantidade = valores.Length;

                if (valores[i] < menorValor)
                    menorValor = valores[i];

                if (valores[i] > maiorValor)
                    maiorValor = valores[i];
            }

            media = soma / quantidade;


            label1.Text += "Quantidade de elementos: " + quantidade + "\n";
            
            label1.Text += "Soma dos elementos: " + soma + "\n";

            label1.Text += "Menor valor: " + menorValor + "\n";

            label1.Text += "Maior valor: " + maiorValor + "\n";

            label1.Text += "Média: " + media + "\n";


        }
    }
}
