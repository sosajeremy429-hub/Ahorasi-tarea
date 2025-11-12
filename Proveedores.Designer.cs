namespace PROYECTOCONEXION
{
    partial class Proveedores
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgProveedores = new System.Windows.Forms.DataGridView();
            this.btnCargarProveedor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtCorreoActualizar = new System.Windows.Forms.TextBox();
            this.txtTelefonoActualizar = new System.Windows.Forms.TextBox();
            this.txtNombreActualizar = new System.Windows.Forms.TextBox();
            this.txtProveedorIDActualizar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtProveedorID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgProveedores);
            this.groupBox4.Controls.Add(this.btnCargarProveedor);
            this.groupBox4.Location = new System.Drawing.Point(23, 295);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1128, 291);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar";
            // 
            // dgProveedores
            // 
            this.dgProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProveedores.Location = new System.Drawing.Point(39, 64);
            this.dgProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgProveedores.Name = "dgProveedores";
            this.dgProveedores.RowHeadersWidth = 62;
            this.dgProveedores.RowTemplate.Height = 28;
            this.dgProveedores.Size = new System.Drawing.Size(1019, 187);
            this.dgProveedores.TabIndex = 22;
            // 
            // btnCargarProveedor
            // 
            this.btnCargarProveedor.Location = new System.Drawing.Point(78, 20);
            this.btnCargarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarProveedor.Name = "btnCargarProveedor";
            this.btnCargarProveedor.Size = new System.Drawing.Size(932, 39);
            this.btnCargarProveedor.TabIndex = 21;
            this.btnCargarProveedor.Text = "Cargar";
            this.btnCargarProveedor.UseVisualStyleBackColor = true;
            this.btnCargarProveedor.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.txtCorreoActualizar);
            this.groupBox3.Controls.Add(this.txtTelefonoActualizar);
            this.groupBox3.Controls.Add(this.txtNombreActualizar);
            this.groupBox3.Controls.Add(this.txtProveedorIDActualizar);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(722, 42);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(449, 241);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(252, 146);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(126, 39);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtCorreoActualizar
            // 
            this.txtCorreoActualizar.Location = new System.Drawing.Point(24, 164);
            this.txtCorreoActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreoActualizar.Name = "txtCorreoActualizar";
            this.txtCorreoActualizar.Size = new System.Drawing.Size(178, 22);
            this.txtCorreoActualizar.TabIndex = 17;
            // 
            // txtTelefonoActualizar
            // 
            this.txtTelefonoActualizar.Location = new System.Drawing.Point(252, 93);
            this.txtTelefonoActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoActualizar.Name = "txtTelefonoActualizar";
            this.txtTelefonoActualizar.Size = new System.Drawing.Size(178, 22);
            this.txtTelefonoActualizar.TabIndex = 16;
            // 
            // txtNombreActualizar
            // 
            this.txtNombreActualizar.Location = new System.Drawing.Point(24, 93);
            this.txtNombreActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreActualizar.Name = "txtNombreActualizar";
            this.txtNombreActualizar.Size = new System.Drawing.Size(178, 22);
            this.txtNombreActualizar.TabIndex = 15;
            // 
            // txtProveedorIDActualizar
            // 
            this.txtProveedorIDActualizar.Location = new System.Drawing.Point(24, 46);
            this.txtProveedorIDActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProveedorIDActualizar.Name = "txtProveedorIDActualizar";
            this.txtProveedorIDActualizar.Size = new System.Drawing.Size(178, 22);
            this.txtProveedorIDActualizar.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Correo Electronico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.txtEliminar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(442, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(264, 250);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(44, 76);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(166, 39);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(18, 49);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(226, 22);
            this.txtEliminar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtCorreoElectronico);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtProveedorID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(411, 250);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(219, 154);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 39);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(27, 173);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(178, 22);
            this.txtCorreoElectronico.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(219, 111);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(178, 22);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtProveedorID
            // 
            this.txtProveedorID.Location = new System.Drawing.Point(25, 46);
            this.txtProveedorID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProveedorID.Name = "txtProveedorID";
            this.txtProveedorID.Size = new System.Drawing.Size(178, 22);
            this.txtProveedorID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo Electronico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 805);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgProveedores;
        private System.Windows.Forms.Button btnCargarProveedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtCorreoActualizar;
        private System.Windows.Forms.TextBox txtTelefonoActualizar;
        private System.Windows.Forms.TextBox txtNombreActualizar;
        private System.Windows.Forms.TextBox txtProveedorIDActualizar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtProveedorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}