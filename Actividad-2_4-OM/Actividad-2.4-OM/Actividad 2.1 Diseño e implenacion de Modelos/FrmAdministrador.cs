//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Vista heredada (FrmBase) para la entidad Administrador; implementa IPanelCRUD

using DirectorioONG.Models;

namespace Actividad_2._1_Diseño_e_implenacion_de_Modelos
{
    public partial class FrmAdministrador : FrmBase, IPanelCRUD
    {
        // Instancia de trabajo: los métodos CRUD del modelo (Actividad 2.3) operan sobre la colección estática en memoria.
        private readonly Administrador _modelo = new Administrador();

        public FrmAdministrador()
        {
            InitializeComponent();

            // Se personaliza el control heredado txtId según la llave primaria de esta entidad.
            lblId.Text = "ID Admin:";
            txtId.MaxLength = 30;

            LimpiarCampos();
        }

        // ====================== Contrato IPanelCRUD ======================

        public void EjecutarGuardar()
        {
            try
            {
                Administrador nuevo = LeerFormulario();

                if (_modelo.ConsultarRegistro(nuevo.Id) != null)
                {
                    MostrarAviso($"Ya existe un registro con el ID '{nuevo.Id}'. Use Actualizar para modificarlo.");
                    return;
                }

                nuevo.InsertarRegistro(nuevo);
                LimpiarCampos();
                MostrarResultado("Registro guardado correctamente:", nuevo);
            }
            catch (Exception ex)
            {
                MostrarError("Administrador", ex);
            }
        }

        public void EjecutarBuscar(string id, ErrorProvider alerta)
        {
            LimpiarCampos();
            txtId.Text = id;

            if (_modelo.ConsultarRegistro(id) is Administrador encontrado)
            {
                alerta.SetError(txtId, string.Empty);
                MapearAFormulario(encontrado);
                MostrarResultado("Registro encontrado:", encontrado);
            }
            else
            {
                alerta.SetError(txtId, $"No existe ningún registro de Administrador con el ID '{id}'.");
                txtResultado.Text = "Sin resultados para la búsqueda.";
            }
        }

        public void EjecutarActualizar()
        {
            try
            {
                Administrador actualizado = LeerFormulario();

                if (_modelo.ConsultarRegistro(actualizado.Id) == null)
                {
                    MostrarAviso($"No existe un registro con el ID '{actualizado.Id}'. Use Guardar para crearlo.");
                    return;
                }

                actualizado.ActualizarRegistro(actualizado);
                MostrarResultado("Registro actualizado correctamente:", actualizado);
            }
            catch (Exception ex)
            {
                MostrarError("Administrador", ex);
            }
        }

        public void EjecutarEliminar(StatusStrip barraEstado)
        {
            string id = txtId.Text.Trim();

            if (id.Length == 0)
            {
                MostrarAviso("Capture o busque primero el ID del registro que desea eliminar.");
                return;
            }

            if (_modelo.ConsultarRegistro(id) == null)
            {
                MostrarEstado(barraEstado, $"No existe ningún registro de Administrador con el ID '{id}'.");
                return;
            }

            if (!Confirmar($"¿Eliminar el registro de Administrador '{id}'?"))
            {
                MostrarEstado(barraEstado, "Eliminación cancelada.");
                return;
            }

            _modelo.EliminarRegistro(id);
            LimpiarCampos();
            txtResultado.Text = $"Registro '{id}' eliminado.";
            MostrarEstado(barraEstado, $"Registro de Administrador '{id}' eliminado correctamente.");
        }

        // ====================== Vista <-> Modelo ======================

        /// <summary>Recupera los controles (heredados y propios) e instancia el modelo con su constructor parametrizado.</summary>
        private Administrador LeerFormulario()
        {
            return new Administrador(
                txtId.Text.Trim(),
                txtNombre.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtRutaImagen.Text.Trim(),
                chkEstadoActivo.Checked);
        }

        /// <summary>Mapea los atributos del modelo de vuelta a los controles de la pantalla.</summary>
        private void MapearAFormulario(Administrador obj)
        {
            txtId.Text = obj.IdAdmin;
            txtNombre.Text = obj.Nombre;
            txtCorreo.Text = obj.Correo;
            txtRutaImagen.Text = obj.RutaImagen;
            CargarImagen(picImagen, obj.RutaImagen);
            chkEstadoActivo.Checked = obj.EstadoActivo;
        }

        private void MostrarResultado(string encabezado, Administrador obj)
        {
            txtResultado.Text = $"{encabezado}\r\n{obj}\r\n" +
                $"-> Estado de cuenta activo: {(obj.ValidarAcceso() ? "SÍ" : "NO")}\r\n" +
                $"-> Validación de clave maestra: {(obj.ValidarAcceso("ONGAdmin2026") ? "ACCESO CONCEDIDO" : "DENEGADO")}";
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtRutaImagen.Clear();
            CargarImagen(picImagen, null);
            chkEstadoActivo.Checked = true;
        }

        private void btnExaminar_Click(object? sender, EventArgs e)
        {
            string? ruta = SeleccionarImagen();
            if (ruta == null)
                return;

            txtRutaImagen.Text = ruta;
            CargarImagen(picImagen, ruta);
        }
    }
}
