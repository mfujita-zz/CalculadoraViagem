using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraViagemWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double dist = Convert.ToDouble(txtDistancia.Text);
            double preco = Convert.ToDouble(txtPreco.Text);
            CalculadoraViagem.Carro carro = new CalculadoraViagem.Carro(dist, preco);
            double[] custo = carro.CalculoCusto();
            double[] reab = carro.CalculoQuantidadeReabastecimento();

            for (int i = 0; i < custo.Length; i++)
            {
                txtSaida.Text += "carro " + (i+1) + "  " + custo[i] + "\r\n";
            }

            for (int i = 0; i < reab.Length; i++)
            {
                txtSaida.Text += "carro " + (i+1) + "   " + reab[i] + "\r\n";
            }
        }
    }
}
