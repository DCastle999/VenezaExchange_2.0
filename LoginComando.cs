using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenexaExchangeForm
{
    internal class LoginComando
    {
        public bool tem = false;
        public string menssagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexão con = new Conexão();
        SqlDataReader dr;
        public bool verificarlogin(string usuario, string senha)
        {
            cmd.CommandText = "Select * from contas where usuario = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.menssagem = "Erro com o banco de Dados!";
            }

            return tem;

        }
        public string cadastrar(string usuario, string senha, string confirmarsenha) 
        {
            tem= false;
            if (senha.Equals(confirmarsenha))
            {
                cmd.CommandText = "insert into contas (usuario, senha) values (@u,@s);";
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@s", senha);
                try
                {
                    cmd.Connection=con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.menssagem = "Cadastrado com sucesso";
                    tem = true;
                }
                catch(SqlException)
                {
                    this.menssagem = "Erro com o banco de dados";
                }
            }
            else {
                this.menssagem = "Senhas não correspondem";
            }
            return menssagem;
        }
        public string cadastrar()
        {
            return "";
        }
    }
}
