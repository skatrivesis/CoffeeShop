using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class DAL
    {
        SqlConnection connection;

        public DAL(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }
        public IEnumerable<Product> GetProductCategories()
        {
            string queryString = "SELECT DISTINCT Category FROM Products";
            IEnumerable<Product> Products = connection.Query<Product>(queryString);

            return Products;
        }

        public IEnumerable<Product> GetProductsAll()
        {
            string queryString = "SELECT * FROM Products";
            IEnumerable<Product> Products = connection.Query<Product>(queryString);

            return Products;
        }

        public int DeleteProductById(int id)
        {
            string deleteString = "DELETE FROM Products WHERE Id = @val";
            return connection.Execute(deleteString, new { val = id });
        }

        public int CreateProduct(Product prod)
        {
            string addString = "INSERT INTO Products (Name, Price, Description, Category, Origin) VALUES (@Name, @Price, @Description, @Category, @Origin)";

            return connection.Execute(addString, prod);
        }

        public int UpdateProductById(Product prod)
        {
            string updateString = "UPDATE Products SET Name = @Name, Price = @Price, Description = @Description, Category = @Category, Origin = @Origin WHERE Id = @Id";

            return connection.Execute(updateString, prod);        
        }

        public Product GetProductById(int id)
        {
            string queryString = "SELECT * FROM Products WHERE Id = @val";
            Product prod = connection.QueryFirstOrDefault<Product>(queryString, new { val = id });

            return prod;
        }
    }
}
