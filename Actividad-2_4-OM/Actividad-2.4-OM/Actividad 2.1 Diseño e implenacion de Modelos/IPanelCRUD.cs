//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Contrato visual que estandariza las acciones de captura de todas las vistas heredadas

namespace Actividad_2._1_Diseño_e_implenacion_de_Modelos
{
    /// <summary>
    /// Contrato abstracto que obliga a cada pantalla heredada de FrmBase a exponer las mismas
    /// cuatro acciones. FrmPrincipal solo conoce esta interfaz, nunca las clases concretas.
    /// </summary>
    public interface IPanelCRUD
    {
        void EjecutarGuardar();

        void EjecutarBuscar(string id, ErrorProvider alerta);

        void EjecutarActualizar();

        void EjecutarEliminar(StatusStrip barraEstado);
    }
}
