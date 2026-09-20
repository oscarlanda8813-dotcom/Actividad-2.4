//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Clase de modelo para la entidad Donacion

using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectorioONG.Models
{
    public class Donacion : EntidadBase, IAlmacenamientoCRUD
    {
        private static List<Donacion> _tablaRAM = new List<Donacion>();

        private string folio;
        private decimal monto;
        private DateTime fechaDonacion;
        private string rutaImagen; // Comprobante o recibo
        private bool estadoActivo;

        public string Folio
        {
            get { return folio; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Folio requerido."); folio = value; Id = value; }
        }
        public decimal Monto
        {
            get { return monto; }
            set { if (value <= 0) throw new ArgumentException("El monto debe ser mayor a 0."); monto = value; }
        }
        public DateTime FechaDonacion
        {
            get { return fechaDonacion; }
            set { if (value > DateTime.Now) throw new ArgumentException("La fecha no puede ser futura."); fechaDonacion = value; FechaRegistro = value; }
        }
        public string RutaImagen { get { return rutaImagen; } set { rutaImagen = value; } }
        public bool EstadoActivo { get { return estadoActivo; } set { estadoActivo = value; EsActivo = value; } }

        // 1. Constructor por defecto (sin parámetros)
        public Donacion() : base()
        {
            folio = "FOL-0000";
            monto = 1.00m;
            fechaDonacion = DateTime.Now;
            rutaImagen = "comprobante_default.png";
            estadoActivo = false;
        }

        // 2. Constructor parametrizado (asigna a través de propiedades para validar)
        public Donacion(string folio, decimal monto, DateTime fechaDonacion, string rutaImagen, bool estadoActivo)
            : base(folio, fechaDonacion, estadoActivo)
        {
            Folio = folio;
            Monto = monto;
            FechaDonacion = fechaDonacion;
            RutaImagen = rutaImagen;
            EstadoActivo = estadoActivo;
        }

        // Versión A (Sin parámetros externos): Calcula el monto neto de la donación aplicando una comisión fija estándar por procesamiento (5%).
        public decimal CalcularMontoNeto()
        {
            if (!EstadoActivo) return 0m;

            decimal porcentajeComision = 0.05m;
            return Monto - (Monto * porcentajeComision);
        }

        // Versión B (Con parámetro externo): Calcula el monto neto aplicando una tasa de comisión personalizada según la pasarela de pago utilizada.
        public decimal CalcularMontoNeto(decimal porcentajeComisionPersonalizado)
        {
            if (!EstadoActivo) return 0m;

            return Monto - (Monto * (porcentajeComisionPersonalizado / 100m));
        }

        public override string ToString()
        {
            return $"[Donación] Folio: {Folio} | Monto: {Monto:C2} | Fecha: {FechaDonacion:dd/MM/yyyy} | Estado: {(EstadoActivo ? "Registrada" : "Cancelada")}";
        }

        // IMPLEMENTACIÓN DE IAlmacenamientoCRUD

        public void InsertarRegistro(object objeto)
        {
            if (objeto is Donacion item)
            {
                _tablaRAM.Add(item);
            }
        }

        public object ConsultarRegistro(string id)
        {
            return _tablaRAM.FirstOrDefault(x => x.Folio == id || x.Id == id);
        }

        public void ActualizarRegistro(object objeto)
        {
            if (objeto is Donacion item)
            {
                var index = _tablaRAM.FindIndex(x => x.Folio == item.Folio || x.Id == item.Id);
                if (index != -1)
                {
                    _tablaRAM[index] = item;
                }
            }
        }

        public void EliminarRegistro(string id)
        {
            var item = _tablaRAM.FirstOrDefault(x => x.Folio == id || x.Id == id);
            if (item != null)
            {
                _tablaRAM.Remove(item);
            }
        }
    }
}