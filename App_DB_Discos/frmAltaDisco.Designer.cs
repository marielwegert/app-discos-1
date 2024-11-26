namespace winform_app
{
    partial class frmAltaDisco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaDisco));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblCantCanciones = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCantCanciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboTipoEdicion = new System.Windows.Forms.ComboBox();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.pbxDisco = new System.Windows.Forms.PictureBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lblErrorTitulo = new System.Windows.Forms.Label();
            this.lblErrorFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblErrorTipoEdicion = new System.Windows.Forms.Label();
            this.lblErrorEstilo = new System.Windows.Forms.Label();
            this.lblErrorCantCanciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitulo.Location = new System.Drawing.Point(142, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(60, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLanzamiento.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(37, 83);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(165, 22);
            this.lblFechaLanzamiento.TabIndex = 1;
            this.lblFechaLanzamiento.Text = "Fecha lanzamiento:";
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCanciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCantCanciones.Location = new System.Drawing.Point(29, 154);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(173, 22);
            this.lblCantCanciones.TabIndex = 2;
            this.lblCantCanciones.Text = "Cantidad canciones:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(208, 12);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(197, 26);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtCantCanciones
            // 
            this.txtCantCanciones.Location = new System.Drawing.Point(208, 152);
            this.txtCantCanciones.Name = "txtCantCanciones";
            this.txtCantCanciones.Size = new System.Drawing.Size(197, 26);
            this.txtCantCanciones.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar.Location = new System.Drawing.Point(187, 432);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(106, 35);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.Location = new System.Drawing.Point(299, 432);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstilo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEstilo.Location = new System.Drawing.Point(142, 296);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(59, 22);
            this.lblEstilo.TabIndex = 8;
            this.lblEstilo.Text = "Estilo:";
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(208, 292);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(197, 28);
            this.cboEstilo.TabIndex = 5;
            // 
            // cboTipoEdicion
            // 
            this.cboTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEdicion.FormattingEnabled = true;
            this.cboTipoEdicion.Location = new System.Drawing.Point(208, 364);
            this.cboTipoEdicion.Name = "cboTipoEdicion";
            this.cboTipoEdicion.Size = new System.Drawing.Size(197, 28);
            this.cboTipoEdicion.TabIndex = 6;
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEdicion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTipoEdicion.Location = new System.Drawing.Point(63, 367);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(138, 22);
            this.lblTipoEdicion.TabIndex = 11;
            this.lblTipoEdicion.Text = "Tipo de edicion:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(208, 222);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(197, 26);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUrlImagen.Location = new System.Drawing.Point(129, 225);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(73, 22);
            this.lblUrlImagen.TabIndex = 12;
            this.lblUrlImagen.Text = "Imagen:";
            // 
            // pbxDisco
            // 
            this.pbxDisco.Location = new System.Drawing.Point(462, 12);
            this.pbxDisco.Name = "pbxDisco";
            this.pbxDisco.Size = new System.Drawing.Size(295, 257);
            this.pbxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDisco.TabIndex = 14;
            this.pbxDisco.TabStop = false;
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Checked = false;
            this.dtpFechaLanzamiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(208, 82);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.ShowCheckBox = true;
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(197, 26);
            this.dtpFechaLanzamiento.TabIndex = 1;
            this.dtpFechaLanzamiento.Value = new System.DateTime(2024, 7, 21, 22, 38, 25, 0);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(411, 218);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(42, 35);
            this.btnAgregarImagen.TabIndex = 4;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // lblErrorTitulo
            // 
            this.lblErrorTitulo.AutoSize = true;
            this.lblErrorTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitulo.Location = new System.Drawing.Point(109, 51);
            this.lblErrorTitulo.Name = "lblErrorTitulo";
            this.lblErrorTitulo.Size = new System.Drawing.Size(0, 20);
            this.lblErrorTitulo.TabIndex = 17;
            // 
            // lblErrorFechaLanzamiento
            // 
            this.lblErrorFechaLanzamiento.AutoSize = true;
            this.lblErrorFechaLanzamiento.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorFechaLanzamiento.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaLanzamiento.Location = new System.Drawing.Point(109, 119);
            this.lblErrorFechaLanzamiento.Name = "lblErrorFechaLanzamiento";
            this.lblErrorFechaLanzamiento.Size = new System.Drawing.Size(0, 20);
            this.lblErrorFechaLanzamiento.TabIndex = 18;
            // 
            // lblErrorTipoEdicion
            // 
            this.lblErrorTipoEdicion.AutoSize = true;
            this.lblErrorTipoEdicion.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorTipoEdicion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTipoEdicion.Location = new System.Drawing.Point(109, 403);
            this.lblErrorTipoEdicion.Name = "lblErrorTipoEdicion";
            this.lblErrorTipoEdicion.Size = new System.Drawing.Size(0, 20);
            this.lblErrorTipoEdicion.TabIndex = 19;
            // 
            // lblErrorEstilo
            // 
            this.lblErrorEstilo.AutoSize = true;
            this.lblErrorEstilo.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorEstilo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEstilo.Location = new System.Drawing.Point(109, 331);
            this.lblErrorEstilo.Name = "lblErrorEstilo";
            this.lblErrorEstilo.Size = new System.Drawing.Size(0, 20);
            this.lblErrorEstilo.TabIndex = 20;
            // 
            // lblErrorCantCanciones
            // 
            this.lblErrorCantCanciones.AutoSize = true;
            this.lblErrorCantCanciones.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorCantCanciones.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCantCanciones.Location = new System.Drawing.Point(109, 195);
            this.lblErrorCantCanciones.Name = "lblErrorCantCanciones";
            this.lblErrorCantCanciones.Size = new System.Drawing.Size(0, 20);
            this.lblErrorCantCanciones.TabIndex = 21;
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(769, 490);
            this.Controls.Add(this.lblErrorCantCanciones);
            this.Controls.Add(this.lblErrorEstilo);
            this.Controls.Add(this.lblErrorTipoEdicion);
            this.Controls.Add(this.lblErrorFechaLanzamiento);
            this.Controls.Add(this.lblErrorTitulo);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.pbxDisco);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblTipoEdicion);
            this.Controls.Add(this.cboTipoEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCantCanciones);
            this.Controls.Add(this.lblFechaLanzamiento);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Label lblCantCanciones;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCantCanciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboTipoEdicion;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.PictureBox pbxDisco;
        private System.Windows.Forms.Button btnAgregarImagen;
        public System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Label lblErrorTitulo;
        private System.Windows.Forms.Label lblErrorFechaLanzamiento;
        private System.Windows.Forms.Label lblErrorTipoEdicion;
        private System.Windows.Forms.Label lblErrorEstilo;
        private System.Windows.Forms.Label lblErrorCantCanciones;
    }
}