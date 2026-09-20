//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Clase de modelo para la entidad Beneficiario

using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectorioONG.Models
{
    public class Beneficiario : EntidadBase, IAlmacenamientoCRUD
    {
        private static List<Beneficiario> _tablaRAM = new List<Beneficiario>();

        private string curp;
        private string nombreCompleto;
        private int edad;
        private string rutaImagen; // Foto de perfil
        private bool estadoActivo;

        public string Curp
        {
            get { return curp; }
            set { if (value.Length != 18) throw new ArgumentException("La CURP debe tener 18 caracteres."); curp = value; Id = value; }
        }
        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Nombre requerido."); nombreCompleto = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { if (value < 0 || value > 120) throw new ArgumentException("Edad fuera de rango."); edad = value; }
        }
        public string RutaImagen { get { return rutaImagen; } set { rutaImagen = value; } }
        public bool EstadoActivo { get { return estadoActivo; } set { estadoActivo = value; EsActivo = value; } }

        // 1. Constructor por defecto (sin parámetros)
        public Beneficiario() : base()
        {
            curp = "AAAA000000XXXXXX00";
            nombreCompleto = "Sin Nombre";
            edad = 0;
            rutaImagen = "default.png";
            estadoActivo = false;
        }

        // 2. Constructor parametrizado (asigna a través de propiedades para validar)
        public Beneficiario(string curp, string nombreCompleto, int edad, string rutaImagen, bool estadoActivo)
            : base(curp, DateTime.Now, estadoActivo)
        {
            Curp = curp;
            NombreCompleto = nombreCompleto;
            Edad = edad;
            RutaImagen = rutaImagen;
            EstadoActivo = estadoActivo;
        }

        // Versión A (Sin parámetros externos): Determina si el beneficiario califica para apoyos según su estado activo y su edad base.
        public bool ElegibleParaApoyo()
        {
            // Es elegible si está activo y tiene al menos 1 año
            return EstadoActivo && Edad >= 1;
        }

        // Versión B (Con parámetro externo): Evalúa la elegibilidad exigiendo una edad mínima requerida por un programa específico.
        public bool ElegibleParaApoyo(int edadMinimaRequerida)
        {
            return EstadoActivo && Edad >= edadMinimaRequerida;
        }

        public override string ToString()
        {
            return $"[Beneficiario] CURP: {Curp} | Nombre: {NombreCompleto} | Edad: {Edad} años | Estado: {(EstadoActivo ? "Activo" : "Inactivo")}";
        }

        // IMPLEMENTACIÓN DE IAlmacenamientoCRUD

        public void InsertarRegistro(object objeto)
        {
            if (objeto is Beneficiario item)
            {
                _tablaRAM.Add(item);
            }
        }

        public object ConsultarRegistro(string id)
        {
            return _tablaRAM.FirstOrDefault(x => x.Curp == id || x.Id == id);
        }

        public void ActualizarRegistro(object objeto)
        {
            if (objeto is Beneficiario item)
            {
                var index = _tablaRAM.FindIndex(x => x.Curp == item.Curp || x.Id == item.Id);
                if (index != -1)
                {
                    _tablaRAM[index] = item;
                }
            }
        }

        public void EliminarRegistro(string id)
        {
            var item = _tablaRAM.FirstOrDefault(x => x.Curp == id || x.Id == id);
            if (item != null)
            {
                _tablaRAM.Remove(item);
            }
        }
    }
}