//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Clase base abstracta para todas las entidades del sistema

using System;

namespace DirectorioONG.Models
{
    public abstract class EntidadBase
    {
        public string Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool EsActivo { get; set; }

        protected EntidadBase()
        {
            Id = Guid.NewGuid().ToString();
            FechaRegistro = DateTime.Now;
            EsActivo = true;
        }

        protected EntidadBase(string id, DateTime fechaRegistro, bool esActivo)
        {
            Id = id;
            FechaRegistro = fechaRegistro;
            EsActivo = esActivo;
        }
    }
}