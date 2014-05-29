using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class MyDataLayer
{
    static SqlConnection con;
    static public string ConStr
    {
        get
        {
            return @"Data Source=(local);Initial Catalog=CHLinhKienMayTinh;Integrated Security=True";
        }
    }
    static public SqlConnection Connection
    {
        get
        {
            con = new SqlConnection(ConStr);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
    }
    static public SqlCommand CreateCommand(string query, params object[] parameters)
    {
        SqlCommand cmd = new SqlCommand(query, Connection);
        for(int i=0;i<parameters.Length-1;i=i+2)
            cmd.Parameters.AddWithValue(parameters[i].ToString(),parameters[i+1]);
        return cmd;
    }
    static public SqlDataReader ExecuteReader(string query, params object[] parameters)
    {
        SqlCommand cmd = CreateCommand(query,parameters);
        return cmd.ExecuteReader();
    }
    static public int ExecuteNonQuery(string query, params object[] parameters)
    {
        SqlCommand cmd = CreateCommand(query,parameters);
        return cmd.ExecuteNonQuery();
    }
    static public object ExecuteScalar(string query, params object[] parameters)
    {
        SqlCommand cmd = CreateCommand(query,parameters);
        return cmd.ExecuteScalar();
    }
    
    static public DataTable CreateDataTable
        (string query, params object[] parameters)
    {
        DataTable t = new DataTable();
        SqlCommand cmd = CreateCommand(query, parameters);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        adapter.Fill(t);
        return t;
    }
    static public DataSet CreateDataSet
        (string query, params object[] parameters)
    {
        DataSet ds = new DataSet();
        SqlCommand cmd = CreateCommand(query, parameters);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        adapter.Fill(ds);
        return ds;
    }
    //dong ket noi:
    static public void CloseConnection()
    {
        Connection.Close();
    }
}