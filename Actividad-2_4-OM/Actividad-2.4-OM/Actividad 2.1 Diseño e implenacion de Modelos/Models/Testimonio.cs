//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Clase de modelo para la entidad Testimonio

using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectorioONG.Models
{
    public class Testimonio : EntidadBase, IAlmacenamientoCRUD
    {
        private static List<Testimonio> _tablaRAM = new List<Testimonio>();

        private int idTestimonio;
        private string autor;
        private int calificacion; // 1 a 5 estrellas
        private string rutaImagen; // Foto de quien da el testimonio
        private bool estadoActivo;

        public int IdTestimonio
        {
            get { return idTestimonio; }
            set
            {
                if (value <= 0) throw new ArgumentException("ID no válido.");
                idTestimonio = value;
                Id = value.ToString();
            }
        }
        public string Autor
        {
            get { return autor; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Autor requerido."); autor = value; }
        }
        public int Calificacion
        {
            get { return calificacion; }
            set { if (value < 1 || value > 5) throw new ArgumentException("Calificación debe ser entre 1 y 5."); calificacion = value; }
        }
        public string RutaImagen { get { return rutaImagen; } set { rutaImagen = value; } }
        public bool EstadoActivo { get { return estadoActivo; } set { estadoActivo = value; EsActivo = value; } }

        // 1. Constructor por defecto (sin parámetros)
        public Testimonio() : base()
        {
            idTestimonio = 1;
            autor = "Autor Anónimo";
            calificacion = 5;
            rutaImagen = "autor_default.png";
            estadoActivo = false;
        }

        // 2. Constructor parametrizado (asigna a través de propiedades para validar)
        public Testimonio(int idTestimonio, string autor, int calificacion, string rutaImagen, bool estadoActivo)
            : base(idTestimonio.ToString(), DateTime.Now, estadoActivo)
        {
            IdTestimonio = idTestimonio;
            Autor = autor;
            Calificacion = calificacion;
            RutaImagen = rutaImagen;
            EstadoActivo = estadoActivo;
        }

        // Versión A (Sin parámetros externos): Genera una representación en formato de estrellas (★) basada en la calificación grabada.
        public string ObtenerCalificacionEstrellas()
        {
            if (!EstadoActivo) return "Testimonio no visible";

            return new string('★', Calificacion) + new string('☆', 5 - Calificacion);
        }

        // Versión B (Con parámetro externo): Evalúa si la calificación cumple con un puntaje mínimo requerido para publicarse en la portada.
        public bool CumpleCriterioDestacado(int calificacionMinima)
        {
            return EstadoActivo && Calificacion >= calificacionMinima;
        }

        public override string ToString()
        {
            return $"[Testimonio #{IdTestimonio}] Autor: {Autor} | Calificación: {Calificacion}/5★ | Estado: {(EstadoActivo ? "Publicado" : "Oculto")}";
        }

        // IMPLEMENTACIÓN DE IAlmacenamientoCRUD

        public void InsertarRegistro(object objeto)
        {
            if (objeto is Testimonio item)
            {
                _tablaRAM.Add(item);
            }
        }

        public object ConsultarRegistro(string id)
        {
            return _tablaRAM.FirstOrDefault(x => x.IdTestimonio.ToString() == id || x.Id == id);
        }

        public void ActualizarRegistro(object objeto)
        {
            if (objeto is Testimonio item)
            {
                var index = _tablaRAM.FindIndex(x => x.IdTestimonio == item.IdTestimonio || x.Id == item.Id);
                if (index != -1)
                {
                    _tablaRAM[index] = item;
                }
            }
        }

        public void EliminarRegistro(string id)
        {
            var item = _tablaRAM.FirstOrDefault(x => x.IdTestimonio.ToString() == id || x.Id == id);
            if (item != null)
            {
                _tablaRAM.Remove(item);
            }
        }
    }
}