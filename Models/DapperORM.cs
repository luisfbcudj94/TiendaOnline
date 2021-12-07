using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace WebProductos.Models
{
    public static class DapperORM
    {
        private static string connectionString = "Server=LAPTOP-L5O4K4UI\\SQLEXPRESS;Database=Productos;User ID=prueba; Password=3004640303";

        public static void ExecuteWithoutReturn(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }


        public static IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }


        public static T ExecuteWithoutReturnScalar<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return (T) Convert.ChangeType(sqlCon.ExecuteScalar(procedureName, param, commandType: 
                    System.Data.CommandType.StoredProcedure),typeof(T));
            }
        }
            
        
    }

}
