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
    public partial class frminicial : Form
    {
        public frminicial()
        {
            InitializeComponent();
        }

        private void btncami_Click(object sender, EventArgs e)
        {
            frmcami caminhao = new frmcami();
            this.Hide();
            caminhao.Show();
        }

        private void btncar_Click(object sender, EventArgs e)
        {
            frmcarro carro = new frmcarro();
            this.Hide();
            carro.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frminicial_Load(object sender, EventArgs e)
        {

        }
    }
}
