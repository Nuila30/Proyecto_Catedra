using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELICORSA
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Desea cerrar esta pantalla?", "Salir de la pantalla actual",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Nom1 = txt_Primer_Nombre.Text;
            String Nom2 = txt_Segundo_Nombre.Text;
            String Ape1 = txt_Primer_Apellido.Text;
            String Ape2 = txt_Segundo_Apellido.Text;
            String Dic = txt_Direccion.Text;
            String Tele = txt_Telefono.Text;
            String Cargo = Cbox_Cargo.Text;
            String NomC = txt_Nombre_Completo.Text;
            String Gen = txt_Gerencia.Text;
            if (Nom1 == "")
            {
                MessageBox.Show("El Campo Primer Nombre Esta Vacio");
            } else if (Nom2 == "")
            {
                MessageBox.Show("El Campo Segundo Nombre Esta Vacio");
            }
            else if (Ape1 == "")
            {
                MessageBox.Show("El Campo Primer Apellido Esta Vacio");
            }
            else if (Ape2 == "")
            {
                MessageBox.Show("El Campo Segundo Apellido Esta Vacio");
            }
            else if (Dic == "")
            {
                MessageBox.Show("El Campo Direccion Esta Vacio");
            }
            else if (Tele == "")
            {
                MessageBox.Show("El Campo Telefono Esta Vacio");
            }
            else if (Cargo == "")
            {
                MessageBox.Show("No se a leccionado un Cargo");
            }
            else if (NomC == "")
            {
                MessageBox.Show("El Nombre Completo no Esta..");
            }
            else if (Gen == "")
            {
                MessageBox.Show("Falta la Gerencia");
            }
            
        }
    }
}
