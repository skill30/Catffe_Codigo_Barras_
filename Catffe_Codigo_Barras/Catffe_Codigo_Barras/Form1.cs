using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catffe_Codigo_Barras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.CBusqueda objetoBusqueda = new Clases.CBusqueda();
            objetoBusqueda.BuscarD(txtCodigo, Nombre_P, Existenci_P, precio_P, D_producto);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                


                RealizarBusqueda();
                txtCodigo.Text = " ";


            }
        }

        private void RealizarBusqueda()
        {
            try
            {



                Clases.CBusqueda objetoBusqueda = new Clases.CBusqueda();
                objetoBusqueda.BuscarD(txtCodigo, Nombre_P, Existenci_P, precio_P, D_producto);
               
                   
              


            }
            catch (Exception ex)
            {



                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);




            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {


            AbrirNuevoForm();

            
        }
        private void AbrirNuevoForm()
        {
            try
            {
                NuevoForm nuevoForm = new NuevoForm();
                nuevoForm.Show();
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
