using ExamenPatrones.FormatoTiempo.Interfaces;
using System;

namespace ExamenPatrones.FormatoTiempo
{
    public class Dias : IFormatoTiempo
    {
        private readonly TimeSpan tiempoTranscurrido;

        public Dias(TimeSpan tiempoTranscurrido)
        {
            this.tiempoTranscurrido = tiempoTranscurrido;
        }

        public string ObtenerTiempo()
        {
            int days = (int)Math.Ceiling(Math.Abs(tiempoTranscurrido.TotalDays));
            return string.Format("{0} Dia(s)", days);
        }
    }
}
