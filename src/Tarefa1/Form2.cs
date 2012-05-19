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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularAnoBissexto();
        }

        public void CalcularAnoBissexto()
        {
            var ano = Convert.ToInt32(textBox1.Text);

            if (ano % 4 == 0 && ano % 400 == 0)
                MessageBox.Show("É ano Bisssexto", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Não é ano Bisssexto", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
