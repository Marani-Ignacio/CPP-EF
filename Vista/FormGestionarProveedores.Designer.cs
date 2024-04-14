namespace Vista
{
    partial class FormGestionarProveedores
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
            lblProducto = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            txtCuit = new TextBox();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(14, 12);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(76, 20);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto: ";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(51, 131);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(71, 31);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(192, 131);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(71, 31);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 56);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 3;
            label2.Text = "Ingresar Cuit Proveedor:";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(51, 80);
            txtCuit.Margin = new Padding(3, 4, 3, 4);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(212, 27);
            txtCuit.TabIndex = 4;
            // 
            // FormGestionarProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 180);
            Controls.Add(txtCuit);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(lblProducto);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionarProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Proveedores";
            Load += FormGestionarClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private Button btnAgregar;
        private Button btnCancelar;
        private Label label2;
        private TextBox txtCuit;
    }
}