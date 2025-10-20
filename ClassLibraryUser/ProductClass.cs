using System;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryUser
{
    public class ProductClass
    {
        public int Id_Product { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }

        private ConnClass _conn = new ConnClass();

        public ProductClass(int id, string name, string description, double price, bool status)
        {
            Id_Product = id;
            Name = name;
            Description = description;
            Price = price;
            Status = status;
        }

        public DataTable ProductSearch(string search)
        {
            var dt = new DataTable();
            string sql = @"SELECT id_Product, Name, Description, Price, Status 
                           FROM Product 
                           WHERE Name LIKE @Name";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Name", $"%{search}%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dt;
        }

        public bool Registrar()
        {
            string sql = @"INSERT INTO Product (Name, Description, Price, Status) 
                           VALUES (@Name, @Description, @Price, @Status)";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Description", Description ?? "");
                        cmd.Parameters.AddWithValue("@Price", Price);
                        cmd.Parameters.AddWithValue("@Status", Status);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Atualizar()
        {
            string sql = @"UPDATE Product 
                           SET Name=@Name, Description=@Description, Price=@Price, Status=@Status
                           WHERE id_Product=@IdProduct";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@IdProduct", Id_Product);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Description", Description ?? "");
                        cmd.Parameters.AddWithValue("@Price", Price);
                        cmd.Parameters.AddWithValue("@Status", Status);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Remover()
        {
            string sql = @"DELETE FROM Product WHERE id_Product=@IdProduct";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@IdProduct", Id_Product);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
