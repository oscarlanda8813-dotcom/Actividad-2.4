//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Formulario maestro: navega entre módulos y controla cualquier vista mediante el contrato IPanelCRUD

namespace Actividad_2._1_Diseño_e_implenacion_de_Modelos
{
    public partial class FrmPrincipal : Form
    {
        // Referencia polimórfica: el formulario maestro nunca conoce la clase concreta de la vista activa.
        private IPanelCRUD? vistaActiva;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object? sender, EventArgs e)
        {
            CargarModuloSeleccionado();
        }

        // ====================== Navegación (TabControl) ======================

        private void tabModulos_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CargarModuloSeleccionado();
        }

        private void CargarModuloSeleccionado()
        {
            switch (tabModulos.SelectedIndex)
            {
                case 0: MostrarVista(new FrmBeneficiario()); break;
                case 1: MostrarVista(new FrmCategoria()); break;
                case 2: MostrarVista(new FrmDonacion()); break;
                case 3: MostrarVista(new FrmDonante()); break;
                case 4: MostrarVista(new FrmEvento()); break;
                case 5: MostrarVista(new FrmOrganizacion()); break;
                case 6: MostrarVista(new FrmProgramaSocial()); break;
                case 7: MostrarVista(new FrmTestimonio()); break;
                case 8: MostrarVista(new FrmVoluntario()); break;
                case 9: MostrarVista(new FrmAdministrador()); break;
                default: return;
            }

            errProvider.Clear();
            txtIdBusqueda.Clear();
            lblEstado.Text = $"Módulo activo: {tabModulos.SelectedTab?.Text}";
        }

        /// <summary>
        /// Incrusta un formulario heredado dentro de pnlContenedorVistas y lo asigna a vistaActiva.
        /// La restricción de tipo garantiza en compilación que la vista es un Form que cumple IPanelCRUD.
        /// </summary>
        private void MostrarVista<T>(T vista) where T : Form, IPanelCRUD
        {
            if (vistaActiva is Form anterior)
            {
                pnlContenedorVistas.Controls.Remove(anterior);
                anterior.Dispose();
            }

            vista.TopLevel = false;
            vista.FormBorderStyle = FormBorderStyle.None;
            vista.Dock = DockStyle.Fill;

            pnlContenedorVistas.Controls.Add(vista);
            vistaActiva = vista;
            vista.Show();
        }

        // ====================== Botones maestros (polimorfismo) ======================

        private void btnMasterGuardar_Click(object? sender, EventArgs e)
        {
            vistaActiva?.EjecutarGuardar();
        }

        private void btnMasterBuscar_Click(object? sender, EventArgs e)
        {
            string id = txtIdBusqueda.Text.Trim();

            if (id.Length == 0)
            {
                errProvider.SetError(txtIdBusqueda, "Escriba el ID que desea buscar.");
                return;
            }

            errProvider.SetError(txtIdBusqueda, string.Empty);
            vistaActiva?.EjecutarBuscar(id, errProvider);
        }

        private void btnMasterActualizar_Click(object? sender, EventArgs e)
        {
            vistaActiva?.EjecutarActualizar();
        }

        private void btnMasterEliminar_Click(object? sender, EventArgs e)
        {
            vistaActiva?.EjecutarEliminar(stsBarraEstado);
        }

        private void txtIdBusqueda_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnMasterBuscar.PerformClick();
            }
        }
    }
}
