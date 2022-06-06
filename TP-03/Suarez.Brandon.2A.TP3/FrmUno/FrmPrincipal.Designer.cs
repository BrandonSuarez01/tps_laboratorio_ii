
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
            this.lstCompras = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtDniEliminar = new System.Windows.Forms.TextBox();
            this.lblDniEliminar = new System.Windows.Forms.Label();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnHarcode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(12, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(285, 55);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstCompras
            // 
            this.lstCompras.FormattingEnabled = true;
            this.lstCompras.ItemHeight = 17;
            this.lstCompras.Location = new System.Drawing.Point(303, 14);
            this.lstCompras.Name = "lstCompras";
            this.lstCompras.Size = new System.Drawing.Size(597, 327);
            this.lstCompras.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(12, 138);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(285, 45);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtDniEliminar
            // 
            this.txtDniEliminar.Location = new System.Drawing.Point(12, 107);
            this.txtDniEliminar.Name = "txtDniEliminar";
            this.txtDniEliminar.Size = new System.Drawing.Size(181, 25);
            this.txtDniEliminar.TabIndex = 3;
            // 
            // lblDniEliminar
            // 
            this.lblDniEliminar.AutoSize = true;
            this.lblDniEliminar.Location = new System.Drawing.Point(12, 87);
            this.lblDniEliminar.Name = "lblDniEliminar";
            this.lblDniEliminar.Size = new System.Drawing.Size(165, 17);
            this.lblDniEliminar.TabIndex = 4;
            this.lblDniEliminar.Text = "DNI de compra a eliminar:";
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnArchivo.Location = new System.Drawing.Point(12, 189);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(285, 45);
            this.btnArchivo.TabIndex = 5;
            this.btnArchivo.Text = "Leer/Escribir en Archivo";
            this.btnArchivo.UseVisualStyleBackColor = false;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // btnXml
            // 
            this.btnXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXml.Location = new System.Drawing.Point(12, 240);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(285, 45);
            this.btnXml.TabIndex = 6;
            this.btnXml.Text = "Leer/Escribir XML";
            this.btnXml.UseVisualStyleBackColor = false;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(199, 107);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 25);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnHarcode
            // 
            this.btnHarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHarcode.Location = new System.Drawing.Point(12, 291);
            this.btnHarcode.Name = "btnHarcode";
            this.btnHarcode.Size = new System.Drawing.Size(285, 45);
            this.btnHarcode.TabIndex = 9;
            this.btnHarcode.Text = "Agregar clientes automaticamente";
            this.btnHarcode.UseVisualStyleBackColor = false;
            this.btnHarcode.Click += new System.EventHandler(this.btnHarcode_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 357);
            this.Controls.Add(this.btnHarcode);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.lblDniEliminar);
            this.Controls.Add(this.txtDniEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstCompras);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstCompras;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDniEliminar;
        private System.Windows.Forms.Label lblDniEliminar;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnHarcode;
    }
}

