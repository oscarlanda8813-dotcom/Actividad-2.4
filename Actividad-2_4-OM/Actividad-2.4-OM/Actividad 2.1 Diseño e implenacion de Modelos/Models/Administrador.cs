//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Clase de modelo para la entidad Administrador

using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectorioONG.Models
{
    public class Administrador : EntidadBase, IAlmacenamientoCRUD
    {
        private static List<Administrador> _tablaRAM = new List<Administrador>();

        private string idAdmin;
        private string nombre;
        private string correo;
        private string rutaImagen;
        private bool estadoActivo;

        public string IdAdmin
        {
            get { return idAdmin; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("ID no válido."); idAdmin = value; Id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { if (value.Length < 3) throw new ArgumentException("Nombre muy corto."); nombre = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { if (!value.Contains("@")) throw new ArgumentException("Correo inválido."); correo = value; }
        }
        public string RutaImagen { get { return rutaImagen; } set { rutaImagen = value; } }
        public bool EstadoActivo { get { return estadoActivo; } set { estadoActivo = value; EsActivo = value; } }

        public Administrador() : base()
        {
            idAdmin = "ADM-000";
            nombre = "Sin Nombre";
            correo = "admin@ong.org";
            rutaImagen = "default.png";
            estadoActivo = false;
        }

        public Administrador(string idAdmin, string nombre, string correo, string rutaImagen, bool estadoActivo)
            : base(idAdmin, DateTime.Now, estadoActivo)
        {
            IdAdmin = idAdmin;
            Nombre = nombre;
            Correo = correo;
            RutaImagen = rutaImagen;
            EstadoActivo = estadoActivo;
        }

        public bool ValidarAcceso()
        {
            return EstadoActivo;
        }

        public bool ValidarAcceso(string claveIngresada)
        {
            string claveMaster = "ONGAdmin2026";
            return EstadoActivo && claveIngresada == claveMaster;
        }

        public override string ToString()
        {
            return $"[Admin] ID: {IdAdmin} | Nombre: {Nombre} | Correo: {Correo} | Estado: {(EstadoActivo ? "Activo" : "Inactivo")}";
        }

        // IMPLEMENTACIÓN DE IAlmacenamientoCRUD

        public void InsertarRegistro(object objeto)
        {
            if (objeto is Administrador item)
            {
                _tablaRAM.Add(item);
            }
        }

        public object ConsultarRegistro(string id)
        {
            return _tablaRAM.FirstOrDefault(x => x.IdAdmin == id || x.Id == id);
        }

        public void ActualizarRegistro(object objeto)
        {
            if (objeto is Administrador item)
            {
                var index = _tablaRAM.FindIndex(x => x.IdAdmin == item.IdAdmin || x.Id == item.Id);
                if (index != -1)
                {
                    _tablaRAM[index] = item;
                }
            }
        }

        public void EliminarRegistro(string id)
        {
            var item = _tablaRAM.FirstOrDefault(x => x.IdAdmin == id || x.Id == id);
            if (item != null)
            {
                _tablaRAM.Remove(item);
            }
        }
    }
}