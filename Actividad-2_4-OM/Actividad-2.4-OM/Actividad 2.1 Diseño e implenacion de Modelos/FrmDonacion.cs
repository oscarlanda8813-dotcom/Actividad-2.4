//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Vista heredada (FrmBase) para la entidad Donación; implementa IPanelCRUD

using DirectorioONG.Models;

namespace Actividad_2._1_Diseño_e_implenacion_de_Modelos
{
    public partial class FrmDonacion : FrmBase, IPanelCRUD
    {
        // Instancia de trabajo: los métodos CRUD del modelo (Actividad 2.3) operan sobre la colección estática en memoria.
        private readonly Donacion _modelo = new Donacion();

        public FrmDonacion()
        {
            InitializeComponent();

            // Se personaliza el control heredado txtId según la llave primaria de esta entidad.
            lblId.Text = "Folio:";
            txtId.MaxLength = 30;

            LimpiarCampos();
        }

        // ====================== Contrato IPanelCRUD ======================

        public void EjecutarGuardar()
        {
            try
            {
                Donacion nuevo = LeerFormulario();

                if (_modelo.ConsultarRegistro(nuevo.Id) != null)
                {
                    MostrarAviso($"Ya existe un registro con el folio '{nuevo.Id}'. Use Actualizar para modificarlo.");
                    return;
                }

                nuevo.InsertarRegistro(nuevo);
                LimpiarCampos();
                MostrarResultado("Registro guardado correctamente:", nuevo);
            }
            catch (Exception ex)
            {
                MostrarError("Donación", ex);
            }
        }

        public void EjecutarBuscar(string id, ErrorProvider alerta)
        {
            LimpiarCampos();
            txtId.Text = id;

            if (_modelo.ConsultarRegistro(id) is Donacion encontrado)
            {
                alerta.SetError(txtId, string.Empty);
                MapearAFormulario(encontrado);
                MostrarResultado("Registro encontrado:", encontrado);
            }
            else
            {
                alerta.SetError(txtId, $"No existe ningún registro de Donación con el folio '{id}'.");
                txtResultado.Text = "Sin resultados para la búsqueda.";
            }
        }

        public void EjecutarActualizar()
        {
            try
            {
                Donacion actualizado = LeerFormulario();

                if (_modelo.ConsultarRegistro(actualizado.Id) == null)
                {
                    MostrarAviso($"No existe un registro con el folio '{actualizado.Id}'. Use Guardar para crearlo.");
                    return;
                }

                actualizado.ActualizarRegistro(actualizado);
                MostrarResultado("Registro actualizado correctamente:", actualizado);
            }
            catch (Exception ex)
            {
                MostrarError("Donación", ex);
            }
        }

        public void EjecutarEliminar(StatusStrip barraEstado)
        {
            string id = txtId.Text.Trim();

            if (id.Length == 0)
            {
                MostrarAviso("Capture o busque primero el folio del registro que desea eliminar.");
                return;
            }

            if (_modelo.ConsultarRegistro(id) == null)
            {
                MostrarEstado(barraEstado, $"No existe ningún registro de Donación con el folio '{id}'.");
                return;
            }

            if (!Confirmar($"¿Eliminar el registro de Donación '{id}'?"))
            {
                MostrarEstado(barraEstado, "Eliminación cancelada.");
                return;
            }

            _modelo.EliminarRegistro(id);
            LimpiarCampos();
            txtResultado.Text = $"Registro '{id}' eliminado.";
            MostrarEstado(barraEstado, $"Registro de Donación '{id}' eliminado correctamente.");
        }

        // ====================== Vista <-> Modelo ======================

        /// <summary>Recupera los controles (heredados y propios) e instancia el modelo con su constructor parametrizado.</summary>
        private Donacion LeerFormulario()
        {
            return new Donacion(
                txtId.Text.Trim(),
                nudMonto.Value,
                dtpFechaDonacion.Value,
                txtRutaImagen.Text.Trim(),
                chkEstadoActivo.Checked);
        }

        /// <summary>Mapea los atributos del modelo de vuelta a los controles de la pantalla.</summary>
        private void MapearAFormulario(Donacion obj)
        {
            txtId.Text = obj.Folio;
            nudMonto.Value = obj.Monto;
            dtpFechaDonacion.Value = obj.FechaDonacion;
            txtRutaImagen.Text = obj.RutaImagen;
            CargarImagen(picImagen, obj.RutaImagen);
            chkEstadoActivo.Checked = obj.EstadoActivo;
        }

        private void MostrarResultado(string encabezado, Donacion obj)
        {
            txtResultado.Text = $"{encabezado}\r\n{obj}\r\n" +
                $"-> Neto (Comisión estándar 5%): {obj.CalcularMontoNeto():C2}\r\n" +
                $"-> Neto (Comisión pasarela 10%): {obj.CalcularMontoNeto(10m):C2}";
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            nudMonto.Value = nudMonto.Minimum;
            dtpFechaDonacion.Value = DateTime.Now;
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
