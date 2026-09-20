namespace Actividad_2._1_Diseño_e_implenacion_de_Modelos
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer? components = null;

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
            components = new System.ComponentModel.Container();
            pnlContenedorVistas = new Panel();
            tabModulos = new TabControl();
            tabBeneficiario = new TabPage();
            tabCategoria = new TabPage();
            tabDonacion = new TabPage();
            tabDonante = new TabPage();
            tabEvento = new TabPage();
            tabOrganizacion = new TabPage();
            tabProgramaSocial = new TabPage();
            tabTestimonio = new TabPage();
            tabVoluntario = new TabPage();
            tabAdministrador = new TabPage();
            pnlBusqueda = new Panel();
            lblTitulo = new Label();
            lblIdBusqueda = new Label();
            txtIdBusqueda = new TextBox();
            btnMasterBuscar = new Button();
            pnlAcciones = new Panel();
            flpAcciones = new FlowLayoutPanel();
            btnMasterGuardar = new Button();
            btnMasterActualizar = new Button();
            btnMasterEliminar = new Button();
            stsBarraEstado = new StatusStrip();
            lblEstado = new ToolStripStatusLabel();
            lblAutores = new ToolStripStatusLabel();
            errProvider = new ErrorProvider(components);
            tabModulos.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlAcciones.SuspendLayout();
            flpAcciones.SuspendLayout();
            stsBarraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // pnlContenedorVistas
            // 
            pnlContenedorVistas.Dock = DockStyle.Fill;
            pnlContenedorVistas.Location = new Point(0, 122);
            pnlContenedorVistas.Name = "pnlContenedorVistas";
            pnlContenedorVistas.Size = new Size(1000, 486);
            pnlContenedorVistas.TabIndex = 0;
            // 
            // tabModulos
            // 
            tabModulos.Controls.Add(tabBeneficiario);
            tabModulos.Controls.Add(tabCategoria);
            tabModulos.Controls.Add(tabDonacion);
            tabModulos.Controls.Add(tabDonante);
            tabModulos.Controls.Add(tabEvento);
            tabModulos.Controls.Add(tabOrganizacion);
            tabModulos.Controls.Add(tabProgramaSocial);
            tabModulos.Controls.Add(tabTestimonio);
            tabModulos.Controls.Add(tabVoluntario);
            tabModulos.Controls.Add(tabAdministrador);
            tabModulos.Dock = DockStyle.Top;
            tabModulos.Location = new Point(0, 64);
            tabModulos.Multiline = true;
            tabModulos.Name = "tabModulos";
            tabModulos.SelectedIndex = 0;
            tabModulos.Size = new Size(1000, 58);
            tabModulos.TabIndex = 1;
            tabModulos.SelectedIndexChanged += tabModulos_SelectedIndexChanged;
            // 
            // tabBeneficiario
            // 
            tabBeneficiario.Location = new Point(4, 24);
            tabBeneficiario.Name = "tabBeneficiario";
            tabBeneficiario.Padding = new Padding(3);
            tabBeneficiario.Size = new Size(992, 30);
            tabBeneficiario.TabIndex = 0;
            tabBeneficiario.Text = "Beneficiario";
            tabBeneficiario.UseVisualStyleBackColor = true;
            // 
            // tabCategoria
            // 
            tabCategoria.Location = new Point(4, 24);
            tabCategoria.Name = "tabCategoria";
            tabCategoria.Padding = new Padding(3);
            tabCategoria.Size = new Size(992, 30);
            tabCategoria.TabIndex = 1;
            tabCategoria.Text = "Categoría";
            tabCategoria.UseVisualStyleBackColor = true;
            // 
            // tabDonacion
            // 
            tabDonacion.Location = new Point(4, 24);
            tabDonacion.Name = "tabDonacion";
            tabDonacion.Padding = new Padding(3);
            tabDonacion.Size = new Size(992, 30);
            tabDonacion.TabIndex = 2;
            tabDonacion.Text = "Donación";
            tabDonacion.UseVisualStyleBackColor = true;
            // 
            // tabDonante
            // 
            tabDonante.Location = new Point(4, 24);
            tabDonante.Name = "tabDonante";
            tabDonante.Padding = new Padding(3);
            tabDonante.Size = new Size(992, 30);
            tabDonante.TabIndex = 3;
            tabDonante.Text = "Donante";
            tabDonante.UseVisualStyleBackColor = true;
            // 
            // tabEvento
            // 
            tabEvento.Location = new Point(4, 24);
            tabEvento.Name = "tabEvento";
            tabEvento.Padding = new Padding(3);
            tabEvento.Size = new Size(992, 30);
            tabEvento.TabIndex = 4;
            tabEvento.Text = "Evento";
            tabEvento.UseVisualStyleBackColor = true;
            // 
            // tabOrganizacion
            // 
            tabOrganizacion.Location = new Point(4, 24);
            tabOrganizacion.Name = "tabOrganizacion";
            tabOrganizacion.Padding = new Padding(3);
            tabOrganizacion.Size = new Size(992, 30);
            tabOrganizacion.TabIndex = 5;
            tabOrganizacion.Text = "Organización";
            tabOrganizacion.UseVisualStyleBackColor = true;
            // 
            // tabProgramaSocial
            // 
            tabProgramaSocial.Location = new Point(4, 24);
            tabProgramaSocial.Name = "tabProgramaSocial";
            tabProgramaSocial.Padding = new Padding(3);
            tabProgramaSocial.Size = new Size(992, 30);
            tabProgramaSocial.TabIndex = 6;
            tabProgramaSocial.Text = "Programa Social";
            tabProgramaSocial.UseVisualStyleBackColor = true;
            // 
            // tabTestimonio
            // 
            tabTestimonio.Location = new Point(4, 24);
            tabTestimonio.Name = "tabTestimonio";
            tabTestimonio.Padding = new Padding(3);
            tabTestimonio.Size = new Size(992, 30);
            tabTestimonio.TabIndex = 7;
            tabTestimonio.Text = "Testimonio";
            tabTestimonio.UseVisualStyleBackColor = true;
            // 
            // tabVoluntario
            // 
            tabVoluntario.Location = new Point(4, 24);
            tabVoluntario.Name = "tabVoluntario";
            tabVoluntario.Padding = new Padding(3);
            tabVoluntario.Size = new Size(992, 30);
            tabVoluntario.TabIndex = 8;
            tabVoluntario.Text = "Voluntario";
            tabVoluntario.UseVisualStyleBackColor = true;
            // 
            // tabAdministrador
            // 
            tabAdministrador.Location = new Point(4, 24);
            tabAdministrador.Name = "tabAdministrador";
            tabAdministrador.Padding = new Padding(3);
            tabAdministrador.Size = new Size(992, 30);
            tabAdministrador.TabIndex = 9;
            tabAdministrador.Text = "Administrador";
            tabAdministrador.UseVisualStyleBackColor = true;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.FromArgb(31, 78, 121);
            pnlBusqueda.Controls.Add(btnMasterBuscar);
            pnlBusqueda.Controls.Add(txtIdBusqueda);
            pnlBusqueda.Controls.Add(lblIdBusqueda);
            pnlBusqueda.Controls.Add(lblTitulo);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 0);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1000, 64);
            pnlBusqueda.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(16, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(380, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Directorio ONG - Gestión de entidades";
            // 
            // lblIdBusqueda
            // 
            lblIdBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIdBusqueda.AutoSize = true;
            lblIdBusqueda.ForeColor = Color.White;
            lblIdBusqueda.Location = new Point(538, 23);
            lblIdBusqueda.Name = "lblIdBusqueda";
            lblIdBusqueda.Size = new Size(72, 15);
            lblIdBusqueda.TabIndex = 1;
            lblIdBusqueda.Text = "ID a buscar:";
            // 
            // txtIdBusqueda
            // 
            txtIdBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIdBusqueda.Location = new Point(618, 20);
            txtIdBusqueda.Name = "txtIdBusqueda";
            txtIdBusqueda.PlaceholderText = "CURP, RFC, folio o ID";
            txtIdBusqueda.Size = new Size(240, 23);
            txtIdBusqueda.TabIndex = 2;
            txtIdBusqueda.KeyDown += txtIdBusqueda_KeyDown;
            // 
            // btnMasterBuscar
            // 
            btnMasterBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasterBuscar.BackColor = Color.FromArgb(0, 150, 136);
            btnMasterBuscar.FlatAppearance.BorderSize = 0;
            btnMasterBuscar.FlatStyle = FlatStyle.Flat;
            btnMasterBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasterBuscar.ForeColor = Color.White;
            btnMasterBuscar.Location = new Point(866, 14);
            btnMasterBuscar.Name = "btnMasterBuscar";
            btnMasterBuscar.Size = new Size(118, 36);
            btnMasterBuscar.TabIndex = 3;
            btnMasterBuscar.Text = "Buscar";
            btnMasterBuscar.UseVisualStyleBackColor = false;
            btnMasterBuscar.Click += btnMasterBuscar_Click;
            // 
            // pnlAcciones
            // 
            pnlAcciones.Controls.Add(flpAcciones);
            pnlAcciones.Dock = DockStyle.Bottom;
            pnlAcciones.Location = new Point(0, 608);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(1000, 60);
            pnlAcciones.TabIndex = 3;
            // 
            // flpAcciones
            // 
            flpAcciones.Controls.Add(btnMasterGuardar);
            flpAcciones.Controls.Add(btnMasterActualizar);
            flpAcciones.Controls.Add(btnMasterEliminar);
            flpAcciones.Dock = DockStyle.Fill;
            flpAcciones.Location = new Point(0, 0);
            flpAcciones.Name = "flpAcciones";
            flpAcciones.Padding = new Padding(16, 9, 0, 0);
            flpAcciones.Size = new Size(1000, 60);
            flpAcciones.TabIndex = 0;
            // 
            // btnMasterGuardar
            // 
            btnMasterGuardar.BackColor = Color.FromArgb(46, 125, 50);
            btnMasterGuardar.FlatAppearance.BorderSize = 0;
            btnMasterGuardar.FlatStyle = FlatStyle.Flat;
            btnMasterGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasterGuardar.ForeColor = Color.White;
            btnMasterGuardar.Location = new Point(19, 12);
            btnMasterGuardar.Name = "btnMasterGuardar";
            btnMasterGuardar.Size = new Size(150, 40);
            btnMasterGuardar.TabIndex = 0;
            btnMasterGuardar.Text = "Guardar";
            btnMasterGuardar.UseVisualStyleBackColor = false;
            btnMasterGuardar.Click += btnMasterGuardar_Click;
            // 
            // btnMasterActualizar
            // 
            btnMasterActualizar.BackColor = Color.FromArgb(25, 118, 210);
            btnMasterActualizar.FlatAppearance.BorderSize = 0;
            btnMasterActualizar.FlatStyle = FlatStyle.Flat;
            btnMasterActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasterActualizar.ForeColor = Color.White;
            btnMasterActualizar.Location = new Point(175, 12);
            btnMasterActualizar.Name = "btnMasterActualizar";
            btnMasterActualizar.Size = new Size(150, 40);
            btnMasterActualizar.TabIndex = 1;
            btnMasterActualizar.Text = "Actualizar";
            btnMasterActualizar.UseVisualStyleBackColor = false;
            btnMasterActualizar.Click += btnMasterActualizar_Click;
            // 
            // btnMasterEliminar
            // 
            btnMasterEliminar.BackColor = Color.FromArgb(198, 40, 40);
            btnMasterEliminar.FlatAppearance.BorderSize = 0;
            btnMasterEliminar.FlatStyle = FlatStyle.Flat;
            btnMasterEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasterEliminar.ForeColor = Color.White;
            btnMasterEliminar.Location = new Point(331, 12);
            btnMasterEliminar.Name = "btnMasterEliminar";
            btnMasterEliminar.Size = new Size(150, 40);
            btnMasterEliminar.TabIndex = 2;
            btnMasterEliminar.Text = "Eliminar";
            btnMasterEliminar.UseVisualStyleBackColor = false;
            btnMasterEliminar.Click += btnMasterEliminar_Click;
            // 
            // stsBarraEstado
            // 
            stsBarraEstado.Items.AddRange(new ToolStripItem[] { lblEstado, lblAutores });
            stsBarraEstado.Location = new Point(0, 668);
            stsBarraEstado.Name = "stsBarraEstado";
            stsBarraEstado.Size = new Size(1000, 22);
            stsBarraEstado.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(580, 17);
            lblEstado.Spring = true;
            lblEstado.Text = "Listo.";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAutores
            // 
            lblAutores.Name = "lblAutores";
            lblAutores.Size = new Size(400, 17);
            lblAutores.Text = "Equipo #1: Gonzalez Vega Marco Antonio | Landa Lopez Oscar Tadeo";
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 690);
            Controls.Add(pnlContenedorVistas);
            Controls.Add(tabModulos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlAcciones);
            Controls.Add(stsBarraEstado);
            MinimumSize = new Size(1000, 660);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Directorio ONG - Actividad 2.4";
            Load += FrmPrincipal_Load;
            tabModulos.ResumeLayout(false);
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlAcciones.ResumeLayout(false);
            flpAcciones.ResumeLayout(false);
            stsBarraEstado.ResumeLayout(false);
            stsBarraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlContenedorVistas;
        private TabControl tabModulos;
        private TabPage tabBeneficiario;
        private TabPage tabCategoria;
        private TabPage tabDonacion;
        private TabPage tabDonante;
        private TabPage tabEvento;
        private TabPage tabOrganizacion;
        private TabPage tabProgramaSocial;
        private TabPage tabTestimonio;
        private TabPage tabVoluntario;
        private TabPage tabAdministrador;
        private Panel pnlBusqueda;
        private Label lblTitulo;
        private Label lblIdBusqueda;
        private TextBox txtIdBusqueda;
        private Button btnMasterBuscar;
        private Panel pnlAcciones;
        private FlowLayoutPanel flpAcciones;
        private Button btnMasterGuardar;
        private Button btnMasterActualizar;
        private Button btnMasterEliminar;
        private StatusStrip stsBarraEstado;
        private ToolStripStatusLabel lblEstado;
        private ToolStripStatusLabel lblAutores;
        private ErrorProvider errProvider;
    }
}
