namespace winform_app
{
    partial class frmDisco
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisco));
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pbxDisco = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.lblErrorCampo = new System.Windows.Forms.Label();
            this.lblErrorCriterio = new System.Windows.Forms.Label();
            this.lblSeleccionDisco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.AllowUserToAddRows = false;
            this.dgvDiscos.AllowUserToDeleteRows = false;
            this.dgvDiscos.AllowUserToResizeColumns = false;
            this.dgvDiscos.AllowUserToResizeRows = false;
            this.dgvDiscos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiscos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvDiscos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiscos.ColumnHeadersHeight = 34;
            this.dgvDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiscos.Location = new System.Drawing.Point(12, 38);
            this.dgvDiscos.MultiSelect = false;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.RowHeadersWidth = 62;
            this.dgvDiscos.RowTemplate.Height = 28;
            this.dgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscos.Size = new System.Drawing.Size(851, 412);
            this.dgvDiscos.StandardTab = true;
            this.dgvDiscos.TabIndex = 1;
            this.dgvDiscos.VirtualMode = true;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // pbxDisco
            // 
            this.pbxDisco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxDisco.Location = new System.Drawing.Point(869, 38);
            this.pbxDisco.Name = "pbxDisco";
            this.pbxDisco.Size = new System.Drawing.Size(397, 412);
            this.pbxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDisco.TabIndex = 1;
            this.pbxDisco.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregar.Location = new System.Drawing.Point(12, 456);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 37);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModificar.Location = new System.Drawing.Point(131, 457);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 37);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEliminarFisico.FlatAppearance.BorderSize = 0;
            this.btnEliminarFisico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.btnEliminarFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFisico.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarFisico.Location = new System.Drawing.Point(250, 457);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(113, 37);
            this.btnEliminarFisico.TabIndex = 4;
            this.btnEliminarFisico.Text = "Eliminar";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroRapido.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFiltroRapido.Location = new System.Drawing.Point(12, 9);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(117, 22);
            this.lblFiltroRapido.TabIndex = 5;
            this.lblFiltroRapido.Text = "Filtro Rápido:";
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltroRapido.Location = new System.Drawing.Point(135, 6);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(194, 26);
            this.txtFiltroRapido.TabIndex = 0;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.txtFiltroRapido_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFiltro.Location = new System.Drawing.Point(896, 496);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(90, 37);
            this.btnFiltro.TabIndex = 8;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCampo.Location = new System.Drawing.Point(16, 503);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(72, 22);
            this.lblCampo.TabIndex = 6;
            this.lblCampo.Text = "Campo:";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(693, 496);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(197, 26);
            this.txtFiltroAvanzado.TabIndex = 7;
            // 
            // lblCriterio
            // 
            this.lblCriterio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCriterio.Location = new System.Drawing.Point(313, 503);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(73, 22);
            this.lblCriterio.TabIndex = 6;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cboCampo
            // 
            this.cboCampo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(94, 500);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(208, 28);
            this.cboCampo.TabIndex = 5;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(383, 500);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(148, 28);
            this.cboCriterio.TabIndex = 6;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(548, 503);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(139, 22);
            this.lblFiltroAvanzado.TabIndex = 11;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado:";
            // 
            // lblErrorCampo
            // 
            this.lblErrorCampo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblErrorCampo.AutoSize = true;
            this.lblErrorCampo.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorCampo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCampo.Location = new System.Drawing.Point(88, 544);
            this.lblErrorCampo.Name = "lblErrorCampo";
            this.lblErrorCampo.Size = new System.Drawing.Size(0, 20);
            this.lblErrorCampo.TabIndex = 12;
            // 
            // lblErrorCriterio
            // 
            this.lblErrorCriterio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblErrorCriterio.AutoSize = true;
            this.lblErrorCriterio.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorCriterio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCriterio.Location = new System.Drawing.Point(379, 544);
            this.lblErrorCriterio.Name = "lblErrorCriterio";
            this.lblErrorCriterio.Size = new System.Drawing.Size(0, 20);
            this.lblErrorCriterio.TabIndex = 13;
            // 
            // lblSeleccionDisco
            // 
            this.lblSeleccionDisco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSeleccionDisco.AutoSize = true;
            this.lblSeleccionDisco.ForeColor = System.Drawing.Color.Red;
            this.lblSeleccionDisco.Location = new System.Drawing.Point(360, 464);
            this.lblSeleccionDisco.Name = "lblSeleccionDisco";
            this.lblSeleccionDisco.Size = new System.Drawing.Size(0, 20);
            this.lblSeleccionDisco.TabIndex = 5;
            // 
            // frmDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1351, 573);
            this.Controls.Add(this.lblSeleccionDisco);
            this.Controls.Add(this.lblErrorCriterio);
            this.Controls.Add(this.lblErrorCampo);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxDisco);
            this.Controls.Add(this.dgvDiscos);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discos";
            this.Load += new System.EventHandler(this.frmDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pbxDisco;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Label lblErrorCampo;
        private System.Windows.Forms.Label lblErrorCriterio;
        private System.Windows.Forms.Label lblSeleccionDisco;
    }
}

