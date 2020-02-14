using System;

namespace ExamenPatrones.FormatoTiempo.Interfaces
{
    public interface IFormatoTiempo
    {
        /// <summary>
        /// Método que convierte la fecha indicada en algún formato.
        /// </summary>
        /// <returns>Cadena con el formato deseado.</returns>
        string ObtenerTiempo();
    }
}
