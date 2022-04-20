using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartAutomation
{
    //send to Sql, push from Sql method



    class SqlHelper
    {
        public string ConnectionString { get; set; }
        public SqlConnection sqlConnection { get; set; }

        public SqlHelper()
        {
            ConnectionString = @"Data Source = RONIN; Initial Catalog = Apartment; Integrated Security = True";
            sqlConnection = new SqlConnection(ConnectionString);
            
        }

        //data gönderme
        public void ExecuteProc(string procName, params SqlParameter[] parameters) //proceduruu çalışan method
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = procName;
            sqlCommand.Parameters.AddRange(parameters);
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }


        //dataçekme
        public DataTable GetTable(string sorgu)
        {
            SqlDataAdapter sqlDataAdapter =new SqlDataAdapter(sorgu, ConnectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

    }
}
