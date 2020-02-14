using ExamenPatrones.CreadorMensajes.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPatrones.CreadorMensajes
{
    public class NexoY : CreadorMensajeConsecutivo
    {
        public NexoY(StringBuilder mensajeEntregado,
           ICreadorMensaje creadorMensajeSiguiente)
           : base(mensajeEntregado, creadorMensajeSiguiente)
        {
        }

        protected override void AgregarParteMensaje()
        {
            _mensajeEntregado.Append("y");
        }
    }
}
