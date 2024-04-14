namespace Vista
{
    partial class FormMenu
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
            btnCategoria = new Button();
            btnVolver = new Button();
            btnProducto = new Button();
            btnProveedor = new Button();
            SuspendLayout();
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(14, 16);
            btnCategoria.Margin = new Padding(3, 4, 3, 4);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(195, 43);
            btnCategoria.TabIndex = 1;
            btnCategoria.Text = "Categorias";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(75, 178);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(66, 29);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(14, 67);
            btnProducto.Margin = new Padding(3, 4, 3, 4);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(195, 43);
            btnProducto.TabIndex = 4;
            btnProducto.Text = "Productos";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.Location = new Point(14, 118);
            btnProveedor.Margin = new Padding(3, 4, 3, 4);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(195, 43);
            btnProveedor.TabIndex = 5;
            btnProveedor.Text = "Proveedores";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 219);
            Controls.Add(btnProveedor);
            Controls.Add(btnProducto);
            Controls.Add(btnVolver);
            Controls.Add(btnCategoria);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú";
            FormClosing += FormMenu_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private Button btnCategoria;
        private Button btnVolver;
        private Button btnProducto;
        private Button btnProveedor;
    }
}