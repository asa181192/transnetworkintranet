using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace intranet
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            fllDropDownServer();
            // GridviewData.DataSource = ds;
            //GridviewData.DataBind();

        }




        private void fllDropDownServer()
        {
            
            List<string> Servidores = new List<string>();
            SqlConexion myconexion = new SqlConexion();
            Servidores = myconexion.consulta("SELECT DISTINCT nombreServidor FROM DevServices ");
            for (int i = 0; i < Servidores.Count; i++)
            {
                if (DropDownServer.Items.FindByText(Servidores[i]) == null)
                {
                   
                    DropDownServer.Items.Add(Servidores[i]);
                }


            }
           
        }

        protected void GridviewData_DataBound(object sender, GridViewRowEventArgs e)
        {
                if (e.Row.RowType == DataControlRowType.DataRow) {
             

                               string respaldo = DataBinder.Eval(e.Row.DataItem,"ServidorRespaldo").ToString();
                               string tipoServidor = DataBinder.Eval(e.Row.DataItem,"TipoServidor").ToString();
                
                               if(tipoServidor=="Operativo" && respaldo=="") {
                                    e.Row.BackColor = System.Drawing.Color.Maroon;
                                    e.Row.ForeColor = System.Drawing.Color.White;
                                    e.Row.Font.Bold = true;
                               }
                
                           }
        }
      
        



        protected void Button1_Click(object sender, EventArgs e)
        {

            if (busqueda.Text != "")
            {
                GridviewData.UseAccessibleHeader = true;

                string Configuration = WebConfigurationManager.ConnectionStrings["Servicios"].ConnectionString;//"Data Source=lab-sql4;Initial Catalog=Services;User ID=asantiago;Password=asantiago";
                string query = "SELECT nombreServidor AS Servidor,nombreServicio AS Servicio,estatusServicio AS Estatus ,modoInicio AS Inicio ,LogonServicio AS Cuenta ,tipoServidor AS TipoServidor,servidorRespaldo AS ServidorRespaldo FROM DevServices WHERE nombreServicio= '" + busqueda.Text + "'";
                SqlConnection con = new SqlConnection(Configuration);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "DevServices");
                GridviewData.DataSource = ds;
                GridviewData.DataBind();
                busqueda.Text = "";
                
            }
            else
            {

                if (DropDownServer.SelectedItem.Text == "Todos")
                {

                    GridviewData.UseAccessibleHeader = true;

                    string Configuration = WebConfigurationManager.ConnectionStrings["Servicios"].ConnectionString;//"Data Source=lab-sql4;Initial Catalog=Services;User ID=asantiago;Password=asantiago";
                    string query = "SELECT nombreServidor AS Servidor,nombreServicio AS Servicio,estatusServicio AS Estatus ,modoInicio AS Inicio ,LogonServicio AS Cuenta ,tipoServidor AS TipoServidor,servidorRespaldo AS ServidorRespaldo FROM DevServices ";
                    SqlConnection con = new SqlConnection(Configuration);
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "DevServices");
                    GridviewData.DataSource = ds;
                    GridviewData.DataBind();
                }

                else
                {


                    GridviewData.UseAccessibleHeader = true;

                    string Configuration = WebConfigurationManager.ConnectionStrings["Servicios"].ConnectionString;// "Data Source=lab-sql4;Initial Catalog=Services;User ID=asantiago;Password=asantiago";
                    string query = "SELECT nombreServidor AS Servidor,nombreServicio AS Servicio,estatusServicio AS Estatus ,modoInicio AS Inicio ,LogonServicio AS Cuenta ,tipoServidor AS TipoServidor,servidorRespaldo AS ServidorRespaldo FROM DevServices WHERE nombreServidor= '" + DropDownServer.SelectedValue + "'";
                    SqlConnection con = new SqlConnection(Configuration);
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "DevServices");
                    GridviewData.DataSource = ds;
                    GridviewData.DataBind();
                }
                   
            }

        


        }
    }
}