namespace Historial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();// agregando filas "n"
            dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;//guardando valores 
            dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;
            textBox1.Text = "";//borrando espacios de texto
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult n = MessageBox.Show("Desea salir de la app... ?", "App Registro de Producstos HELICORSA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(n==DialogResult.Yes)
            {
                Close();

            }


        }
    }
}