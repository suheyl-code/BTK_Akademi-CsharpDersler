using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        private SqlConnection _connection = new SqlConnection(@"Data Source=Asus\SQLEXPRESS;Initial Catalog=eTrade;Integrated Security=True");
        
        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);

            }
            reader.Close();
            _connection.Close();
            return products;
        }


        // Simplest version of GetAll()
        public DataTable GetAll2()
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }


        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand(
                "Insert into Products values (@name,@unitPrice,@stockAmount)", _connection);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.ExecuteNonQuery();

            _connection.Close();
        }


        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand(
                "Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _connection);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.Parameters.AddWithValue("@id", product.Id);
            sqlCommand.ExecuteNonQuery();

            _connection.Close();
        }


        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand(
                "Delete from Products where Id=@id", _connection);
            
            sqlCommand.Parameters.AddWithValue("@id",id);
            sqlCommand.ExecuteNonQuery();

            _connection.Close();
        }


        private void ConnectionControl()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}
