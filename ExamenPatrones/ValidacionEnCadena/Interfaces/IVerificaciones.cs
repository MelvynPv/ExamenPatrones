using ExamenPatrones.Lectores;
using ExamenPatrones.ValidacionEnCadena.Enumeradores;

namespace ExamenPatrones.ValidacionEnCadena.Interfaces
{
    public interface IVerificaciones
    {
        void SetVerificacionSiguiente(IVerificaciones verificacion);

        TipoMensaje? Verificar(PeticionPedido peticionPedido);
    }
}
