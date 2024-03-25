using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Catffe_Codigo_Barras.Clases
{
    class CConexion
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-QO0EHRL\\SQLEXPRESS;Initial Catalog=Catffe;Integrated Security=True");
        


        public SqlConnection establecerConexion()
        {
            try
            {
                //cn.Open();
               // System.Windows.Forms.MessageBox.Show("Se logro la connexion");
            }

            catch (SqlException) {
                System.Windows.Forms.MessageBox.Show("No se logro la connexion");
            }
            return cn;
        }
        


    }
}
