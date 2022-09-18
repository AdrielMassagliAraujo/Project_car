using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_car
{
    public abstract class Veiculo
    {
        private string marca;
        private string modelo;
        private string chassi;
        private int quilometragem;
        private string cor;
        private int ano;
        private string placa;

        public Veiculo()
        {
            this.marca = null;
            this.modelo = null;
            this.chassi = null;
            this.quilometragem = 0;
            this.cor = null;
            this.ano = 0;
            this.placa = null;
        }

        public Veiculo(string marca, string modelo, string chassi, int quilometragem, string cor, int ano, string placa)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.chassi = chassi;
            this.quilometragem = quilometragem;
            this.cor = cor;
            this.ano = ano;
            this.placa = placa;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Chassi
        {
            get { return chassi; }
            set { chassi = value; }
        }

        public int Quilometragem
        {
            get { return quilometragem; }
            set { quilometragem = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value;  }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public abstract String Dados();
    }




}
