
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtImprimir = new System.Windows.Forms.TextBox();
            this.lblImprimir = new System.Windows.Forms.Label();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.btnCargaBaseDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(12, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(285, 45);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar compra";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstCompras
            // 
            this.lstCompras.FormattingEnabled = true;
            this.lstCompras.ItemHeight = 17;
            this.lstCompras.Location = new System.Drawing.Point(303, 25);
            this.lstCompras.Name = "lstCompras";
            this.lstCompras.Size = new System.Drawing.Size(764, 446);
            this.lstCompras.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Location = new System.Drawing.Point(12, 124);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(285, 45);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtDniEliminar
            // 
            this.txtDniEliminar.Location = new System.Drawing.Point(12, 93);
            this.txtDniEliminar.Name = "txtDniEliminar";
            this.txtDniEliminar.Size = new System.Drawing.Size(181, 25);
            this.txtDniEliminar.TabIndex = 3;
            // 
            // lblDniEliminar
            // 
            this.lblDniEliminar.AutoSize = true;
            this.lblDniEliminar.Location = new System.Drawing.Point(12, 73);
            this.lblDniEliminar.Name = "lblDniEliminar";
            this.lblDniEliminar.Size = new System.Drawing.Size(165, 17);
            this.lblDniEliminar.TabIndex = 4;
            this.lblDniEliminar.Text = "DNI de compra a eliminar:";
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnArchivo.Location = new System.Drawing.Point(12, 175);
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
            this.btnXml.Location = new System.Drawing.Point(12, 226);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(285, 45);
            this.btnXml.TabIndex = 6;
            this.btnXml.Text = "Leer/Escribir XML";
            this.btnXml.UseVisualStyleBackColor = false;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(199, 93);
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
            this.btnHarcode.Location = new System.Drawing.Point(12, 376);
            this.btnHarcode.Name = "btnHarcode";
            this.btnHarcode.Size = new System.Drawing.Size(285, 45);
            this.btnHarcode.TabIndex = 9;
            this.btnHarcode.Text = "Agregar clientes automaticamente";
            this.btnHarcode.UseVisualStyleBackColor = false;
            this.btnHarcode.Click += new System.EventHandler(this.btnHarcode_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnImprimir.Location = new System.Drawing.Point(12, 325);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(285, 45);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir ticket";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtImprimir
            // 
            this.txtImprimir.Location = new System.Drawing.Point(12, 294);
            this.txtImprimir.Name = "txtImprimir";
            this.txtImprimir.Size = new System.Drawing.Size(181, 25);
            this.txtImprimir.TabIndex = 11;
            // 
            // lblImprimir
            // 
            this.lblImprimir.AutoSize = true;
            this.lblImprimir.Location = new System.Drawing.Point(12, 274);
            this.lblImprimir.Name = "lblImprimir";
            this.lblImprimir.Size = new System.Drawing.Size(155, 17);
            this.lblImprimir.TabIndex = 12;
            this.lblImprimir.Text = "DNI de ticket a imprimir:";
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Location = new System.Drawing.Point(199, 294);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(98, 25);
            this.btnLimpiar2.TabIndex = 13;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            // 
            // btnCargaBaseDatos
            // 
            this.btnCargaBaseDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCargaBaseDatos.Location = new System.Drawing.Point(12, 427);
            this.btnCargaBaseDatos.Name = "btnCargaBaseDatos";
            this.btnCargaBaseDatos.Size = new System.Drawing.Size(285, 45);
            this.btnCargaBaseDatos.TabIndex = 14;
            this.btnCargaBaseDatos.Text = "Agregar clientes desde base de datos";
            this.btnCargaBaseDatos.UseVisualStyleBackColor = false;
            this.btnCargaBaseDatos.Click += new System.EventHandler(this.btnCargaBaseDatos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 491);
            this.Controls.Add(this.btnCargaBaseDatos);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.lblImprimir);
            this.Controls.Add(this.txtImprimir);
            this.Controls.Add(this.btnImprimir);
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
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtImprimir;
        private System.Windows.Forms.Label lblImprimir;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnCargaBaseDatos;
    }
}

