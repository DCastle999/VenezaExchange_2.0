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
    public partial class Broker : Form
    {
        public Ativos[] ativosCompra = new Ativos[20];
        public int contCompra = 0;
        public Ativos[] ativosVenda = new Ativos[20];
        public int contVenda = 0;
        public Broker()
        {
            InitializeComponent();
        }

        private void Broker_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
     
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipoCompra="";

            if (radioButton1.Checked)
            {
                tipoCompra = "Título";
            } else if (radioButton2.Checked)
            {
                tipoCompra = "Commodity";
            } else if(radioButton3.Checked)
            {
                tipoCompra = "Ação";
            }

            ativosCompra[contCompra] = new Ativos(tipoCompra, textBox3.Text, double.Parse(textBox1.Text), int.Parse(textBox2.Text));
            DataGridViewRow linha = (DataGridViewRow)dgvCompra.Rows[0].Clone();
            linha.Cells[0].Value = ativosCompra[contCompra].tipo;
            linha.Cells[1].Value = ativosCompra[contCompra].nomeAtivo;
            linha.Cells[2].Value = ativosCompra[contCompra].quantidade;
            linha.Cells[3].Value = ativosCompra[contCompra].valor;
            dgvCompra.Rows.Add(linha);

            comboBox1.Items.Add(ativosCompra[contCompra].nomeAtivo);

            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();

            contCompra++;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            string tipoVenda = "";

            if (rbTitulo.Checked)
            {
                tipoVenda = "Título";
            }
            else if (rbCommodity.Checked)
            {
                tipoVenda = "Commodity";
            }
            else if (rbAcao.Checked)
            {
                tipoVenda = "Ação";
            }

            ativosVenda[contVenda] = new Ativos(tipoVenda, tbNomeAtivo.Text, double.Parse(tbQuantidade.Text), int.Parse(tbValor.Text));
            DataGridViewRow linha = (DataGridViewRow)dgvVenda.Rows[0].Clone();
            linha.Cells[0].Value = ativosVenda[contVenda].tipo;
            linha.Cells[1].Value = ativosVenda[contVenda].nomeAtivo;
            linha.Cells[2].Value = ativosVenda[contVenda].quantidade;
            linha.Cells[3].Value = ativosVenda[contVenda].valor;
            dgvVenda.Rows.Add(linha);

            comboBox2.Items.Add(ativosVenda[contVenda].nomeAtivo);

            tbNomeAtivo.Clear();
            tbQuantidade.Clear();
            tbValor.Clear();

            contVenda++;
        }

        private void btVender_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < contCompra; i++)
            {
                 if (ativosCompra[i].nomeAtivo == comboBox1.SelectedItem.ToString())
                 {
                    dgvCompra.Rows.RemoveAt(i);
                    contCompra--;
                }
            }
            
        }

        private void cbCompra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btComprar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < contVenda; i++)
            {
                if (ativosVenda[i].nomeAtivo == comboBox2.SelectedItem.ToString())
                {
                    dgvVenda.Rows.RemoveAt(i);
                    contVenda--;
                }
            }
        }
    }
}
