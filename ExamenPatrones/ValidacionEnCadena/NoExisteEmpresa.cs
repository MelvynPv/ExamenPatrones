using ExamenPatrones.Lectores;
using ExamenPatrones.ValidacionEnCadena.Enumeradores;

namespace ExamenPatrones.ValidacionEnCadena
{
    public class NoExisteEmpresa : Verificacion
    {
        new public TipoMensaje? Verificar(PeticionPedido peticionPedido)
        {
            if (peticionPedido.Paqueteria == null)
            {
                return TipoMensaje.NoExisteEmpresa;
            }
            else
            {
                return base.Verificar(peticionPedido);
            }
        }
    }
}
