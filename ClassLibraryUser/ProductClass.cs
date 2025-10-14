using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUser
{
    public class ProductClass
    {
        //Propriedades
        private int Id_Product { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private double Price { get; set; }
        private bool Status { get; set; }

        private ConnClass _conn = new ConnClass();

        //Construtor
        public ProductClass(int _id, string _name, string _description, double _price, bool _status)
        {
            this.Id_Product = _id;
            this.Name = _name;
            this.Description = _description;
            this.Price = _price;
            this.Status = _status;
        }

        //Métodos
        //CRUD Read = Select -> Pesquisar
        public DataTable ProductSearch(string name, string description)//C#
        {
            //DataTable dt = new DataTable(); && = AND e || = OR
            var dt = new DataTable();// var similar VARCHAR variável temporário
            string sql = "SELECT * FROM Product WHERE Name LIKE @Name OR Description LIKE @Description;";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Name", $"% {name} %");
                        cmd.Parameters.AddWithValue("@Description", "%" + description + "%");

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            return dt;
        }

        //Function to Admin
        //CRUD Creat = Insert
        public bool Registrar()
        {
            string sql = "INSERT INTO Product (Name, Description, Price, Status) VALUES (@Name, @Description, @Price, @Status);";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Name", this.Name);
                        cmd.Parameters.AddWithValue("@Description", this.Description);
                        cmd.Parameters.AddWithValue("@Price", this.Price);
                        cmd.Parameters.AddWithValue("@Status", this.Status);


                        //Execucção da instrução de Transação de Dados (DML)
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                return false;
            }

        }

        //Function to Admin
        //CRUD Update = Atualização
        public bool Atualizar()
        {
            string sql = "UPDATE Product SET Name=@Name,Description=@Description,Price=@Price, Status=@Status WHERE id_Product=@IdProduct;";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@IdProduct", this.Id_Product);
                        cmd.Parameters.AddWithValue("@Name", this.Name);
                        cmd.Parameters.AddWithValue("@Description", this.Description);
                        cmd.Parameters.AddWithValue("@Price", this.Price);
                        cmd.Parameters.AddWithValue("@Status", this.Status);

                        //Execucção da instrução de Transação de Dados (DML)
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                return false;
            }
        }

        //Function to Admin
        //CRUD Delete = Remoção
        public bool Remover()
        {
            string sql = "DELETE FROM Product WHERE id_Product=@IdProduct;";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@IdProduct", this.Id_Product);

                        //Execucção da instrução de Transação de Dados (DML)
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                return false;
            }
        }
    }
}
