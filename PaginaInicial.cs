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
    public partial class PaginaInicial : Form
    {
        Cadastro c = new Cadastro();
        Broker b = new Broker();
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAtivos_Click(object sender, EventArgs e)
        {
            b.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = c.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtusuario_Click(object sender, EventArgs e)
        {
            Controle controle= new Controle();
            controle.acessar(textBox3.Text, textBox4.Text);
            if (controle.menssagem.Equals(""))
            {

            
                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    Menu m = new Menu();
                    m.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario não encontrado", "ERRO!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.menssagem);
            }
        }
    }
}
