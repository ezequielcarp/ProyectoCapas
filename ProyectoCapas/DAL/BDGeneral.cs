using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BDGeneral
    {

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDpersona;Data Source=DESKTOP-PC919CD\\SQLEXPRESS");
            conexion.Open();

            return conexion;
        }


    }
}
