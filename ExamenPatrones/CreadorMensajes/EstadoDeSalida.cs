using ExamenPatrones.CreadorMensajes.Interface;
using System;
using System.Text;

namespace ExamenPatrones.CreadorMensajes
{
    public class EstadoDeSalida : CreadorMensajeConsecutivo
    {
        private readonly bool _estaEntregado;
        private readonly string _origen;

        public EstadoDeSalida(StringBuilder mensajeEntregado,
            bool estaEntregado,
            string origen,
            ICreadorMensaje creadorMensajeSiguiente)
            : base(mensajeEntregado, creadorMensajeSiguiente)
        {
            _origen = origen;
            _estaEntregado = estaEntregado;
        }

        protected override void AgregarParteMensaje()
        {
            if (_estaEntregado)
            {
                _mensajeEntregado.Append("salió");
            }
            else 
            {
                _mensajeEntregado.Append("ha salido");
            }
            _mensajeEntregado.Append(" de "+_origen);
        }
    }
}
