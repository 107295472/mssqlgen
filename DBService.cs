using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实体生成器
{
    public class DBService
    {
        public string Connonection = string.Empty;

        /// <summary>
        /// 取所有数据库名
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllDataBase()
        {
            SqlConnection Connection = new SqlConnection(Connonection);
            DataTable DBNameTable = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("select name from master..sysdatabases", Connection);

            lock (Adapter)
            {
                Adapter.Fill(DBNameTable);
            }
            List<string> names = new List<string>();
            foreach (DataRow row in DBNameTable.Rows)
            {
                names.Add(row["name"].ToString());
            }

            return names;
        }

        /// <summary>
        /// 获取所有表名
        /// </summary>
        /// <returns></returns>
        public IList<string> GetTableNames(string a)
        {
            List<string> tableName = new List<string>();
            SqlConnection connection = new SqlConnection(Connonection);

            string sqlCommandString = @"USE [" + a + "] SELECT name FROM sys.sysobjects WHERE type='U'or type='v' ORDER BY name";
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sqlCommandString;
            command.Connection = connection;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tableName.Add(reader[@"name"].ToString());
            }
            return tableName;
        }

        /// <summary>
        /// 获取表结构
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public List<Field> GetFileds(string tableName)
        {
            List<Field> _Fields = new List<Field>();
            SqlConnection _Connection = new SqlConnection(Connonection);
            try
            {
                _Connection.Open();

                string[] restrictionValues = new string[4];
                restrictionValues[0] = null; // Catalog
                restrictionValues[1] = null; // Owner
                restrictionValues[2] = tableName; // Table
                restrictionValues[3] = null; // Column

                using (DataTable dt = _Connection.GetSchema(SqlClientMetaDataCollectionNames.Columns, restrictionValues))
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Field field;
                        field.Name = dr["column_name"].ToString();
                        field.Type = dr["data_type"].ToString();
                        _Fields.Add(field);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _Connection.Dispose();
            }

            return _Fields;
        }
        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public DataTable Query(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(Connonection))
            {
                DataTable ds = new DataTable();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(ds);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }

    }
    public struct Field
    {
        public string Name;
        public string Type;
    }
}
