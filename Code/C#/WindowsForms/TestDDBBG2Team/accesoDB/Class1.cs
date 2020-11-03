using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;

namespace accesoDB
{
    public class Class1
    {

        private string connectionString;
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        String query;
        DataSet dts;

        public Class1()
        {
            connectionString = ConfigurationManager.ConnectionStrings["TestDDBBG2Team.Properties.Settings.SecureCoreConnectionString"].ConnectionString;
        }


        private void conectar(String query)
        {
            conexion = new SqlConnection(connectionString);
            if (query != null && query != "")
            {
              adaptador = new SqlDataAdapter(query, conexion);
              if (conexion.State == ConnectionState.Closed) conexion.Open();
            }
        }

        public DataTable traerporconsulta(String consulta) 
        {
            dts = new DataSet();
            query = consulta;
            conectar(consulta);
            adaptador.Fill(dts);
            conexion.Close();
            return dts.Tables[0];
        }


        public void actualizar()
        {
            conexion.Open();
            
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            SqlCommandBuilder test = new SqlCommandBuilder(adaptador);
            adaptador.Update(dts.Tables[0]);
            conexion.Close();

        }



    }
}
