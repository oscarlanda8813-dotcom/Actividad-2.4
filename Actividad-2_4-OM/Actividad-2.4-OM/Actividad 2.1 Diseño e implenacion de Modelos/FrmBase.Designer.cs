namespace Actividad_2._1_Diseño_e_implenacion_de_Modelos
{
    partial class FrmBase
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
            pnlFormularioBase = new Panel();
            txtId = new TextBox();
            lblId = new Label();
            pnlFormularioBase.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(txtId);
            pnlFormularioBase.Controls.Add(lblId);
            pnlFormularioBase.Dock = DockStyle.Fill;
            pnlFormularioBase.Location = new Point(0, 0);
            pnlFormularioBase.Name = "pnlFormularioBase";
            pnlFormularioBase.Size = new Size(900, 530);
            pnlFormularioBase.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(130, 19);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 23);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(20, 22);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 530);
            Controls.Add(pnlFormularioBase);
            Name = "FrmBase";
            Text = "FrmBase";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Modifiers = Protected: permite que los formularios hijos (herencia visual) usen y llenen estos controles.
        protected Panel pnlFormularioBase;
        protected TextBox txtId;
        protected Label lblId;
    }
}
