namespace Actividad_2._1_Diseño_e_implenacion_de_Modelos
{
    partial class FrmBeneficiario
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
            lblNombreCompleto = new Label();
            txtNombreCompleto = new TextBox();
            lblEdad = new Label();
            nudEdad = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
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
            grpDatos.Text = "Datos de Beneficiario";
            // 
            // tlpCampos
            // 
            tlpCampos.ColumnCount = 2;
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCampos.Controls.Add(lblNombreCompleto, 0, 0);
            tlpCampos.Controls.Add(txtNombreCompleto, 1, 0);
            tlpCampos.Controls.Add(lblEdad, 0, 1);
            tlpCampos.Controls.Add(nudEdad, 1, 1);
            tlpCampos.Controls.Add(lblEstadoActivo, 0, 2);
            tlpCampos.Controls.Add(chkEstadoActivo, 1, 2);
            tlpCampos.Dock = DockStyle.Fill;
            tlpCampos.Location = new Point(3, 19);
            tlpCampos.Name = "tlpCampos";
            tlpCampos.RowCount = 3;
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpCampos.Size = new Size(514, 228);
            tlpCampos.TabIndex = 0;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.Anchor = AnchorStyles.Left;
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(3, 12);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(110, 15);
            lblNombreCompleto.TabIndex = 0;
            lblNombreCompleto.Text = "Nombre completo:";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreCompleto.Location = new Point(168, 8);
            txtNombreCompleto.MaxLength = 100;
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(343, 23);
            txtNombreCompleto.TabIndex = 1;
            // 
            // lblEdad
            // 
            lblEdad.Anchor = AnchorStyles.Left;
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(3, 12);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(110, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad (años):";
            // 
            // nudEdad
            // 
            nudEdad.Anchor = AnchorStyles.Left;
            nudEdad.Location = new Point(168, 8);
            nudEdad.Maximum = 120m;
            nudEdad.Minimum = 0m;
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(140, 23);
            nudEdad.TabIndex = 3;
            nudEdad.Value = 0m;
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
            // FrmBeneficiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 530);
            Name = "FrmBeneficiario";
            Text = "Beneficiario";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            grpDatos.ResumeLayout(false);
            tlpCampos.ResumeLayout(false);
            tlpCampos.PerformLayout();
            grpImagen.ResumeLayout(false);
            grpImagen.PerformLayout();
            grpResultado.ResumeLayout(false);
            grpResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombreCompleto;
        private TextBox txtNombreCompleto;
        private Label lblEdad;
        private NumericUpDown nudEdad;
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
