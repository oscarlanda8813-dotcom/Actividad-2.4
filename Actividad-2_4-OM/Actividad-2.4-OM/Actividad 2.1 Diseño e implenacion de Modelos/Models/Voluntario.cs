//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Clase de modelo para la entidad Voluntario

using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectorioONG.Models
{
    public class Voluntario : EntidadBase, IAlmacenamientoCRUD
    {
        private static List<Voluntario> _tablaRAM = new List<Voluntario>();

        private string idVoluntario;
        private string nombre;
        private int horasAportadas;
        private string rutaImagen;
        private bool estadoActivo;

        public string IdVoluntario
        {
            get { return idVoluntario; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("ID requerido."); idVoluntario = value; Id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { if (value.Length < 3) throw new ArgumentException("Nombre muy corto."); nombre = value; }
        }
        public int HorasAportadas
        {
            get { return horasAportadas; }
            set { if (value < 0) throw new ArgumentException("Horas no pueden ser negativas."); horasAportadas = value; }
        }
        public string RutaImagen { get { return rutaImagen; } set { rutaImagen = value; } }
        public bool EstadoActivo { get { return estadoActivo; } set { estadoActivo = value; EsActivo = value; } }

        public Voluntario() : base()
        {
            idVoluntario = "VOL-000";
            nombre = "Sin Nombre";
            horasAportadas = 0;
            rutaImagen = "default.png";
            estadoActivo = false;
        }

        public Voluntario(string idVoluntario, string nombre, int horasAportadas, string rutaImagen, bool estadoActivo)
            : base(idVoluntario, DateTime.Now, estadoActivo)
        {
            IdVoluntario = idVoluntario;
            Nombre = nombre;
            HorasAportadas = horasAportadas;
            RutaImagen = rutaImagen;
            EstadoActivo = estadoActivo;
        }

        public bool ElegibleParaReconocimiento()
        {
            return EstadoActivo && HorasAportadas >= 50;
        }

        public bool ElegibleParaReconocimiento(int horasMinimasRequeridas)
        {
            return EstadoActivo && HorasAportadas >= horasMinimasRequeridas;
        }

        public override string ToString()
        {
            return $"[Voluntario] ID: {IdVoluntario} | Nombre: {Nombre} | Horas: {HorasAportadas} | Estado: {(EstadoActivo ? "Activo" : "Inactivo")}";
        }

        // IMPLEMENTACIÓN DE IAlmacenamientoCRUD

        public void InsertarRegistro(object objeto)
        {
            if (objeto is Voluntario item)
            {
                _tablaRAM.Add(item);
            }
        }

        public object ConsultarRegistro(string id)
        {
            return _tablaRAM.FirstOrDefault(x => x.IdVoluntario == id || x.Id == id);
        }

        public void ActualizarRegistro(object objeto)
        {
            if (objeto is Voluntario item)
            {
                var index = _tablaRAM.FindIndex(x => x.IdVoluntario == item.IdVoluntario || x.Id == item.Id);
                if (index != -1)
                {
                    _tablaRAM[index] = item;
                }
            }
        }

        public void EliminarRegistro(string id)
        {
            var item = _tablaRAM.FirstOrDefault(x => x.IdVoluntario == id || x.Id == id);
            if (item != null)
            {
                _tablaRAM.Remove(item);
            }
        }
    }
}