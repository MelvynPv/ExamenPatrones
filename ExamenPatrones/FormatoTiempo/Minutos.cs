using ExamenPatrones.FormatoTiempo.Interfaces;
using System;

namespace ExamenPatrones.FormatoTiempo
{
    public class Minutos : IFormatoTiempo
    {
        private readonly TimeSpan tiempoTranscurrido;

        public Minutos(TimeSpan tiempoTranscurrido)
        {
            this.tiempoTranscurrido = tiempoTranscurrido;
        }

        public string ObtenerTiempo()
        {
            int minutes = (int)Math.Ceiling(tiempoTranscurrido.TotalMinutes);

            return string.Format("{0} minuto(s)", minutes);
        }
    }
}
