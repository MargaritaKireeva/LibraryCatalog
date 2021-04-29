using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using DAO_Interface;

namespace DAO
{
    public class Element_DAO : IElement_DAO_Interface
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public void AddBookInFund(Element value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddBookInFund";
                cmd.Parameters.AddWithValue(@"BookName", value.name);
                cmd.Parameters.AddWithValue(@"Author", value.author);
                cmd.Parameters.AddWithValue(@"FundName", value.fundName);
                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "ID_Book",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();

            }
        }
        public IEnumerable<Element> GetAllBooks()
        {
            List<Element> books = new List<Element>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetListAllBooks";
                connection.Open();

                var reader = cmd.ExecuteReader();
                Element element;
                while (reader.Read())
                {
                    if ((string)reader["Author"] == null)
                    {
                        element = new Periodical((string)reader["BookName"], (string)reader["FundName"]);
                        books.Add(element); 
                    }
                    else
                    {
                        element = new Book((string)reader["Author"], (string)reader["BookName"], (string)reader["FundName"]);
                        books.Add(element);
                    }
                }

            }
            return books;
        }

        public void DeleteBookInFund(Element element, string FundName)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteBookInFund";
                cmd.Parameters.AddWithValue(@"BookName", element.name);
                cmd.Parameters.AddWithValue(@"FundName", FundName);
                connection.Open();


                cmd.ExecuteNonQuery();


            }

        }
        public IEnumerable<Element> GetAllBooksInFund(string FundName)
        {
            List<Element> books = new List<Element>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetListBooksInFund";
                cmd.Parameters.AddWithValue(@"FundName", FundName);
                connection.Open();

                var reader = cmd.ExecuteReader();
                Element element;
                while (reader.Read())
                {
                    if ((string)reader["Author"] == null)
                    {
                        element = new Periodical((string)reader["BookName"], (string)reader["FundName"]);
                        books.Add(element);
                    }
                    else
                    {
                        element = new Book((string)reader["Author"], (string)reader["BookName"], (string)reader["FundName"]);
                        books.Add(element);
                    }
                }

            }
            return books;
        }
        public IEnumerable<Element> GetAllBooksByAuthor(string author)
        {
            List<Element> books = new List<Element>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetListBooksByAuthor";
                cmd.Parameters.AddWithValue(@"Author", author);
                connection.Open();

                var reader = cmd.ExecuteReader();
                Element element;
                while (reader.Read())
                {
                    element = new Book((string)reader["Author"], (string)reader["BookName"], (string)reader["FundName"]);
                    books.Add(element);
                }

            }
            return books;
        }
        public IEnumerable<Element> GetAllBooksByAuthorInFund(string author, string fundName)
        {
            List<Element> books = new List<Element>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetListBooksByAuthor";
                cmd.Parameters.AddWithValue(@"Author", author);
                cmd.Parameters.AddWithValue(@"FundName", fundName);
                connection.Open();

                var reader = cmd.ExecuteReader();
                Element element;
                while (reader.Read())
                {
                    element = new Book((string)reader["Author"], (string)reader["BookName"], (string)reader["FundName"]);
                    books.Add(element);
                }

            }
            return books;
        }
    }
}
