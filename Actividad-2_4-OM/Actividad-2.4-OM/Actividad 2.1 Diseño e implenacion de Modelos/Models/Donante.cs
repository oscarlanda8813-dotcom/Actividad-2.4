//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Clase de modelo para la entidad Donante

using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectorioONG.Models
{
    public class Donante : EntidadBase, IAlmacenamientoCRUD
    {
        private static List<Donante> _tablaRAM = new List<Donante>();

        private string idDonante;
        private string razonSocialONombre;
        private string tipoDonante; // "Empresa" o "Persona"
        private string rutaImagen;
        private bool estadoActivo;

        public string IdDonante
        {
            get { return idDonante; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("ID requerido."); idDonante = value; Id = value; }
        }
        public string RazonSocialONombre
        {
            get { return razonSocialONombre; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Nombre requerido."); razonSocialONombre = value; }
        }
        public string TipoDonante
        {
            get { return tipoDonante; }
            set { if (value != "Empresa" && value != "Persona") throw new ArgumentException("Tipo inválido."); tipoDonante = value; }
        }
        public string RutaImagen { get { return rutaImagen; } set { rutaImagen = value; } }
        public bool EstadoActivo { get { return estadoActivo; } set { estadoActivo = value; EsActivo = value; } }

        // 1. Constructor por defecto (sin parámetros)
        public Donante() : base()
        {
            idDonante = "DON-000";
            razonSocialONombre = "Donante Anónimo";
            tipoDonante = "Persona";
            rutaImagen = "default_avatar.png";
            estadoActivo = false;
        }

        // 2. Constructor parametrizado (asigna a través de propiedades para validar)
        public Donante(string idDonante, string razonSocialONombre, string tipoDonante, string rutaImagen, bool estadoActivo)
            : base(idDonante, DateTime.Now, estadoActivo)
        {
            IdDonante = idDonante;
            RazonSocialONombre = razonSocialONombre;
            TipoDonante = tipoDonante;
            RutaImagen = rutaImagen;
            EstadoActivo = estadoActivo;
        }

        // Versión A (Sin parámetros externos): Genera una constancia fiscal de donación estándar con texto por defecto.
        public string GenerarConstanciaFiscal()
        {
            if (!EstadoActivo)
                return "Donante inactivo. No se puede emitir constancia.";

            return $"CONSTANCIA FISCAL: Emitida a favor de '{RazonSocialONombre}' de tipo '{TipoDonante}'.";
        }

        // Versión B (Con parámetro externo): Genera la constancia fiscal incluyendo el folio fiscal SAT o RFC emitido desde el exterior.
        public string GenerarConstanciaFiscal(string rfcOFolioFiscal)
        {
            if (!EstadoActivo)
                return "Donante inactivo. No se puede emitir constancia.";

            return $"CONSTANCIA FISCAL [RFC/FOLIO: {rfcOFolioFiscal}]: Emitida a favor de '{RazonSocialONombre}' de tipo '{TipoDonante}'.";
        }

        public override string ToString()
        {
            return $"[Donante] ID: {IdDonante} | Nombre/Razón Social: {RazonSocialONombre} | Tipo: {TipoDonante} | Estado: {(EstadoActivo ? "Activo" : "Inactivo")}";
        }

        // IMPLEMENTACIÓN DE IAlmacenamientoCRUD

        public void InsertarRegistro(object objeto)
        {
            if (objeto is Donante item)
            {
                _tablaRAM.Add(item);
            }
        }

        public object ConsultarRegistro(string id)
        {
            return _tablaRAM.FirstOrDefault(x => x.IdDonante == id || x.Id == id);
        }

        public void ActualizarRegistro(object objeto)
        {
            if (objeto is Donante item)
            {
                var index = _tablaRAM.FindIndex(x => x.IdDonante == item.IdDonante || x.Id == item.Id);
                if (index != -1)
                {
                    _tablaRAM[index] = item;
                }
            }
        }

        public void EliminarRegistro(string id)
        {
            var item = _tablaRAM.FirstOrDefault(x => x.IdDonante == id || x.Id == id);
            if (item != null)
            {
                _tablaRAM.Remove(item);
            }
        }
    }
}