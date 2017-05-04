using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SmsMis.Models.Console.ApplicationBlock
{
    
        public abstract class SqlHelper
        {
            public abstract DataSet ExecuteDataset(SqlTransaction transaction, string spName, params object[] parameterValues);
            public abstract DataSet ExecuteDataset(SqlTransaction transaction, CommandType commandType, string commandText);
            public abstract DataSet ExecuteDataset(SqlConnection connection, string spName, params object[] parameterValues);
            public abstract DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText);
            public abstract DataSet ExecuteDataset(string connectionString, string spName, params object[] parameterValues);
            public abstract DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText);
            public abstract DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract DataSet ExecuteDataset(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract DataTable ExecuteDataTable(string connectionString, CommandType commandType, string commandText);
            public abstract DataTable ExecuteDataTable(string connectionString, string spName, params object[] parameterValues);
            public abstract DataTable ExecuteDataTable(SqlConnection connection, CommandType commandType, string commandText);
            public abstract DataTable ExecuteDataTable(SqlConnection connection, string spName, params object[] parameterValues);
            public abstract DataTable ExecuteDataTable(SqlTransaction transaction, CommandType commandType, string commandText);
            public abstract DataTable ExecuteDataTable(SqlTransaction transaction, string spName, params object[] parameterValues);
            public abstract DataTable ExecuteDataTable(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract DataTable ExecuteDataTable(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract DataTable ExecuteDataTable(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText);
            public abstract int ExecuteNonQuery(SqlTransaction transaction, CommandType commandType, string commandText);
            public abstract int ExecuteNonQuery(SqlConnection connection, string spName, params object[] parameterValues);
            public abstract int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText);
            public abstract int ExecuteNonQuery(string connectionString, string spName, params object[] parameterValues);
            public abstract int ExecuteNonQuery(SqlTransaction transaction, string spName, params object[] parameterValues);
            public abstract int ExecuteNonQuery(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract SqlDataReader ExecuteReader(SqlTransaction transaction, string spName, params object[] parameterValues);
            public abstract SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText);
            public abstract SqlDataReader ExecuteReader(string connectionString, string spName, params object[] parameterValues);
            public abstract SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText);
            public abstract SqlDataReader ExecuteReader(SqlTransaction transaction, CommandType commandType, string commandText);
            public abstract SqlDataReader ExecuteReader(SqlConnection connection, string spName, params object[] parameterValues);
            public abstract SqlDataReader ExecuteReader(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract object ExecuteScalar(SqlTransaction transaction, string spName, params object[] parameterValues);
            public abstract object ExecuteScalar(SqlConnection connection, string spName, params object[] parameterValues);
            public abstract object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText);
            public abstract object ExecuteScalar(SqlTransaction transaction, CommandType commandType, string commandText);
            public abstract object ExecuteScalar(string connectionString, CommandType commandType, string commandText);
            public abstract object ExecuteScalar(string connectionString, string spName, params object[] parameterValues);
            public abstract object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract object ExecuteScalar(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract object ExecuteScalar(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract XmlReader ExecuteXmlReader(SqlConnection connection, CommandType commandType, string commandText);
            public abstract XmlReader ExecuteXmlReader(SqlConnection connection, string spName, params object[] parameterValues);
            public abstract XmlReader ExecuteXmlReader(SqlTransaction transaction, CommandType commandType, string commandText);
            public abstract XmlReader ExecuteXmlReader(SqlTransaction transaction, string spName, params object[] parameterValues);
            public abstract XmlReader ExecuteXmlReader(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters);
            public abstract XmlReader ExecuteXmlReader(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters);

        }
    }
