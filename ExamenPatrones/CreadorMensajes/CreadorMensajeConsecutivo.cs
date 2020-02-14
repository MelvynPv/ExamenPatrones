using ExamenPatrones.CreadorMensajes.Interface;
using System.Text;

namespace ExamenPatrones.CreadorMensajes
{
    public abstract class CreadorMensajeConsecutivo : ICreadorMensaje
    {
        protected readonly StringBuilder _mensajeEntregado;
        private readonly ICreadorMensaje _creadorMensajeSiguiente;

        protected CreadorMensajeConsecutivo(StringBuilder mensajeEntregado, ICreadorMensaje creadorMensajeSiguiente)
        {
            _mensajeEntregado = mensajeEntregado;
            _creadorMensajeSiguiente = creadorMensajeSiguiente;
        }

        public void AgregarMensaje()
        {
            AgregarParteMensaje();
            _mensajeEntregado.Append(' ');
            _creadorMensajeSiguiente.AgregarMensaje();
        }

        protected abstract void AgregarParteMensaje();
    }
}
