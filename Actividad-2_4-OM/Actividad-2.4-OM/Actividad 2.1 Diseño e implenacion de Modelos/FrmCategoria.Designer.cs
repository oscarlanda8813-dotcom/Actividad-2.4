namespace Actividad_2._1_Diseño_e_implenacion_de_Modelos
{
    partial class FrmCategoria
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
            lblNombreCategoria = new Label();
            txtNombreCategoria = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblEstadoActivo = new Label();
            chkEstadoActivo = new CheckBox();
            tlpCampos = new TableLayoutPanel();
            grpDatos = new GroupBox();
            picImagen = new PictureBox();
            txtRutaImagen = new TextBox();
            btnExaminar = new Button();
            grpImagen = new GroupBox();
            txtResultado = new TextBox();
            grpResultado = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            pnlFormularioBase.SuspendLayout();
            grpDatos.SuspendLayout();
            tlpCampos.SuspendLayout();
            grpImagen.SuspendLayout();
            grpResultado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFormularioBase (heredado de FrmBase)
            // 
            pnlFormularioBase.Controls.Add(grpResultado);
            pnlFormularioBase.Controls.Add(grpImagen);
            pnlFormularioBase.Controls.Add(grpDatos);
            // 
            // grpDatos
            // 
            grpDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDatos.Controls.Add(tlpCampos);
            grpDatos.Location = new Point(20, 60);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(520, 250);
            grpDatos.TabIndex = 2;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de Categoría";
            // 
            // tlpCampos
            // 
            tlpCampos.ColumnCount = 2;
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCampos.Controls.Add(lblNombreCategoria, 0, 0);
            tlpCampos.Controls.Add(txtNombreCategoria, 1, 0);
            tlpCampos.Controls.Add(lblDescripcion, 0, 1);
            tlpCampos.Controls.Add(txtDescripcion, 1, 1);
            tlpCampos.Controls.Add(lblEstadoActivo, 0, 2);
            tlpCampos.Controls.Add(chkEstadoActivo, 1, 2);
            tlpCampos.Dock = DockStyle.Fill;
            tlpCampos.Location = new Point(3, 19);
            tlpCampos.Name = "tlpCampos";
            tlpCampos.RowCount = 3;
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpCampos.Size = new Size(514, 228);
            tlpCampos.TabIndex = 0;
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.Anchor = AnchorStyles.Left;
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Location = new Point(3, 12);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(110, 15);
            lblNombreCategoria.TabIndex = 0;
            lblNombreCategoria.Text = "Nombre:";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreCategoria.Location = new Point(168, 8);
            txtNombreCategoria.MaxLength = 100;
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(343, 23);
            txtNombreCategoria.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.Left;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(3, 12);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(110, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Dock = DockStyle.Fill;
            txtDescripcion.Location = new Point(168, 3);
            txtDescripcion.MaxLength = 200;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(343, 76);
            txtDescripcion.TabIndex = 3;
            // 
            // lblEstadoActivo
            // 
            lblEstadoActivo.Anchor = AnchorStyles.Left;
            lblEstadoActivo.AutoSize = true;
            lblEstadoActivo.Location = new Point(3, 12);
            lblEstadoActivo.Name = "lblEstadoActivo";
            lblEstadoActivo.Size = new Size(45, 15);
            lblEstadoActivo.TabIndex = 4;
            lblEstadoActivo.Text = "Estado:";
            // 
            // chkEstadoActivo
            // 
            chkEstadoActivo.Anchor = AnchorStyles.Left;
            chkEstadoActivo.AutoSize = true;
            chkEstadoActivo.Checked = true;
            chkEstadoActivo.CheckState = CheckState.Checked;
            chkEstadoActivo.Location = new Point(168, 10);
            chkEstadoActivo.Name = "chkEstadoActivo";
            chkEstadoActivo.Size = new Size(62, 19);
            chkEstadoActivo.TabIndex = 5;
            chkEstadoActivo.Text = "Activo";
            chkEstadoActivo.UseVisualStyleBackColor = true;
            // 
            // grpImagen
            // 
            grpImagen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpImagen.Controls.Add(btnExaminar);
            grpImagen.Controls.Add(txtRutaImagen);
            grpImagen.Controls.Add(picImagen);
            grpImagen.Location = new Point(560, 60);
            grpImagen.Name = "grpImagen";
            grpImagen.Size = new Size(320, 250);
            grpImagen.TabIndex = 3;
            grpImagen.TabStop = false;
            grpImagen.Text = "Imagen (RutaImagen)";
            // 
            // picImagen
            // 
            picImagen.BorderStyle = BorderStyle.FixedSingle;
            picImagen.Location = new Point(15, 25);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(290, 165);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // txtRutaImagen
            // 
            txtRutaImagen.Location = new Point(15, 205);
            txtRutaImagen.Name = "txtRutaImagen";
            txtRutaImagen.ReadOnly = true;
            txtRutaImagen.Size = new Size(200, 23);
            txtRutaImagen.TabIndex = 1;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(222, 203);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(83, 27);
            btnExaminar.TabIndex = 2;
            btnExaminar.Text = "Examinar...";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // grpResultado
            // 
            grpResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpResultado.Controls.Add(txtResultado);
            grpResultado.Location = new Point(20, 325);
            grpResultado.Name = "grpResultado";
            grpResultado.Size = new Size(860, 185);
            grpResultado.TabIndex = 4;
            grpResultado.TabStop = false;
            grpResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Window;
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(3, 19);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(854, 163);
            txtResultado.TabIndex = 0;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 530);
            Name = "FrmCategoria";
            Text = "Categoría";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            grpDatos.ResumeLayout(false);
            tlpCampos.ResumeLayout(false);
            tlpCampos.PerformLayout();
            grpImagen.ResumeLayout(false);
            grpImagen.PerformLayout();
            grpResultado.ResumeLayout(false);
            grpResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombreCategoria;
        private TextBox txtNombreCategoria;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblEstadoActivo;
        private CheckBox chkEstadoActivo;
        private TableLayoutPanel tlpCampos;
        private GroupBox grpDatos;
        private PictureBox picImagen;
        private TextBox txtRutaImagen;
        private Button btnExaminar;
        private GroupBox grpImagen;
        private TextBox txtResultado;
        private GroupBox grpResultado;
    }
}
