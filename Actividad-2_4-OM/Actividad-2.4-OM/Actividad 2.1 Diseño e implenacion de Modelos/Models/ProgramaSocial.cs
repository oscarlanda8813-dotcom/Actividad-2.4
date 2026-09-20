//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Clase de modelo para la entidad ProgramaSocial

using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectorioONG.Models
{
    public class ProgramaSocial : EntidadBase, IAlmacenamientoCRUD
    {
        private static List<ProgramaSocial> _tablaRAM = new List<ProgramaSocial>();

        private string idPrograma;
        private string nombrePrograma;
        private int capacidadPersonas;
        private string rutaImagen;
        private bool estadoActivo;

        public string IdPrograma
        {
            get { return idPrograma; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("ID requerido."); idPrograma = value; Id = value; }
        }
        public string NombrePrograma
        {
            get { return nombrePrograma; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Nombre requerido."); nombrePrograma = value; }
        }
        public int CapacidadPersonas
        {
            get { return capacidadPersonas; }
            set { if (value <= 0) throw new ArgumentException("La capacidad debe ser al menos 1."); capacidadPersonas = value; }
        }
        public string RutaImagen { get { return rutaImagen; } set { rutaImagen = value; } }
        public bool EstadoActivo { get { return estadoActivo; } set { estadoActivo = value; EsActivo = value; } }

        // 1. Constructor por defecto (sin parámetros)
        public ProgramaSocial() : base()
        {
            idPrograma = "PROG-000";
            nombrePrograma = "Programa Sin Nombre";
            capacidadPersonas = 1;
            rutaImagen = "programa_default.png";
            estadoActivo = false;
        }

        // 2. Constructor parametrizado (asigna a través de propiedades para validar)
        public ProgramaSocial(string idPrograma, string nombrePrograma, int capacidadPersonas, string rutaImagen, bool estadoActivo)
            : base(idPrograma, DateTime.Now, estadoActivo)
        {
            IdPrograma = idPrograma;
            NombrePrograma = nombrePrograma;
            CapacidadPersonas = capacidadPersonas;
            RutaImagen = rutaImagen;
            EstadoActivo = estadoActivo;
        }

        // Versión A (Sin parámetros externos): Calcula la capacidad disponible asumiendo un cupo ocupado fijo por defecto.
        public int CalcularCupoDisponible()
        {
            if (!EstadoActivo) return 0;

            int registradosPorDefecto = 0;
            return CapacidadPersonas - registradosPorDefecto;
        }

        // Versión B (Con parámetro externo): Calcula los lugares disponibles restando la cantidad actual de inscritos recibida desde fuera.
        public int CalcularCupoDisponible(int cantidadInscritosActuales)
        {
            if (!EstadoActivo) return 0;

            int disponibles = CapacidadPersonas - cantidadInscritosActuales;
            return disponibles >= 0 ? disponibles : 0;
        }

        public override string ToString()
        {
            return $"[Programa Social] ID: {IdPrograma} | Nombre: {NombrePrograma} | Capacidad Máxima: {CapacidadPersonas} personas | Estado: {(EstadoActivo ? "Activo" : "Inactivo")}";
        }

        // IMPLEMENTACIÓN DE IAlmacenamientoCRUD

        public void InsertarRegistro(object objeto)
        {
            if (objeto is ProgramaSocial item)
            {
                _tablaRAM.Add(item);
            }
        }

        public object ConsultarRegistro(string id)
        {
            return _tablaRAM.FirstOrDefault(x => x.IdPrograma == id || x.Id == id);
        }

        public void ActualizarRegistro(object objeto)
        {
            if (objeto is ProgramaSocial item)
            {
                var index = _tablaRAM.FindIndex(x => x.IdPrograma == item.IdPrograma || x.Id == item.Id);
                if (index != -1)
                {
                    _tablaRAM[index] = item;
                }
            }
        }

        public void EliminarRegistro(string id)
        {
            var item = _tablaRAM.FirstOrDefault(x => x.IdPrograma == id || x.Id == id);
            if (item != null)
            {
                _tablaRAM.Remove(item);
            }
        }
    }
}