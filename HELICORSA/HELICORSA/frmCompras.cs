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

namespace HELICORSA
{
    public partial class frmCompras : Form
    {
       private string cadenaConexion = DESKTOP-2IPUB8C\SQLEXPRESS.HELICORSADB.dbo);
        public frmCompras()
        {
            InitializeComponent();
    
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string idCompra = txtIdCompra.Text;
            DateTime fechaRegistro = dtpFechaRegistro.Value;
            DateTime fechaIngreso = dtpFechaIngreso.Value;
            string codigoEmpleado = txtCodigoEmpleado.Text;
            string departamento = txtDepartamento.Text;
            string proveedor = txtProveedor.Text;
            string numeroDocumento = txtNumeroDocumento.Text;
            DateTime fechaCompra = dtpFechaCompra.Value;
            decimal montoTotal = decimal.Parse(txtMontoTotal.Text);

            // Aquí realizas la conexión y la inserción en la base de datos
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO Compras (IdCompra, FechaRegistro, FechaIngreso, CodigoEmpleado, Departamento, Proveedor, NumeroDocumento, FechaCompra, MontoTotal) " +
                        "VALUES (@IdCompra, @FechaRegistro, @FechaIngreso, @CodigoEmpleado, @Departamento, @Proveedor, @NumeroDocumento, @FechaCompra, @MontoTotal)";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdCompra", idCompra);
                        comando.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);
                        comando.Parameters.AddWithValue("@FechaIngreso", fechaIngreso);
                        comando.Parameters.AddWithValue("@CodigoEmpleado", codigoEmpleado);
                        comando.Parameters.AddWithValue("@Departamento", departamento);
                        comando.Parameters.AddWithValue("@Proveedor", proveedor);
                        comando.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                        comando.Parameters.AddWithValue("@FechaCompra", fechaCompra);
                        comando.Parameters.AddWithValue("@MontoTotal", montoTotal);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Compra guardada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la compra: " + ex.Message);
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Consulta para verificar el rol del empleado
                    string consultaRol = "SELECT COUNT(*) FROM Empleados WHERE CodigoEmpleado = @CodigoEmpleado AND Rol = 'gerente'";

                    using (SqlCommand comandoRol = new SqlCommand(consultaRol, conexion))
                    {
                        comandoRol.Parameters.AddWithValue("@CodigoEmpleado", codigoEmpleado);

                        int count = (int)comandoRol.ExecuteScalar();

                        if (count > 0) // Si el empleado tiene el rol de gerente
                        {
                            // Insertar la compra en la base de datos
                            string consultaInsertar = "INSERT INTO Compras (IdCompra, FechaRegistro, FechaIngreso, CodigoEmpleado, Departamento, Proveedor, NumeroDocumento, FechaCompra, MontoTotal) " +
                                "VALUES (@IdCompra, @FechaRegistro, @FechaIngreso, @CodigoEmpleado, @Departamento, @Proveedor, @NumeroDocumento, @FechaCompra, @MontoTotal)";

                            using (SqlCommand comandoInsertar = new SqlCommand(consultaInsertar, conexion))
                            {
                                comandoInsertar.Parameters.AddWithValue("@IdCompra", idCompra);
                                comandoInsertar.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);
                                comandoInsertar.Parameters.AddWithValue("@FechaIngreso", fechaIngreso);
                                comandoInsertar.Parameters.AddWithValue("@CodigoEmpleado", codigoEmpleado);
                                comandoInsertar.Parameters.AddWithValue("@Departamento", departamento);
                                comandoInsertar.Parameters.AddWithValue("@Proveedor", proveedor);
                                comandoInsertar.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                                comandoInsertar.Parameters.AddWithValue("@FechaCompra", fechaCompra);
                                comandoInsertar.Parameters.AddWithValue("@MontoTotal", montoTotal);

                                comandoInsertar.ExecuteNonQuery();

                                MessageBox.Show("Compra guardada exitosamente.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Acceso denegado. El empleado no tiene el rol de gerente.");
                        }
                    }
                }
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
