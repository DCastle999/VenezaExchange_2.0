using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenexaExchangeForm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btCompra_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            compra.Show();
        }

        private void btVender_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            venda.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
