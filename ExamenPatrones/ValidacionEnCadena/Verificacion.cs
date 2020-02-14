using ExamenPatrones.Lectores;
using ExamenPatrones.ValidacionEnCadena.Enumeradores;
using ExamenPatrones.ValidacionEnCadena.Interfaces;

namespace ExamenPatrones.ValidacionEnCadena
{
    public abstract class Verificacion : IVerificaciones
    {
        private IVerificaciones _verificacioSiguiente;

        public void SetVerificacionSiguiente(IVerificaciones verificacion)
        {
            _verificacioSiguiente = verificacion;
        }

        public TipoMensaje? Verificar(PeticionPedido peticionPedido)
        {
            if (_verificacioSiguiente != null)
            {
                return _verificacioSiguiente.Verificar(peticionPedido);
            }

            return null;
        }
    }
}
