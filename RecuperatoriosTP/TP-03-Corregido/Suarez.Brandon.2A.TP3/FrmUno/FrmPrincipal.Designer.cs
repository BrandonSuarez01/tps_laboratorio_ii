
namespace FrmUno
{
    partial class FrmPrincipal
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstServicios = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtDniEliminar = new System.Windows.Forms.TextBox();
            this.lblDniEliminar = new System.Windows.Forms.Label();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnHardcode = new System.Windows.Forms.Button();
            this.btnReclamos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(12, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(285, 45);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstServicios
            // 
            this.lstServicios.FormattingEnabled = true;
            this.lstServicios.ItemHeight = 17;
            this.lstServicios.Location = new System.Drawing.Point(303, 14);
            this.lstServicios.Name = "lstServicios";
            this.lstServicios.Size = new System.Drawing.Size(838, 327);
            this.lstServicios.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(12, 112);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(285, 45);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtDniEliminar
            // 
            this.txtDniEliminar.Location = new System.Drawing.Point(12, 82);
            this.txtDniEliminar.Name = "txtDniEliminar";
            this.txtDniEliminar.Size = new System.Drawing.Size(181, 25);
            this.txtDniEliminar.TabIndex = 3;
            // 
            // lblDniEliminar
            // 
            this.lblDniEliminar.AutoSize = true;
            this.lblDniEliminar.Location = new System.Drawing.Point(12, 62);
            this.lblDniEliminar.Name = "lblDniEliminar";
            this.lblDniEliminar.Size = new System.Drawing.Size(166, 17);
            this.lblDniEliminar.TabIndex = 4;
            this.lblDniEliminar.Text = "DNI de servicio a eliminar:";
            // 
            // btnXml
            // 
            this.btnXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXml.Location = new System.Drawing.Point(12, 214);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(285, 45);
            this.btnXml.TabIndex = 6;
            this.btnXml.Text = "Leer/Escribir XML";
            this.btnXml.UseVisualStyleBackColor = false;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(199, 81);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 25);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnHardcode
            // 
            this.btnHardcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHardcode.Location = new System.Drawing.Point(12, 163);
            this.btnHardcode.Name = "btnHardcode";
            this.btnHardcode.Size = new System.Drawing.Size(285, 45);
            this.btnHardcode.TabIndex = 9;
            this.btnHardcode.Text = "Generar 5 clientes";
            this.btnHardcode.UseVisualStyleBackColor = false;
            this.btnHardcode.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReclamos
            // 
            this.btnReclamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReclamos.Location = new System.Drawing.Point(12, 265);
            this.btnReclamos.Name = "btnReclamos";
            this.btnReclamos.Size = new System.Drawing.Size(285, 45);
            this.btnReclamos.TabIndex = 10;
            this.btnReclamos.Text = "Reclamos";
            this.btnReclamos.UseVisualStyleBackColor = false;
            this.btnReclamos.Click += new System.EventHandler(this.btnReclamos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 351);
            this.Controls.Add(this.btnReclamos);
            this.Controls.Add(this.btnHardcode);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.lblDniEliminar);
            this.Controls.Add(this.txtDniEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstServicios);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstServicios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDniEliminar;
        private System.Windows.Forms.Label lblDniEliminar;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnHardcode;
        private System.Windows.Forms.Button btnReclamos;
    }
}

