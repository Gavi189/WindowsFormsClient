using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibraryUser
{
    public class ConnClass
    {
        //Propriedades
        private const string Server = "TAU0712125W11-1\\SQLEXPRESS"; //Nome do Servidor
        private const string Database = "DB_Library"; //Nome do Banco de Dados
        private const string User = "senac"; //Nome do Usuário do BD
        private const string Password = "senac"; //Senha do  BD

        //String (Cadeia) de Conexão
        protected string StrConn =
            $"Data Source={Server}; " +
            $"Initial Catalog={Database}; " +
            $"User Id={User}; " +
            $"Password={Password}; " +
            $"Encrypt=False";

        //Método para conectar com Banco de Dados
        public SqlConnection GetConnection()
        {
            SqlConnection _conn = new SqlConnection(StrConn);
            return _conn;
        }
    }
}
