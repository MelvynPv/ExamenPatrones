using ExamenPatrones.CreadorMensajes.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPatrones.CreadorMensajes
{
    public class EstadoDeEntrega : CreadorMensajeConsecutivo
    {
        private readonly bool _estaEntregado;
        private readonly string _destino;

        public EstadoDeEntrega(StringBuilder mensajeEntregado,
            bool estaEntregado,
            string destino,
            ICreadorMensaje creadorMensajeSiguiente)
            : base(mensajeEntregado, creadorMensajeSiguiente)
        {
            _estaEntregado = estaEntregado;
            _destino = destino;
        }

        protected override void AgregarParteMensaje()
        {
            if (_estaEntregado)
            {
                _mensajeEntregado.Append("llegó");
            }
            else
            {
                _mensajeEntregado.Append("llegará");
            }
            _mensajeEntregado.Append(" a " + _destino);
        }
    }
}
