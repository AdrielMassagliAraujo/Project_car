using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace project_car
{
    public partial class frmcarro : Form
    {
        Carro carro;

        public frmcarro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frminicial inicial = new frminicial();
            this.Hide();
            inicial.Show();

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.Dados());   
        }

        private void btncad_Click(object sender, EventArgs e)
        {
              carro = new Carro(txtmarca.Text,
                                txtmodel.Text , 
                                txtcha.Text , 
                                (Convert.ToInt32(txtkm.Text)), 
                                txtcor.Text, 
                                (Convert.ToInt32(txtano.Text)), 
                                txtplaca.Text, 
                                txtbag.Text, 
                                (Convert.ToInt32(txtportas.Text)), 
                                txtcarroceria.Text);

            txtmarca.Clear();
            txtmodel.Clear();
            txtcha.Clear();
            txtkm.Clear();
            txtcor.Clear();
            txtano.Clear();
            txtplaca.Clear();
            txtbag.Clear();
            txtportas.Clear();
            txtcarroceria.Clear();
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
            txtbag.Clear();
            txtportas.Clear();
            txtcarroceria.Clear();
        }
    }
}
