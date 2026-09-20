//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Vista heredada (FrmBase) para la entidad Testimonio; implementa IPanelCRUD

using DirectorioONG.Models;

namespace Actividad_2._1_Diseño_e_implenacion_de_Modelos
{
    public partial class FrmTestimonio : FrmBase, IPanelCRUD
    {
        // Instancia de trabajo: los métodos CRUD del modelo (Actividad 2.3) operan sobre la colección estática en memoria.
        private readonly Testimonio _modelo = new Testimonio();

        public FrmTestimonio()
        {
            InitializeComponent();

            // Se personaliza el control heredado txtId según la llave primaria de esta entidad.
            lblId.Text = "ID Testimonio:";
            txtId.MaxLength = 9;

            LimpiarCampos();
        }

        // ====================== Contrato IPanelCRUD ======================

        public void EjecutarGuardar()
        {
            try
            {
                Testimonio nuevo = LeerFormulario();

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
                MostrarError("Testimonio", ex);
            }
        }

        public void EjecutarBuscar(string id, ErrorProvider alerta)
        {
            LimpiarCampos();
            txtId.Text = id;

            if (_modelo.ConsultarRegistro(id) is Testimonio encontrado)
            {
                alerta.SetError(txtId, string.Empty);
                MapearAFormulario(encontrado);
                MostrarResultado("Registro encontrado:", encontrado);
            }
            else
            {
                alerta.SetError(txtId, $"No existe ningún registro de Testimonio con el ID '{id}'.");
                txtResultado.Text = "Sin resultados para la búsqueda.";
            }
        }

        public void EjecutarActualizar()
        {
            try
            {
                Testimonio actualizado = LeerFormulario();

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
                MostrarError("Testimonio", ex);
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
                MostrarEstado(barraEstado, $"No existe ningún registro de Testimonio con el ID '{id}'.");
                return;
            }

            if (!Confirmar($"¿Eliminar el registro de Testimonio '{id}'?"))
            {
                MostrarEstado(barraEstado, "Eliminación cancelada.");
                return;
            }

            _modelo.EliminarRegistro(id);
            LimpiarCampos();
            txtResultado.Text = $"Registro '{id}' eliminado.";
            MostrarEstado(barraEstado, $"Registro de Testimonio '{id}' eliminado correctamente.");
        }

        // ====================== Vista <-> Modelo ======================

        /// <summary>Recupera los controles (heredados y propios) e instancia el modelo con su constructor parametrizado.</summary>
        private Testimonio LeerFormulario()
        {
            return new Testimonio(
                LeerIdNumerico(),
                txtAutor.Text.Trim(),
                Convert.ToInt32(cmbCalificacion.SelectedItem),
                txtRutaImagen.Text.Trim(),
                chkEstadoActivo.Checked);
        }

        private int LeerIdNumerico()
        {
            if (!int.TryParse(txtId.Text.Trim(), out int id))
                throw new ArgumentException("El ID debe ser un número entero.");

            return id;
        }

        /// <summary>Mapea los atributos del modelo de vuelta a los controles de la pantalla.</summary>
        private void MapearAFormulario(Testimonio obj)
        {
            txtId.Text = obj.IdTestimonio.ToString();
            txtAutor.Text = obj.Autor;
            cmbCalificacion.SelectedItem = obj.Calificacion.ToString();
            txtRutaImagen.Text = obj.RutaImagen;
            CargarImagen(picImagen, obj.RutaImagen);
            chkEstadoActivo.Checked = obj.EstadoActivo;
        }

        private void MostrarResultado(string encabezado, Testimonio obj)
        {
            txtResultado.Text = $"{encabezado}\r\n{obj}\r\n" +
                $"-> Valoración gráfica: {obj.ObtenerCalificacionEstrellas()}\r\n" +
                $"-> ¿Apto para Portada (mínimo 4 estrellas)?: {(obj.CumpleCriterioDestacado(4) ? "SÍ" : "NO")}";
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtAutor.Clear();
            cmbCalificacion.SelectedIndex = 4;
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
