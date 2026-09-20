//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Interfaz de contrato de persistencia CRUD

namespace DirectorioONG.Models
{
    public interface IAlmacenamientoCRUD
    {
        void InsertarRegistro(object objeto);
        object ConsultarRegistro(string id);
        void ActualizarRegistro(object objeto);
        void EliminarRegistro(string id);
    }
}