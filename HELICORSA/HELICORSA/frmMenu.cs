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
    public partial class frmMenu : Form
    {
        private static string uRol;  // Estu sutituye por el momento al objeto Usuario
        private static ToolStripMenuItem MenuActivo = null; // Esta variable sirve para guardar el Item del menu que se selecciona
        private static Form FormularioActivo = null; // En esta varible se almacena el nombre del formulario que esta activo

        public frmMenu(string Rol)
        {
            InitializeComponent();
            uRol = Rol;
        }

        private void Abrirformulario(ToolStripMenuItem menu, Form formulario)
        {
            //Con esta función mostramos el formulario elegido en el menu
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = System.Drawing.Color.White;
            }
            menu.BackColor = System.Drawing.Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null) // Si ya existe un formulario activo lo cierra
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = System.Drawing.Color.DarkSlateBlue;

            contenedor.Controls.Add(formulario); // Con esta intruccion agrega el formulario al contendor
            formulario.Show(); // Muestra el formulario elegido en el area del contendor
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostramos en pantalla con MessageBox el Acerca de
            MessageBox.Show("Grupo 13 Catedra Programación I Ciclo 01-2023\n" +
                            "Flor de Maria Deodanes Vasquez 25-3291-2021\n" +
                            "Gabriela Liseth Faibian Carbajal 25-1016-2022\n" +
                            "Maria Lisseth Hernandez Rosales 25-0294-2016\n" +
                            "Wendi Alexandra Diaz Mejía 25-1911-2022\n" +
                            "Brnadon Steven Nuila Fuentes 25-0863-2021\n" +
                            "Rafael Marique Argueta Moreno 25-0163-2021\n" +
                            "Edwin Rolando Menjivar Coreas 25-3923-1993\n" +
                            "Moises Isaía Arias Guerra 25-3507-2022\n",
                            "Proyecto Elaborado por: ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Al dar click en salir y confirmar retornamos al formulario del login
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Desea salir del menu principal?", "Salir del menu principal",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // Esta linea se esta implementando porque ya se implemento el frmMenu
                this.Owner.Show(); // Para llamar al formulario padre.
                Close();
            }           
        }

        // con los siguientes eventos click se llaman a los formularios para que se muestren en el contendor
        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario((ToolStripMenuItem)sender, new frmEmpleados());
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario((ToolStripMenuItem)sender, new frmUsuarios());
        }

        private void tipoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario((ToolStripMenuItem)sender, new frmTusuarios());
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario((ToolStripMenuItem)sender, new frmDepto());
        }

        private void oficinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario((ToolStripMenuItem)sender, new frmOficina());
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario((ToolStripMenuItem)sender, new frmCargo());
        }

        private void estadoDeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario((ToolStripMenuItem)sender, new frmEequipo());
        }

        private void tipoDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario((ToolStripMenuItem)sender, new frmTequipo());
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario((ToolStripMenuItem)sender, new frmProveedor());
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario((ToolStripMenuItem)sender, new frmCompras());
        }

        private void historialYCentroDeCostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario((ToolStripMenuItem)sender, new frmHistorial());
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario((ToolStripMenuItem)sender, new frmHistorial());
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

            if (uRol == "2")
            {
                usuariosToolStripMenuItem.Visible = false;
                mantenimientoToolStripMenuItem.Visible = false;
                bodegaToolStripMenuItem.Visible = false;
            }

            if (uRol == "3")
            {
                empleadoToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
                mantenimientoToolStripMenuItem.Visible = false;
            }
        }
    }
}
