using ExamenPatrones.FormatoTiempo.Interfaces;
using System;

namespace ExamenPatrones.FormatoTiempo
{
    public class Meses : IFormatoTiempo
    {
        private readonly TimeSpan tiempoTranscurrido;

        public Meses(TimeSpan tiempoTranscurrido)
        {
            this.tiempoTranscurrido = tiempoTranscurrido;
        }
        public string ObtenerTiempo()
        {
            int mounts = Math.Abs(tiempoTranscurrido.Days) / 30;

            return string.Format("{0} mes(es)", mounts);
        }
    }
}
