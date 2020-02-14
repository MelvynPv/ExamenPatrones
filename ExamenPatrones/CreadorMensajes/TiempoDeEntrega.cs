using ExamenPatrones.CreadorMensajes.Interface;
using ExamenPatrones.FormatoTiempo.Interfaces;
using System.Text;

namespace ExamenPatrones.CreadorMensajes
{
    public class TiempoDeEntrega: CreadorMensajeConsecutivo
    {
        private readonly bool _estaEntregado;
        private readonly IFormatoTiempo _formatoTiempo;

        public TiempoDeEntrega(StringBuilder mensajeEntregado,
            bool estaEntregado,
            IFormatoTiempo formatoTiempo,
            ICreadorMensaje creadorMensajeSiguiente)
            : base(mensajeEntregado, creadorMensajeSiguiente)
        {
            _estaEntregado = estaEntregado;
            _formatoTiempo = formatoTiempo;
        }

        protected override void AgregarParteMensaje()
        {
            if (_estaEntregado)
            {
                _mensajeEntregado.Append("hace");
            }
            else
            {
                _mensajeEntregado.Append("dentro de");
            }
            _mensajeEntregado.Append(" a " + _formatoTiempo.ObtenerTiempo());
        }
    }
}
