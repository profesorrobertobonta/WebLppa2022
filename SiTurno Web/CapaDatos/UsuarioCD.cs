using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;



namespace CapaDatos
{
    public class UsuarioCD
    {
        public string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = @"DESKTOP-F21264O\SQLEXPRESS";
            cs.InitialCatalog = "SiTurnosWeb";
            return cs.ConnectionString;
        }

        ///DataConnection ConnectionString = new DataConnection();
        public Usuario ListarUsuario(Usuario objUsuario)
        {
            try
            {
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;
                DataSet DS = new DataSet();
                List<Usuario> listaUsuario = new List<Usuario>();
                DataTable dt = new DataTable();
                Usuario objUsu = new Usuario();

                var sql = $@"select Usuario,Password from Usuarios where Usuario=@Usuario and Password=@Password;";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("Usuario", objUsuario.Usuarios);
                cmd.Parameters.AddWithValue("Password", objUsuario.Password);

                cmd.ExecuteNonQuery();

                SqlDataAdapter Adaptador = new SqlDataAdapter(cmd);
                Adaptador.Fill(DS);

                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow Item in DS.Tables[0].Rows)
                    {

                        objUsu.Usuarios = Item["Usuario"].ToString();
                        objUsu.Password = Item["Password"].ToString();


                    }
                    return objUsu;
                }
                else
                {
                    return null;
                }

            }
            catch (SqlException)
            {
                throw;

            }
        }
    }
}
