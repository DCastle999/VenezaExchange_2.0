using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenexaExchangeForm
{
    public partial class Cadastro : Form
    {
        Broker b = new Broker();
        public Cadastro()
        {
            InitializeComponent();
        }
        private string menssagem;

        private void btProx_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            menssagem = controle.cadastrar(txtnome.Text, txtsenha.Text, txtconfirmarsenha.Text);
            if (controle.tem)
            {
                MessageBox.Show(menssagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(menssagem);
            }
            Close();
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
