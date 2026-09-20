//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Formulario padre gráfico: plantilla común (panel heredable + campo txtId) y utilidades compartidas

namespace Actividad_2._1_Diseño_e_implenacion_de_Modelos
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        // ---------- Utilidades compartidas por todas las vistas hijas ----------

        /// <summary>Escribe un mensaje en la primera etiqueta de la barra de estado recibida.</summary>
        protected void MostrarEstado(StatusStrip barra, string mensaje)
        {
            foreach (ToolStripItem item in barra.Items)
            {
                if (item is ToolStripStatusLabel etiqueta)
                {
                    etiqueta.Text = mensaje;
                    return;
                }
            }
        }

        protected void MostrarAviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void MostrarError(string entidad, Exception ex)
        {
            MessageBox.Show($"Error en {entidad}: {ex.Message}", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected bool Confirmar(string pregunta)
        {
            return MessageBox.Show(pregunta, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>Abre un OpenFileDialog y devuelve la ruta elegida (o null si se cancela).</summary>
        protected string? SeleccionarImagen()
        {
            using OpenFileDialog dialogo = new OpenFileDialog
            {
                Title = "Seleccionar imagen",
                Filter = "Imágenes|*.png;*.jpg;*.jpeg;*.bmp;*.gif|Todos los archivos|*.*"
            };

            return dialogo.ShowDialog() == DialogResult.OK ? dialogo.FileName : null;
        }

        /// <summary>Muestra la imagen de la ruta en el PictureBox; si no existe, lo deja vacío.</summary>
        protected void CargarImagen(PictureBox caja, string? ruta)
        {
            caja.Image?.Dispose();
            caja.Image = null;

            if (string.IsNullOrWhiteSpace(ruta) || !File.Exists(ruta))
                return;

            try
            {
                using FileStream flujo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                using Image original = Image.FromStream(flujo);
                caja.Image = new Bitmap(original); // copia: no deja el archivo bloqueado
            }
            catch (Exception)
            {
                caja.Image = null;
            }
        }
    }
}
