//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Clase de modelo para la entidad Organizacion

using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectorioONG.Models
{
    public class Organizacion : EntidadBase, IAlmacenamientoCRUD
    {
        private static List<Organizacion> _tablaRAM = new List<Organizacion>();

        private string rfc;
        private string razonSocial;
        private int aniosOperacion;
        private string rutaImagen; // Logo de la ONG
        private bool estadoActivo;

        public string Rfc
        {
            get { return rfc; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("El RFC es obligatorio."); rfc = value; Id = value; }
        }
        public string RazonSocial
        {
            get { return razonSocial; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Nombre obligatorio."); razonSocial = value; }
        }
        public int AniosOperacion
        {
            get { return aniosOperacion; }
            set { if (value < 0) throw new ArgumentException("Los años no pueden ser negativos."); aniosOperacion = value; }
        }
        public string RutaImagen { get { return rutaImagen; } set { rutaImagen = value; } }
        public bool EstadoActivo { get { return estadoActivo; } set { estadoActivo = value; EsActivo = value; } }

        // 1. Constructor por defecto (sin parámetros)
        public Organizacion() : base()
        {
            rfc = "XAXX010101000";
            razonSocial = "Organización Sin Nombre";
            aniosOperacion = 0;
            rutaImagen = "logo_default.png";
            estadoActivo = false;
        }

        // 2. Constructor parametrizado (asigna a través de propiedades para validar)
        public Organizacion(string rfc, string razonSocial, int aniosOperacion, string rutaImagen, bool estadoActivo)
            : base(rfc, DateTime.Now, estadoActivo)
        {
            Rfc = rfc;
            RazonSocial = razonSocial;
            AniosOperacion = aniosOperacion;
            RutaImagen = rutaImagen;
            EstadoActivo = estadoActivo;
        }

        // Versión A (Sin parámetros externos): Determina si la ONG califica para certificación institucional (requiere estar activa y al menos 3 años operando).
        public bool EsAptaParaCertificacion()
        {
            int aniosMinimosEstandar = 3;
            return EstadoActivo && AniosOperacion >= aniosMinimosEstandar;
        }

        // Versión B (Con parámetro externo): Evalúa si es apta para certificación o convocatoria exigiendo un mínimo de años personalizado.
        public bool EsAptaParaCertificacion(int aniosMinimosRequeridos)
        {
            return EstadoActivo && AniosOperacion >= aniosMinimosRequeridos;
        }

        public override string ToString()
        {
            return $"[Organización] RFC: {Rfc} | Razón Social: {RazonSocial} | Años de Operación: {AniosOperacion} | Estado: {(EstadoActivo ? "Activa" : "Inactiva")}";
        }

        // IMPLEMENTACIÓN DE IAlmacenamientoCRUD

        public void InsertarRegistro(object objeto)
        {
            if (objeto is Organizacion item)
            {
                _tablaRAM.Add(item);
            }
        }

        public object ConsultarRegistro(string id)
        {
            return _tablaRAM.FirstOrDefault(x => x.Rfc == id || x.Id == id);
        }

        public void ActualizarRegistro(object objeto)
        {
            if (objeto is Organizacion item)
            {
                var index = _tablaRAM.FindIndex(x => x.Rfc == item.Rfc || x.Id == item.Id);
                if (index != -1)
                {
                    _tablaRAM[index] = item;
                }
            }
        }

        public void EliminarRegistro(string id)
        {
            var item = _tablaRAM.FirstOrDefault(x => x.Rfc == id || x.Id == id);
            if (item != null)
            {
                _tablaRAM.Remove(item);
            }
        }
    }
}