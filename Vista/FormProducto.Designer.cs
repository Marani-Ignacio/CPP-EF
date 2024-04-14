namespace Vista
{
    partial class FormProducto
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
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label3 = new Label();
            cbCategoria = new ComboBox();
            txtTalle = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(76, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(101, 23);
            txtNombre.TabIndex = 20;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(76, 6);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(101, 23);
            txtCodigo.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 18;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 17;
            label1.Text = "Codigo";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(115, 127);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(62, 22);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 126);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(62, 23);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 21;
            label3.Text = "Categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(76, 93);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(101, 23);
            cbCategoria.TabIndex = 22;
            // 
            // txtTalle
            // 
            txtTalle.Location = new Point(76, 64);
            txtTalle.Name = "txtTalle";
            txtTalle.Size = new Size(101, 23);
            txtTalle.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 67);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 23;
            label4.Text = "Talle";
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(195, 163);
            Controls.Add(txtTalle);
            Controls.Add(label4);
            Controls.Add(cbCategoria);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FormProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto";
            Load += FormProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label3;
        private ComboBox cbCategoria;
        private TextBox txtTalle;
        private Label label4;
    }
}