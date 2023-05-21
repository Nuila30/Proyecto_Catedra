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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
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

        private void button2_Click(object sender, EventArgs e)
        {
           String Nom = txt_Nombre.Text;
           String Ape = txt_Apellido.Text;
           String usua = txt_Usuario.Text;
           String Contra = txt_Contraseña.Text;
           String Rol = Cbox_Rol.Text;
           String Est = Cbox_Estado.Text;
            if (Nom == "")
            {
                MessageBox.Show("El Campo Nombre Esta Vacio");
            }
            else if (Ape == "")
            {
                MessageBox.Show("El Campo Apellido Esta Vacio");
            }
            else if (usua == "")
            {
                MessageBox.Show("El Campo usuario Esta Vacio");
            }
            else if (Contra == "")
            {
                MessageBox.Show("El Campo Nombre Esta Vacio");
            }
        }
    }
}
