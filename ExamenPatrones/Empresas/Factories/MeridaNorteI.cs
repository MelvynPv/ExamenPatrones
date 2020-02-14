using ExamenPatrones.Empresas.Enumeradores;
using ExamenPatrones.Empresas.Interfaces;
using System;
namespace ExamenPatrones.Empresas.Factories.Interfaces
{
    public class MeridaNorteI: ISucursalEmpresaPaqueteriaFactory
    {
        public IEmpresaPaqueteria ObtenerEmpresa(string paqueteria)
        {
            IEmpresaPaqueteria empresaPaqueteria;
            TipoEmpresaPaqueteria? opcion = null;
            if (Enum.TryParse(paqueteria, true, out TipoEmpresaPaqueteria result))
            {
                opcion = result;
            }

            switch (opcion)
            {
                case TipoEmpresaPaqueteria.Fedex:
                    empresaPaqueteria = new FedexFactory().CrearEmpresa();
                    break;
                case TipoEmpresaPaqueteria.Estafeta:
                    empresaPaqueteria = new EstafetaFactory().CrearEmpresa();
                    break;
                case TipoEmpresaPaqueteria.Dhl:
                    empresaPaqueteria = new DHLFactory().CrearEmpresa();
                    break;
                default:
                    string mesajeError = string.Format("La Paquetería: {0} no se encuentra registrada en nuestra red de distribución.", paqueteria);
                    throw new ArgumentException(mesajeError);
            }

            return empresaPaqueteria;
        }
    }
}
