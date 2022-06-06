
namespace FrmUno
{
    partial class FrmAgregar
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.datFeha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(208, 33);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(165, 22);
            this.txtDni.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmar.Location = new System.Drawing.Point(208, 151);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(165, 23);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Items.AddRange(new object[] {
            "AURICULARES",
            "MOUSE",
            "PANTALLA",
            "PLACA DE VIDEO",
            "TECLADO"});
            this.cmbProductos.Location = new System.Drawing.Point(12, 94);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(165, 23);
            this.cmbProductos.Sorted = true;
            this.cmbProductos.TabIndex = 5;
            // 
            // datFeha
            // 
            this.datFeha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datFeha.Location = new System.Drawing.Point(208, 91);
            this.datFeha.Name = "datFeha";
            this.datFeha.Size = new System.Drawing.Size(165, 22);
            this.datFeha.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Location = new System.Drawing.Point(12, 151);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(164, 15);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre y apellido del cliente:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(208, 15);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(89, 15);
            this.lblDni.TabIndex = 9;
            this.lblDni.Text = "DNI del cliente:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(12, 76);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(131, 15);
            this.lblProducto.TabIndex = 10;
            this.lblProducto.Text = "Seleccione el producto:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(208, 76);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(97, 15);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de compra";
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 191);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.datFeha);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.DateTimePicker datFeha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFecha;
    }
}