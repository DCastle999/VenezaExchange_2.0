using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenexaExchangeForm
{
    public class Conexão
    {
        SqlConnection con = new SqlConnection();

        public Conexão()
        {
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Veneza_Exchange; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;

        }

        public SqlConnection desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }

    }
}
