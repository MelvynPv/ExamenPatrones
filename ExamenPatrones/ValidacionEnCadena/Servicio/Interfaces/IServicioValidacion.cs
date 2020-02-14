using ExamenPatrones.Empresas.Factories.Interfaces;
using ExamenPatrones.Lectores;

namespace ExamenPatrones.ValidacionEnCadena.Servicio.Interfaces
{
    public interface IValidadorPedido
    {
        bool Validar(IEmpresaPaqueteriaFactory empresaPaqueteriaFactory,
            PeticionPedido peticionPedido,
            out string mensajeError);
    }
}
