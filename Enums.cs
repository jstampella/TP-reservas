using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    public enum EEstado
    {
        Activo,
        Fuera_de_servicio,
        Proximamente,
    }

    public enum EEstadoReserva
    {
        Activa,
        Modificada,
        Cancelada
    }

    public enum EBuscar 
    {
        DNI,
        APELLIDO,
        NOMBRE,
        PERSONAS,
        ID,
        ALL
    }

    public enum ETipo
    {
        CASA,
        HOTEL,
        TODOS
    }

    public enum EMeses { 
    Enero,
    Febrero,
    Marzo,
    Abril,
    Mayo,
    Junio,
    Julio,
    Agosto,
    Septiembre,
    Octubre,
    Noviembre,
    Diciembre
    }
}
