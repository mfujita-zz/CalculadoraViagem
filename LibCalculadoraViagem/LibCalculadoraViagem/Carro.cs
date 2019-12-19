using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraViagem
{
    public class Carro
    {
        private double distancia;
        private double preco;
        private double[] rendimento;
        private double[] capacidade;
        private double[] custo;
        private double[] reabastecimento;

        public Carro(double _d, double _p)
        {
            distancia = _d;
            preco = _p;

            rendimento = new double[2];
            capacidade = new double[2];
            rendimento[0] = 12.8; // carro1
            rendimento[1] = 10.7; // carro2
            capacidade[0] = 25; //carro1
            capacidade[1] = 30; //carro2
        }

        public double[] CalculoCusto()
        {
            custo = new double[2];
            for (int i = 0; i < custo.Length; i++)
            {
                custo[i] = (distancia / rendimento[i]) * preco;
            }
            return custo;
        }

        public double[] CalculoQuantidadeReabastecimento()
        {
            reabastecimento = new double[2];
            for (int i = 0; i < reabastecimento.Length; i++)
            {
                reabastecimento[i] = distancia / (capacidade[i] * rendimento[i]);
            }
            return reabastecimento;
        }
    }
}
