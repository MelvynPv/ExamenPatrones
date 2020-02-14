using ExamenPatrones.FormatoTiempo.Interfaces;
using System;

namespace ExamenPatrones.FormatoTiempo.Factories.Interfaces
{
    public interface IFormatosTiempoEspecificos
    {
        IFormatoTiempo ObtenerFormatoTiempo(DateTime tiempoActual, DateTime tiempoEntrega);
    }
}
