namespace Historial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblPrecio = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            cboTipo = new ComboBox();
            cboProducto = new ComboBox();
            lvVenta = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnSalir = new Button();
            button2 = new Button();
            btnRegistrar = new Button();
            label7 = new Label();
            lblFecha = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 23);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "Centro de Costo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(cboTipo);
            groupBox1.Controls.Add(cboProducto);
            groupBox1.Location = new Point(37, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(628, 142);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblPrecio
            // 
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(469, 34);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(179, 34);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            lblPrecio.Click += lblPrecio_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 19);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 5;
            label4.Text = "Cantidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 19);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 6;
            label5.Text = "Precio del Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 82);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 4;
            label3.Text = "Seleccione tipo de pago:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 19);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "Seleccione Producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(268, 37);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(121, 23);
            txtCantidad.TabIndex = 2;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Contado", "Tarjeta" });
            cboTipo.Location = new Point(38, 100);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(170, 23);
            cboTipo.TabIndex = 1;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Items.AddRange(new object[] { "Coleccion de Computadoras portatiles", "Coleccion de Computadoras Personales", "Coleccion de Computadoras de escritorio" });
            cboProducto.Location = new Point(38, 37);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(170, 23);
            cboProducto.TabIndex = 0;
            cboProducto.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lvVenta
            // 
            lvVenta.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvVenta.GridLines = true;
            lvVenta.Location = new Point(56, 269);
            lvVenta.Name = "lvVenta";
            lvVenta.Size = new Size(516, 170);
            lvVenta.TabIndex = 2;
            lvVenta.UseCompatibleStateImageBehavior = false;
            lvVenta.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cant.";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tipo de Pago";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Descuento ";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Recargo";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Precio Final";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.PaleTurquoise;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(578, 284);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 40);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(251, 212);
            button2.Name = "button2";
            button2.Size = new Size(124, 40);
            button2.TabIndex = 4;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.PaleTurquoise;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(391, 212);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(124, 40);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar ";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(484, 31);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 6;
            label7.Text = "Fecha Actual:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(568, 31);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(51, 15);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "IbIFecha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 468);
            Controls.Add(lblFecha);
            Controls.Add(label7);
            Controls.Add(btnRegistrar);
            Controls.Add(button2);
            Controls.Add(btnSalir);
            Controls.Add(lvVenta);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cboTipo;
        private ComboBox cboProducto;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCantidad;
        private ListView lvVenta;
        private Button btnSalir;
        private Button button2;
        private Button btnRegistrar;
        private Label label5;
        private Label lblPrecio;
        private Label label7;
        private Label lblFecha;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}