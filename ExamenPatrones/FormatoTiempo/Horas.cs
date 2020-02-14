using ExamenPatrones.FormatoTiempo.Interfaces;
using System;

namespace ExamenPatrones.FormatoTiempo
{
    public class Horas : IFormatoTiempo
    {
        private readonly TimeSpan tiempoTranscurrido;

        public Horas(TimeSpan tiempoTranscurrido)
        {
            this.tiempoTranscurrido = tiempoTranscurrido;
        }

        public string ObtenerTiempo()
        {
            int hours = (int)Math.Ceiling(Math.Abs(tiempoTranscurrido.TotalHours));
            return string.Format("{0} hora(s)", hours);
        }
    }
}
