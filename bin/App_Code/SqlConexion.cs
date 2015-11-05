using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Configuration;
/// <summary>
/// Summary description for SqlConexion
/// </summary>
public class SqlConexion
{
    private string connect;
    SqlConnection myConnection;
    SqlCommand cmd;
    private int added = 0;
    public SqlConexion()
    {

<<<<<<< HEAD
        connect = WebConfigurationManager.ConnectionStrings["Servicios"].ConnectionString;//"Data Source=lab-sql4;Initial Catalog=Services;User ID=asantiago;Password=asantiago";
=======
        connect = "Data Source=lab-sql4;Initial Catalog=Services;User ID=asantiago;Password=asantiago";
>>>>>>> f36bcf2c225bc90834ef178e5a9bdf53bad3bac5
        myConnection = new SqlConnection(connect);
        cmd = new SqlCommand();

    }

    public void SqlInsert(string query) //Recive un parametro el cual es un query para ejecutar la insctruccion insert .
    {
        cmd.Connection = myConnection;
        cmd.CommandText = query;
        myConnection.Open();
        if (query != null)
        { // ser verifica que el query ingresado no sea una variable nula 
            try
            {

                added = cmd.ExecuteNonQuery();

                if (added > 0)
                {
                    Console.WriteLine("Agregado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

    }

    public List<string> consulta(string query)
    {
        List<string> data = new List<string>();
        cmd.Connection = myConnection;
        cmd.CommandText = query;
        SqlDataReader reader;
        try
        {
            myConnection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string item = (string)reader["nombreServidor"];
                data.Add(item);
            }
            myConnection.Close();
            return data;
        }
        catch (Exception ex)
        {

            return null;
        }




    }


}