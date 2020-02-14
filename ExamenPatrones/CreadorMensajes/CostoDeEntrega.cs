using ExamenPatrones.CostoDistancia.Interfaces;
using ExamenPatrones.CreadorMensajes.Interface;
using System.Text;

namespace ExamenPatrones.CreadorMensajes
{
    public class CostoDeEntrega : CreadorMensajeConsecutivo
    {
        private readonly bool _estaEntregado;
        private readonly ICostoDistancia _costoEnvio;

        public CostoDeEntrega(StringBuilder mensajeEntregado,
            bool estaEntregado,
            ICostoDistancia costoEnvio,
            ICreadorMensaje creadorMensajeSiguiente)
            : base(mensajeEntregado, creadorMensajeSiguiente)
        {
            _estaEntregado = estaEntregado;
            _costoEnvio = costoEnvio;
        }

        protected override void AgregarParteMensaje()
        {
            if (_estaEntregado)
            {
                _mensajeEntregado.Append("tuvó");
            }
            else
            {
                _mensajeEntregado.Append("tendrá");
            }
            _mensajeEntregado.Append(" un costo de " + _costoEnvio.CostoTotal());
        }
    }
}
