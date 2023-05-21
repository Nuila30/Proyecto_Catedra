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
    public partial class Login : Form
    {
        // Creamos muna matriz< mientras no tengasmoa acecso a la base
        // este sera nuestros usuarios para ingresar
        string[,,] usuarios = new string[,,]
        {
                {{"Admin", "admin", "1"}, {"Usuario", "usuario", "2"}, {"Bodega", "bodega", "3"}}
        };

        public Login()
        {
            InitializeComponent();
           
            this.ttMensaje.SetToolTip(this.txtUsuario, "Ingrese el nombre del usuario");
            this.ttMensaje.SetToolTip(this.txtClave, "Ingrese la clave del usuario");
            this.ttMensaje.SetToolTip(this.btnIngresar, "Presionar para ingresar al sistema");
            this.ttMensaje.SetToolTip(this.btnSalir, "Presionar para salir del sistema");
        }

        private void Limpiar()
        {
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Desea salir de la Aplicación?", "Salir de la Aplicación",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit(); // Esta es otra forma de salir de la aplicación
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string rol = string.Empty; // Esta variable nos indica el rol del usuario
            bool uexiste = true;      // esta variable nos indica si un usuario no existe
            /*
            MessageBox.Show(usuarios[0, 0, 0] + ", " + usuarios[0, 0, 1] + ", " + usuarios[0, 0, 2] + "\n" +
                            usuarios[0, 1, 0] + ", " + usuarios[0, 1, 1] + ", " + usuarios[0, 1, 2] + "\n" +
                            usuarios[0, 2, 0] + ", " + usuarios[0 ,2, 1] + ", " + usuarios[0, 2, 2] + "\n",
                            "Matriz usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
            if (es_valido())
            {
                errorControl.Clear();

                for (int i = 0; i < 3; i++)
                {
                    if (txtUsuario.Text == usuarios[0,i,0])
                    {
                        uexiste = true;
                        if (txtClave.Text == usuarios[0,i,1])
                        {
                            rol = usuarios[0,i,2];

                            frmMenu irMenu = new frmMenu(rol);

                            irMenu.Show(this); // Para mostrar el formulario deseado
                            this.Hide();       // Ocultamos formulario padre, es decir "frmMenu"

                            break;
                        }
                        else
                        {
                            MessageBox.Show("La contraseña es incorrecta",
                                            "Error de Acceso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            break;
                        }
                    }
                    else
                    {
                        uexiste = false;
                    }
                }
                if (!uexiste)
                {
                    MessageBox.Show("El usuario no existe",
                                    "Error de Acceso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                Limpiar();

            }
            
            
            
        }

        private bool es_valido()
        {
            //Variable para controlar si hubo un error
            bool sin_error = true;

            if (txtUsuario.Text == string.Empty)
            {
                //El método SetErrror() se utiliza para enviar el error
                errorControl.SetError(txtUsuario, "El campo Usuario no puede estar vacio");
                sin_error = false; // Cambiamos a "false" porque ocurrio un error
            }

            if (txtClave.Text == string.Empty)
            {
                errorControl.SetError(txtClave, "El campo Contraseña no puede estar vacio");
                sin_error = false; // Cambiamos a "false" porque ocurrio un error
            }
            return sin_error;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
