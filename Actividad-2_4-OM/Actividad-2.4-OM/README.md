# Actividad-2.4-OM

//INSTITUTO / UNIVERSIDAD: Centro Universitario de Tonala
//NÚMERO DE EQUIPO: Equipo #1
//INTEGRANTES:
//- Gonzalez Vega Marco Antonio
//- Landa Lopez Oscar Tadeo
//DESCRIPCIÓN: Actividad 2.4 - Reestructuración de Vistas con Herencia Gráfica y Polimorfismo en Botones (C# Windows Forms, .NET 10)

## Estructura

| Archivo | Rol |
|---|---|
| `IPanelCRUD.cs` | Contrato visual: `EjecutarGuardar`, `EjecutarBuscar`, `EjecutarActualizar`, `EjecutarEliminar` |
| `FrmBase` | Formulario padre con `pnlFormularioBase` (Protected), `lblId` y `txtId` |
| `FrmBeneficiario`, `FrmCategoria`, `FrmDonacion`, `FrmDonante`, `FrmEvento`, `FrmOrganizacion`, `FrmProgramaSocial`, `FrmTestimonio`, `FrmVoluntario`, `FrmAdministrador` | Vistas por herencia visual (`: FrmBase, IPanelCRUD`) |
| `FrmPrincipal` | Marco maestro: `TabControl` de módulos, `pnlContenedorVistas`, botones maestros, `txtIdBusqueda`, `ErrorProvider` y `StatusStrip` |
| `Models/` | Modelos de la Actividad 2.3 (`EntidadBase`, `IAlmacenamientoCRUD` y 10 entidades) |

## Navegación

`FrmPrincipal` -> pestaña (`tabModulos`) -> se instancia la vista heredada, se incrusta en `pnlContenedorVistas` y se asigna a `private IPanelCRUD? vistaActiva`.
Los botones maestros solo invocan `vistaActiva.EjecutarXxx(...)`, sin conocer las clases concretas.
