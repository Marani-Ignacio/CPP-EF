namespace Vista
{
    partial class FormProductos
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
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvProductos = new DataGridView();
            btnVerProveedores = new Button();
            btnGestionarProveedores = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(486, 157);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Volver";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(486, 70);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(486, 41);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(149, 23);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(486, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(445, 168);
            dgvProductos.TabIndex = 5;
            // 
            // btnVerProveedores
            // 
            btnVerProveedores.Location = new Point(486, 128);
            btnVerProveedores.Name = "btnVerProveedores";
            btnVerProveedores.Size = new Size(149, 23);
            btnVerProveedores.TabIndex = 10;
            btnVerProveedores.Text = "Ver Proveedores";
            btnVerProveedores.UseVisualStyleBackColor = true;
            btnVerProveedores.Click += btnVerProveedores_Click;
            // 
            // btnGestionarProveedores
            // 
            btnGestionarProveedores.Location = new Point(486, 99);
            btnGestionarProveedores.Name = "btnGestionarProveedores";
            btnGestionarProveedores.Size = new Size(149, 23);
            btnGestionarProveedores.TabIndex = 11;
            btnGestionarProveedores.Text = "Gestionar Proveedores";
            btnGestionarProveedores.UseVisualStyleBackColor = true;
            btnGestionarProveedores.Click += btnGestionarProveedores_Click;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 195);
            Controls.Add(btnGestionarProveedores);
            Controls.Add(btnVerProveedores);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProductos);
            Name = "FormProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            FormClosing += FormProductos_FormClosing;
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvProductos;
        private Button btnVerProveedores;
        private Button btnGestionarProveedores;
    }
}