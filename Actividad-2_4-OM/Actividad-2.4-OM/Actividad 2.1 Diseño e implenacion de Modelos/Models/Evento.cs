//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Clase de modelo para la entidad Evento

using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectorioONG.Models
{
    public class Evento : EntidadBase, IAlmacenamientoCRUD
    {
        private static List<Evento> _tablaRAM = new List<Evento>();

        private string idEvento;
        private string titulo;
        private DateTime fechaProgramada;
        private string rutaImagen;
        private bool estadoActivo;

        public string IdEvento
        {
            get { return idEvento; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("ID requerido."); idEvento = value; Id = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Título requerido."); titulo = value; }
        }
        public DateTime FechaProgramada
        {
            get { return fechaProgramada; }
            set { if (value < DateTime.Now) throw new ArgumentException("El evento debe ser en una fecha futura."); fechaProgramada = value; }
        }
        public string RutaImagen { get { return rutaImagen; } set { rutaImagen = value; } }
        public bool EstadoActivo { get { return estadoActivo; } set { estadoActivo = value; EsActivo = value; } }

        public Evento() : base()
        {
            idEvento = "EVE-000";
            titulo = "Sin Título";
            fechaProgramada = DateTime.Now.AddDays(1);
            rutaImagen = "poster_default.png";
            estadoActivo = false;
        }

        public Evento(string idEvento, string titulo, DateTime fechaProgramada, string rutaImagen, bool estadoActivo)
            : base(idEvento, DateTime.Now, estadoActivo)
        {
            IdEvento = idEvento;
            Titulo = titulo;
            FechaProgramada = fechaProgramada;
            RutaImagen = rutaImagen;
            EstadoActivo = estadoActivo;
        }

        public int CalcularDiasRestantes()
        {
            if (!EstadoActivo) return 0;
            TimeSpan diferencia = FechaProgramada - DateTime.Now;
            return diferencia.Days >= 0 ? diferencia.Days : 0;
        }

        public int CalcularDiasRestantes(DateTime fechaReferencia)
        {
            if (!EstadoActivo) return 0;
            TimeSpan diferencia = FechaProgramada - fechaReferencia;
            return diferencia.Days >= 0 ? diferencia.Days : 0;
        }

        public override string ToString()
        {
            return $"[Evento] ID: {IdEvento} | Título: {Titulo} | Fecha: {FechaProgramada:dd/MM/yyyy HH:mm} | Estado: {(EstadoActivo ? "Programado" : "Cancelado")}";
        }

        // IMPLEMENTACIÓN DE IAlmacenamientoCRUD

        public void InsertarRegistro(object objeto)
        {
            if (objeto is Evento item)
            {
                _tablaRAM.Add(item);
            }
        }

        public object ConsultarRegistro(string id)
        {
            return _tablaRAM.FirstOrDefault(x => x.IdEvento == id || x.Id == id);
        }

        public void ActualizarRegistro(object objeto)
        {
            if (objeto is Evento item)
            {
                var index = _tablaRAM.FindIndex(x => x.IdEvento == item.IdEvento || x.Id == item.Id);
                if (index != -1)
                {
                    _tablaRAM[index] = item;
                }
            }
        }

        public void EliminarRegistro(string id)
        {
            var item = _tablaRAM.FirstOrDefault(x => x.IdEvento == id || x.Id == id);
            if (item != null)
            {
                _tablaRAM.Remove(item);
            }
        }
    }
}