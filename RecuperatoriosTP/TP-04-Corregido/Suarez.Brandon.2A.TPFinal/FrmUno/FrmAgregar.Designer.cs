
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
            this.datFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.chListServicios = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.btnPrecios = new System.Windows.Forms.Button();
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
            this.txtDni.Location = new System.Drawing.Point(12, 91);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(165, 22);
            this.txtDni.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmar.Location = new System.Drawing.Point(222, 179);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(165, 23);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // datFecha
            // 
            this.datFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datFecha.Location = new System.Drawing.Point(11, 141);
            this.datFecha.Name = "datFecha";
            this.datFecha.Size = new System.Drawing.Size(165, 22);
            this.datFecha.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Location = new System.Drawing.Point(51, 179);
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
            this.lblDni.Location = new System.Drawing.Point(12, 73);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(89, 15);
            this.lblDni.TabIndex = 9;
            this.lblDni.Text = "DNI del cliente:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 123);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(77, 15);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha actual:";
            // 
            // chListServicios
            // 
            this.chListServicios.FormattingEnabled = true;
            this.chListServicios.Items.AddRange(new object[] {
            "Mantenimiento",
            "Reparacion",
            "Venta"});
            this.chListServicios.Location = new System.Drawing.Point(210, 33);
            this.chListServicios.Name = "chListServicios";
            this.chListServicios.Size = new System.Drawing.Size(105, 55);
            this.chListServicios.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Servicio a realizar:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(323, 116);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(107, 22);
            this.txtPrecio.TabIndex = 14;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(323, 98);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(105, 15);
            this.lblServicio.TabIndex = 15;
            this.lblServicio.Text = "Coste del servicio:";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(210, 116);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(107, 22);
            this.txtDias.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dias para entregar:";
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Items.AddRange(new object[] {
            "PC",
            "PS4",
            "PS3",
            "XBOX360",
            "XBOXONE",
            "MONITOR"});
            this.cmbEquipo.Location = new System.Drawing.Point(321, 33);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(105, 23);
            this.cmbEquipo.TabIndex = 18;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(321, 15);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(48, 15);
            this.lblEquipo.TabIndex = 19;
            this.lblEquipo.Text = "Equipo:";
            // 
            // btnPrecios
            // 
            this.btnPrecios.Location = new System.Drawing.Point(323, 62);
            this.btnPrecios.Name = "btnPrecios";
            this.btnPrecios.Size = new System.Drawing.Size(103, 23);
            this.btnPrecios.TabIndex = 20;
            this.btnPrecios.Text = "Costos";
            this.btnPrecios.UseVisualStyleBackColor = true;
            this.btnPrecios.Click += new System.EventHandler(this.btnPrecios_Click);
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 214);
            this.Controls.Add(this.btnPrecios);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.cmbEquipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chListServicios);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.datFecha);
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
        private System.Windows.Forms.DateTimePicker datFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.CheckedListBox chListServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Button btnPrecios;
    }
}