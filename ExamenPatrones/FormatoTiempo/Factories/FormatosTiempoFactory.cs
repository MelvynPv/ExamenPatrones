using ExamenPatrones.FormatoTiempo.Enumeradores;
using ExamenPatrones.FormatoTiempo.Factories.Interfaces;
using ExamenPatrones.FormatoTiempo.Interfaces;
using System;

namespace ExamenPatrones.FormatoTiempo.Factories
{
    public class FormatosTiempoFactory : IFormatosTiempoEspecificos
    {

        public IFormatoTiempo ObtenerFormatoTiempo(DateTime tiempoActual, DateTime tiempoEntrega)
        {
            TimeSpan tiempoTranscurrido = ObtenerTiempoTranscurrido(tiempoActual, tiempoEntrega);
            return GetTimeEnum(tiempoEntrega, tiempoActual) switch
            {
                TiempoFormato.Minutos => new Minutos(tiempoTranscurrido),
                TiempoFormato.Horas => new Horas(tiempoTranscurrido),
                TiempoFormato.Dias => new Dias(tiempoTranscurrido),
                TiempoFormato.Meses => new Meses(tiempoTranscurrido),
                _ => throw new ArgumentException("No se encentro la instancia del formato del mensaje"),
            };
        }

        /// <summary>
        /// Obtiene el enumerador adecuado a la diferencia la lejanía de las fechas (con respecto a la actual).
        /// </summary>
        /// <param name="dateEvent">Fecha principal.</param>
        /// <returns>Enumerador que indica que tan lejana están las dos fechas</returns>
        private static TiempoFormato GetTimeEnum(DateTime dateEvent, DateTime dateActual)
        {

            var time = dateEvent.Subtract(dateActual);

            if (Math.Abs(time.TotalMinutes) < 60)
            {
                return TiempoFormato.Minutos;
            }
            else if (Math.Abs(time.TotalHours) < 24)
            {
                return TiempoFormato.Horas;
            }
            else if (Math.Abs(time.TotalDays) < 30)
            {
                return TiempoFormato.Dias;
            }

            return TiempoFormato.Meses;
        }

        private static TimeSpan ObtenerTiempoTranscurrido(DateTime dateStart, DateTime dateActual)
        {
            return dateStart.Subtract(dateActual);
        }
    }
}
