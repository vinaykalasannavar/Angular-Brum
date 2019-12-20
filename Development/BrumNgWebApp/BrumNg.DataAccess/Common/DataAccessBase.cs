
using System;
using System.Data;
using System.Data.SqlClient;

namespace BrumNg.DataAccess.Common
{
    public class DataAccessBase
    {
        protected string ConnectionString;

        public DataAccessBase()
        {
            ConnectionString = @"Data Source=DESKTOP-N3A5DFE;Initial Catalog=NgBrumDb;Integrated Security=true;";
        }

        protected T PerformDataOperation<T>(string sprocName, Func<SqlDataReader, T> readData, SqlParameter[] sqlParameters = null)
        {
            T requiredData = default(T);

            //SqlParameter[] sqlParameters = new SqlParameter[];

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sprocName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    if (sqlParameters != null)
                    {
                        command.Parameters.AddRange(sqlParameters);
                    }

                    var rdr = command.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        requiredData = readData(rdr);
                    }

                    connection.Close();
                }
            }

            return requiredData;
        }
    }
}
