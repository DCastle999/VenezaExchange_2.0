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
    public partial class Venda : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Veneza_Exchange; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

        public Venda()
        {
            InitializeComponent();
        }

        private void lbAtivo_Click(object sender, EventArgs e)
        {

        }

        private void cbAtivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Conexão con = new Conexão();

            cmd.CommandText = "insert into vendas ( tipo_ativo, nome_ativo, quantidade, valor) values (@tipo, @nome, @quantidade, @valor)";
            cmd.Parameters.AddWithValue("@tipo", cbAtivos.Text);
            cmd.Parameters.AddWithValue("@nome", textBox2.Text);
            cmd.Parameters.AddWithValue("@quantidade", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@valor", Double.Parse(textBox1.Text));

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                MessageBox.Show("Opção de venda adicionada!");
              //  tem = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro com o banco de dados");
            }
        }

        private void Venda_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT ID, tipo_ativo AS 'Tipo do Ativo', nome_ativo AS 'Nome do Ativo', quantidade AS Quantidade, valor AS 'Valor Unitário' FROM compras";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dataGridView1.DataSource = dt;
                    }
                }

                using (var command = new SqlCommand("SELECT CAST(id AS VARCHAR(4)) FROM compras", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("DELETE FROM compras WHERE id=@id", connection))
                {
                    command.Parameters.AddWithValue("@id", int.Parse(comboBox2.Text));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                       MessageBox.Show("Venda realizada!");
                        
                    }
                    else
                    {
                        MessageBox.Show("Item não encontrado.");
                    }

                    
                }
            }
            this.Close();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
