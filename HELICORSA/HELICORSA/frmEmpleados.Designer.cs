namespace HELICORSA
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_Gerencia = new System.Windows.Forms.TextBox();
            this.Cbox_Cargo = new System.Windows.Forms.ComboBox();
            this.txt_Nombre_Completo = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Segundo_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Primer_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Segundo_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Primer_Nombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::HELICORSA.Properties.Resources.boton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 54);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_Gerencia);
            this.groupBox1.Controls.Add(this.Cbox_Cargo);
            this.groupBox1.Controls.Add(this.txt_Nombre_Completo);
            this.groupBox1.Controls.Add(this.txt_Telefono);
            this.groupBox1.Controls.Add(this.txt_Direccion);
            this.groupBox1.Controls.Add(this.txt_Segundo_Apellido);
            this.groupBox1.Controls.Add(this.txt_Primer_Apellido);
            this.groupBox1.Controls.Add(this.txt_Segundo_Nombre);
            this.groupBox1.Controls.Add(this.txt_Primer_Nombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 399);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Empleado";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::HELICORSA.Properties.Resources.agregar_archivo;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Agregar.Location = new System.Drawing.Point(191, 253);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(69, 73);
            this.btn_Agregar.TabIndex = 17;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Gerencia
            // 
            this.txt_Gerencia.Location = new System.Drawing.Point(385, 303);
            this.txt_Gerencia.Name = "txt_Gerencia";
            this.txt_Gerencia.Size = new System.Drawing.Size(187, 28);
            this.txt_Gerencia.TabIndex = 16;
            // 
            // Cbox_Cargo
            // 
            this.Cbox_Cargo.FormattingEnabled = true;
            this.Cbox_Cargo.Location = new System.Drawing.Point(177, 218);
            this.Cbox_Cargo.Name = "Cbox_Cargo";
            this.Cbox_Cargo.Size = new System.Drawing.Size(160, 29);
            this.Cbox_Cargo.TabIndex = 2;
            // 
            // txt_Nombre_Completo
            // 
            this.txt_Nombre_Completo.Location = new System.Drawing.Point(385, 242);
            this.txt_Nombre_Completo.Name = "txt_Nombre_Completo";
            this.txt_Nombre_Completo.Size = new System.Drawing.Size(187, 28);
            this.txt_Nombre_Completo.TabIndex = 15;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(177, 186);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(160, 28);
            this.txt_Telefono.TabIndex = 14;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(177, 151);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(160, 28);
            this.txt_Direccion.TabIndex = 13;
            // 
            // txt_Segundo_Apellido
            // 
            this.txt_Segundo_Apellido.Location = new System.Drawing.Point(177, 119);
            this.txt_Segundo_Apellido.Name = "txt_Segundo_Apellido";
            this.txt_Segundo_Apellido.Size = new System.Drawing.Size(160, 28);
            this.txt_Segundo_Apellido.TabIndex = 12;
            // 
            // txt_Primer_Apellido
            // 
            this.txt_Primer_Apellido.Location = new System.Drawing.Point(177, 89);
            this.txt_Primer_Apellido.Name = "txt_Primer_Apellido";
            this.txt_Primer_Apellido.Size = new System.Drawing.Size(160, 28);
            this.txt_Primer_Apellido.TabIndex = 11;
            // 
            // txt_Segundo_Nombre
            // 
            this.txt_Segundo_Nombre.Location = new System.Drawing.Point(177, 60);
            this.txt_Segundo_Nombre.Name = "txt_Segundo_Nombre";
            this.txt_Segundo_Nombre.Size = new System.Drawing.Size(160, 28);
            this.txt_Segundo_Nombre.TabIndex = 10;
            // 
            // txt_Primer_Nombre
            // 
            this.txt_Primer_Nombre.Location = new System.Drawing.Point(177, 30);
            this.txt_Primer_Nombre.Name = "txt_Primer_Nombre";
            this.txt_Primer_Nombre.Size = new System.Drawing.Size(160, 28);
            this.txt_Primer_Nombre.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gerencia :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cargo :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nombre Completo :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(385, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 181);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Apellido :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primero Apellido :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Nombre :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HELICORSA.Properties.Resources.abstract_falling_lines_blue_background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 430);
            this.panel1.TabIndex = 3;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 430);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_Gerencia;
        private System.Windows.Forms.ComboBox Cbox_Cargo;
        private System.Windows.Forms.TextBox txt_Nombre_Completo;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Segundo_Apellido;
        private System.Windows.Forms.TextBox txt_Primer_Apellido;
        private System.Windows.Forms.TextBox txt_Segundo_Nombre;
        private System.Windows.Forms.TextBox txt_Primer_Nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}