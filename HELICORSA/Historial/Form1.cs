namespace Historial
{
    public partial class Form1 : Form
    {
        Double Precio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Producto = cboProducto.Text;

            if (Producto.Equals("Coleccion de Computadoras portatiles")) Precio = 250;
            if (Producto.Equals("Coleccion de Computadoras Personales")) Precio = 350;
            if (Producto.Equals("Coleccion de Computadoras de escritorio")) Precio = 500;

            lblPrecio.Text = Precio.ToString("c");





        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = (0).ToString("c");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Comprobacion 
            if (cboProducto.SelectedIndex == -1)
                MessageBox.Show("Debe Seleccionar un Producto");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe Ingresar una Cantidad");
            else if (cboTipo.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo");
            else
            {
                //capturando Datos
                string Producto = cboProducto.Text;
                int Cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = cboTipo.Text;

                //Procesar Calculos 
                double subtotal = Cantidad * Precio;

                double descuento = 0, recargo = 0;
                if (tipo.Equals("Contado"))
                    descuento = 0.05 * subtotal;
                else
                    recargo = 0.1 * subtotal;
                double PrecioFinal = subtotal - descuento + recargo;

                //Impresion de resultados
                ListViewItem fila = new ListViewItem(Producto);
                fila.SubItems.Add(Cantidad.ToString());
                fila.SubItems.Add(Precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(PrecioFinal.ToString());

                lvVenta.Items.Add(fila);
                button2_Click(sender, e);


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            cboProducto.Text = "(Seleccione Producto)";
            cboTipo.Text = "(Seleccione Tipo)";
            txtCantidad.Clear();
            lblPrecio.Text = (0).ToString("c");
            cboProducto.Focus();




        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}