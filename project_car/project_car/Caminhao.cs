using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_car
{
    public class Caminhao : Veiculo
    {
        private string capacid;
        private string bau;
        private string tipocarga;
        private string tipocabine;
        private int qtdrodas;

        public Caminhao()
        {
            this.capacid = null;
            this.bau = null;
            this.tipocarga = null;
            this.tipocabine = null;
            this.qtdrodas = 0;
        }

        public Caminhao(string marca, string modelo, string chassi, int quilometragem, string cor, int ano, string placa, string capacid, string bau, string tipocarga, string tipocabine, int qtdrodas)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Chassi = chassi;
            this.Quilometragem = quilometragem;
            this.Cor = cor;
            this.Ano = ano;
            this.Placa = placa;
            this.capacid = capacid;
            this.bau = bau;
            this.tipocarga = tipocarga;
            this.tipocabine = tipocabine;
            this.qtdrodas = qtdrodas;
        }

        public string Capacid
        {
            get { return capacid; }
            set { capacid = value; }
        }

        public string Bau
        {
            get { return bau; }
            set { bau = value; }
        }

        public string Tipocarga
        {
            get { return tipocarga; }
            set { tipocarga = value; }
        }

        public string Tipocabine
        {
            get { return tipocabine; }
            set { tipocabine = value; }
        }

        public int Qtdrodas
        {
            get { return qtdrodas; }
            set { qtdrodas = value; }
        }

        public override string Dados()
        {
            String s = String.Empty;
              s = String.Concat("Marca: ", this.Marca, "\r\n",
                                "Modelo: ", this.Modelo, "\r\n",
                                "Chassi: ", this.Chassi, "\r\n",
                                "Quilometragem: ", this.Quilometragem.ToString(), "\r\n",
                                "Cor: ", this.Cor, "\r\n",
                                "Ano: ", this.Ano, "\r\n",
                                "Placa: ", this.Placa, "\r\n",
                                "Capacidade: ", this.Capacid, "\r\n",
                                "Baú", this.Bau, "\r\n",
                                "Tipo de Carga: ", this.Tipocarga, "\r\n",
                                "Tipo de Cabine: ", this.Tipocabine, "\r\n",
                                "Quantidade de Rodas", this.Qtdrodas, "\r\n");
            return s;
        }

    }
}
