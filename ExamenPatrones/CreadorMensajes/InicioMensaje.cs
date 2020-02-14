using ExamenPatrones.CreadorMensajes.Interface;
using System.Text;

namespace ExamenPatrones.CreadorMensajes
{
    public class InicioMensaje : CreadorMensajeConsecutivo
    {
        public InicioMensaje(StringBuilder mensajeEntregado, ICreadorMensaje creadorMensajeSiguiente)
            :base(mensajeEntregado, creadorMensajeSiguiente)
        {
        }

        protected override void AgregarParteMensaje()
        {
            _mensajeEntregado.Append("Tu paquete");
        }
    }
}
