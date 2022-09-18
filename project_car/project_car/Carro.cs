using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_car
{
    public class Carro : Veiculo
    {
        private string capacidade;
        private int numporta;
        private string carroceria;

        public Carro()
        {
            this.capacidade = null;
            this.numporta = 0;
            this.carroceria = null;
        }

        public Carro(string marca, string modelo, string chassi, int quilometragem, string cor, int ano, string placa, string capacidade, int numporta, string carroceria)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Chassi = chassi;
            this.Quilometragem = quilometragem;
            this.Cor = cor;
            this.Ano = ano;
            this.Placa = placa;
            this.capacidade = capacidade;
            this.numporta = numporta;
            this.carroceria = carroceria;
        }

        public string Capacidade
        {
            get { return capacidade; }  
            set { capacidade = value; }
        }

        public int Numporta
        {
            get { return numporta; }
            set { numporta = value; }
        }

        public string Carroceria
        {
            get { return carroceria; }
            set { carroceria = value; }
        }

        public override string Dados()
        {
            String s = String.Empty;
              s = String.Concat("Marca: ", this.Marca, "\r\n",
                                "Modelos: ", this.Modelo, "\r\n", 
                                "Chassi: ", this.Chassi, "\r\n",
                                "Quilometragem: ", this.Quilometragem.ToString(), "\r\n",
                                "Cor: ", this.Cor, "\r\n",
                                "Ano: ", this.Ano, "\r\n",
                                "Placa: ", this.Placa, "\r\n",
                                "Capacidade: ", this.Capacidade, "\r\n",
                                "Número de portas: ", this.Numporta.ToString(), "\r\n",
                                "Tipo de Carroceria: ", this.Carroceria, "\r\n");
            return s;   
        }
    }
}
