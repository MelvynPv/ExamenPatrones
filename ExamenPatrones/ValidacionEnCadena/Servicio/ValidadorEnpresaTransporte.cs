using ExamenPatrones.Empresas.Factories.Interfaces;
using ExamenPatrones.Lectores;
using ExamenPatrones.ValidacionEnCadena.Enumeradores;
using ExamenPatrones.ValidacionEnCadena.Servicio.Interfaces;

namespace ExamenPatrones.ValidacionEnCadena.Servicio
{
    public class ValidadorEnpresaTransporte: IValidadorPedido
    {
        public bool Validar(IEmpresaPaqueteriaFactory empresaPaqueteriaFactory,
            PeticionPedido peticionPedido,
            out string mensajeError)
        {
            bool EsValida = false;
            NoExisteEmpresa noExisteEmpresa = new NoExisteEmpresa();
            NoExisteTransporteEnEmpresa noExisteTransporteEnEmpresa = new NoExisteTransporteEnEmpresa(empresaPaqueteriaFactory);

            noExisteEmpresa.SetVerificacionSiguiente(noExisteTransporteEnEmpresa);

            TipoMensaje? mensaje = noExisteEmpresa.Verificar(peticionPedido);

            switch (mensaje)
            {
                case TipoMensaje.NoExisteEmpresa:
                    mensajeError = string.Format("La Paquetería: {0} no se encuentra registrada en nuestra red de distribución.", peticionPedido.PaqueteriaCadena);
                    break;
                case TipoMensaje.NoExisteTrasporte:
                    mensajeError = string.Format("{0} no ofrece el servicio de transporte {1}, te recomendamos cotizar en otra empresa.", peticionPedido.PaqueteriaCadena, peticionPedido.TransporteCadena);
                    break;
                default:
                    mensajeError = "";
                    EsValida = true;
                    break;
            }

            return EsValida;
        }
    }
}
