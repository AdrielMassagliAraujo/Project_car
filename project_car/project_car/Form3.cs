using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_car
{
    public partial class frmcami : Form
    {
        Caminhao caminhao;

        public frmcami()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frminicial inicial = new frminicial();
            this.Hide();
            inicial.Show();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            caminhao = new Caminhao(txtmarca.Text, 
                                    txtmodel.Text, 
                                    txtcha.Text, 
                                    (Convert.ToInt32(txtkm.Text)), 
                                    txtcor.Text, 
                                    (Convert.ToInt32(txtano.Text)), 
                                    txtplaca.Text, 
                                    txtcapaci.Text, 
                                    txtbau.Text, 
                                    txtcarga.Text, 
                                    txtcabine.Text, 
                                    (Convert.ToInt32(txtrodas.Text)));

            txtmarca.Clear();
            txtmodel.Clear();
            txtcha.Clear();
            txtkm.Clear();
            txtcor.Clear();
            txtano.Clear();
            txtplaca.Clear();
            txtcapaci.Clear();
            txtbau.Clear();
            txtcarga.Clear();
            txtcabine.Clear();
            txtrodas.Clear();
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.Dados());
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtmarca.Clear();
            txtmodel.Clear();
            txtcha.Clear();
            txtkm.Clear();
            txtcor.Clear();
            txtano.Clear();
            txtplaca.Clear();
            txtcapaci.Clear();
            txtbau.Clear();
            txtcarga.Clear();
            txtcabine.Clear();
            txtrodas.Clear();   
        }

        private void frmcami_Load(object sender, EventArgs e)
        {

        }
    }
}
