using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catffe_Codigo_Barras.Clases
{
    class CBusqueda
    {
        public void BuscarD(TextBox txtCodigo, TextBox Nombre_P, TextBox Existenci_P, TextBox Precio_P, TextBox D_producto)
        {
            CConexion objeto = new CConexion();
            SqlConnection cn = objeto.establecerConexion();
            try{
                cn.Open();
                string sql = "select producto.nombre, producto.precio, producto.Existencia from producto where producto.Cbarra='" + txtCodigo.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    Nombre_P.Text = rdr[0].ToString();
                    Existenci_P.Text = rdr[1].ToString();
                    Precio_P.Text = rdr[2].ToString();
                    D_producto.Text = rdr[3].ToString();
               }
            }
            catch (Exception ex) {
                MessageBox.Show("No se logro realizar la busqueda, error: "+ ex.ToString());
            }
        }
    }
}
