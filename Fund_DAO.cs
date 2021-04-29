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
    public class Fund_DAO : IFund_DAO_Interface
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public void AddFund(Fund value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddFund";
                cmd.Parameters.AddWithValue(@"FundName", value.FundName);
                connection.Open();
                cmd.ExecuteNonQuery();

            }
        }
        public IEnumerable<Fund> GetAllFunds()
        {
            List<Fund> funds = new List<Fund>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetListFunds";
                connection.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    funds.Add(new Fund
                    {
                        FundName = (string)reader["FundName"],
                    });
                }

            }
            return funds;
        }

        public void DeleteFund(string FundName)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteFund";
                cmd.Parameters.AddWithValue(@"FundName", FundName);
                connection.Open();


                cmd.ExecuteNonQuery();


            }

        }
    }
}