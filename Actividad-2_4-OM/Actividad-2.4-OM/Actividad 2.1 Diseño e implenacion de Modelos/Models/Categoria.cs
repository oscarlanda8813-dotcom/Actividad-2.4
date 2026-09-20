//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Clase de modelo para la entidad Categoria

using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectorioONG.Models
{
    public class Categoria : EntidadBase, IAlmacenamientoCRUD
    {
        private static List<Categoria> _tablaRAM = new List<Categoria>();

        private int idCategoria;
        private string nombreCategoria;
        private string descripcion;
        private string rutaImagen; // Ícono representativo
        private bool estadoActivo;

        public int IdCategoria
        {
            get { return idCategoria; }
            set { if (value <= 0) throw new ArgumentException("ID debe ser mayor a 0."); idCategoria = value; Id = value.ToString(); }
        }
        public string NombreCategoria
        {
            get { return nombreCategoria; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Nombre requerido."); nombreCategoria = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { if (value.Length > 200) throw new ArgumentException("Descripción muy larga."); descripcion = value; }
        }
        public string RutaImagen { get { return rutaImagen; } set { rutaImagen = value; } }
        public bool EstadoActivo { get { return estadoActivo; } set { estadoActivo = value; EsActivo = value; } }

        // 1. Constructor por defecto (sin parámetros)
        public Categoria() : base()
        {
            idCategoria = 1;
            nombreCategoria = "Sin Categoría";
            descripcion = "Sin descripción disponible.";
            rutaImagen = "default_icon.png";
            estadoActivo = false;
        }

        // 2. Constructor parametrizado (asigna a través de propiedades para validar)
        public Categoria(int idCategoria, string nombreCategoria, string descripcion, string rutaImagen, bool estadoActivo)
            : base(idCategoria.ToString(), DateTime.Now, estadoActivo)
        {
            IdCategoria = idCategoria;
            NombreCategoria = nombreCategoria;
            Descripcion = descripcion;
            RutaImagen = rutaImagen;
            EstadoActivo = estadoActivo;
        }

        // Versión A (Sin parámetros externos): Genera una etiqueta formateada para mostrar la categoría si está activa.
        public string ObtenerEtiqueta()
        {
            if (!EstadoActivo)
                return "Categoría Inactiva";

            return $"[CAT-{IdCategoria}] {NombreCategoria}";
        }

        // Versión B (Con parámetro externo): Genera la etiqueta añadiendo un prefijo o código especial desde el exterior.
        public string ObtenerEtiqueta(string prefijoEspecial)
        {
            if (!EstadoActivo)
                return "Categoría Inactiva";

            return $"{prefijoEspecial}-[CAT-{IdCategoria}] {NombreCategoria}";
        }

        public override string ToString()
        {
            return $"[Categoría #{IdCategoria}] {NombreCategoria} - {Descripcion} | Estado: {(EstadoActivo ? "Activa" : "Inactiva")}";
        }

        // IMPLEMENTACIÓN DE IAlmacenamientoCRUD

        public void InsertarRegistro(object objeto)
        {
            if (objeto is Categoria item)
            {
                _tablaRAM.Add(item);
            }
        }

        public object ConsultarRegistro(string id)
        {
            return _tablaRAM.FirstOrDefault(x => x.IdCategoria.ToString() == id || x.Id == id);
        }

        public void ActualizarRegistro(object objeto)
        {
            if (objeto is Categoria item)
            {
                var index = _tablaRAM.FindIndex(x => x.IdCategoria == item.IdCategoria || x.Id == item.Id);
                if (index != -1)
                {
                    _tablaRAM[index] = item;
                }
            }
        }

        public void EliminarRegistro(string id)
        {
            var item = _tablaRAM.FirstOrDefault(x => x.IdCategoria.ToString() == id || x.Id == id);
            if (item != null)
            {
                _tablaRAM.Remove(item);
            }
        }
    }
}