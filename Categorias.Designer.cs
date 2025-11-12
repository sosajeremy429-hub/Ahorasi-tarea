namespace PROYECTOCONEXION
{
    partial class Categorias
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
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.btnCargarCategorias = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCategoriaIDActualizar = new System.Windows.Forms.TextBox();
            this.txtNombreCategoriaActualizar = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.txtCategoriaID = new System.Windows.Forms.TextBox();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgCategorias);
            this.groupBox4.Controls.Add(this.btnCargarCategorias);
            this.groupBox4.Location = new System.Drawing.Point(29, 262);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(965, 296);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar";
            // 
            // dgCategorias
            // 
            this.dgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Location = new System.Drawing.Point(17, 64);
            this.dgCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.RowHeadersWidth = 62;
            this.dgCategorias.RowTemplate.Height = 28;
            this.dgCategorias.Size = new System.Drawing.Size(922, 192);
            this.dgCategorias.TabIndex = 18;
            // 
            // btnCargarCategorias
            // 
            this.btnCargarCategorias.Location = new System.Drawing.Point(108, 20);
            this.btnCargarCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarCategorias.Name = "btnCargarCategorias";
            this.btnCargarCategorias.Size = new System.Drawing.Size(732, 37);
            this.btnCargarCategorias.TabIndex = 8;
            this.btnCargarCategorias.Text = "Cargar";
            this.btnCargarCategorias.UseVisualStyleBackColor = true;
            this.btnCargarCategorias.Click += new System.EventHandler(this.btnCargarCategorias_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCategoriaIDActualizar);
            this.groupBox3.Controls.Add(this.txtNombreCategoriaActualizar);
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(682, 30);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(294, 208);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizar";
            // 
            // txtCategoriaIDActualizar
            // 
            this.txtCategoriaIDActualizar.Location = new System.Drawing.Point(68, 40);
            this.txtCategoriaIDActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoriaIDActualizar.Name = "txtCategoriaIDActualizar";
            this.txtCategoriaIDActualizar.Size = new System.Drawing.Size(153, 22);
            this.txtCategoriaIDActualizar.TabIndex = 13;
            // 
            // txtNombreCategoriaActualizar
            // 
            this.txtNombreCategoriaActualizar.Location = new System.Drawing.Point(68, 97);
            this.txtNombreCategoriaActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCategoriaActualizar.Name = "txtNombreCategoriaActualizar";
            this.txtNombreCategoriaActualizar.Size = new System.Drawing.Size(153, 22);
            this.txtNombreCategoriaActualizar.TabIndex = 12;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(112, 134);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 37);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEliminar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(384, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(224, 208);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(21, 40);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(179, 22);
            this.txtEliminar.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(34, 68);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(155, 38);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreCategoria);
            this.groupBox1.Controls.Add(this.txtCategoriaID);
            this.groupBox1.Controls.Add(this.bntAgregar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(339, 215);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(37, 103);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(153, 22);
            this.txtNombreCategoria.TabIndex = 14;
            // 
            // txtCategoriaID
            // 
            this.txtCategoriaID.Location = new System.Drawing.Point(37, 46);
            this.txtCategoriaID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoriaID.Name = "txtCategoriaID";
            this.txtCategoriaID.Size = new System.Drawing.Size(153, 22);
            this.txtCategoriaID.TabIndex = 9;
            // 
            // bntAgregar
            // 
            this.bntAgregar.Location = new System.Drawing.Point(196, 103);
            this.bntAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntAgregar.Name = "bntAgregar";
            this.bntAgregar.Size = new System.Drawing.Size(109, 37);
            this.bntAgregar.TabIndex = 2;
            this.bntAgregar.Text = "Agregar";
            this.bntAgregar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 735);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
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
        private System.Windows.Forms.DataGridView dgCategorias;
        private System.Windows.Forms.Button btnCargarCategorias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCategoriaIDActualizar;
        private System.Windows.Forms.TextBox txtNombreCategoriaActualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.TextBox txtCategoriaID;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}