using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Accesso
{
    public abstract class Conexion
    {

        private string ConnectionString;
        private protected SqlConnection conexion;
        private protected SqlDataAdapter adaptador;

        String Query;
        DataSet dts; 


        public Conexion()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["SecureCore.Properties.Settings.SecureCoreConnectionString"].ConnectionString;
        }

        private protected void conectar(String query)
        {
            conexion = new SqlConnection(ConnectionString);
            try
            {
                if (query!= null && query!="")
                {
                    adaptador = new SqlDataAdapter(query, conexion);
                    if (conexion.State == ConnectionState.Closed) conexion.Open();   
                }
            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
            }
        }

        public DataTable PortarTaula(String tabla)
        {
            dts.Clear();
            Query = String.Format("Select * from {0} ", tabla);
            conectar(Query);
            adaptador.Fill(dts, tabla);
            conexion.Close();
            return dts.Tables[tabla];
                
        }

        private void OnRowUpdated(object sender, SqlRowUpdatedEventArgs args)
        {
            if (args.Status == UpdateStatus.ErrorsOccurred)
            {
                args.Status = UpdateStatus.SkipCurrentRow;
            }
        }

        public void Actualizar()
        {
            conexion.Open();
            adaptador = new SqlDataAdapter(Query, conexion);
            adaptador.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adaptador);
            adaptador.Update(dts.Tables[0]);
            conexion.Close();       
        }

        private DataSet PortarPerConsulta (String Consulta)
        {
            dts.Clear();
            conectar(Consulta);
            adaptador.Fill(dts);
            conexion.Close();
            return dts;
        }


        private DataSet PortarPerConsulta(String Consulta, String consulta)
        {
            dts.Clear();
            conectar(Consulta);
            adaptador.Fill(dts, consulta);
            conexion.Close();
            return dts;
        }

        public int Execute(String Consulta)
        {
            conectar(Consulta);
            SqlCommand cmd = SqlCommand(Consulta, conexion);
            int registresAfectats = cmd.ExecuteNonQuery();
            return registresAfectats;
        }

        public void Store()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("ten most expensive products", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Login", "1"));
            conexion.Close();
        }
    }
}
