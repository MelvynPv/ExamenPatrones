using ExamenPatrones.Empresas.Factories.Interfaces;
using ExamenPatrones.Lectores;
using ExamenPatrones.MensajeServicio;
using ExamenPatrones.ValidacionEnCadena.Servicio;
using ExamenPatrones.ValidacionEnCadena.Servicio.Interfaces;

namespace ExamenPatrones
{
    class Program
    {
        static void Main(string[] args)
        {
            ILectorArchivoPedido lector = new LectorAchivoCSV();
            IValidadorPedido validadorPedido = new ValidadorEnpresaTransporte();
            ISucursalEmpresaPaqueteriaFactory sucursal = new MeridaNorteI();

            ServicioMensaje servicioMensaje = new ServicioMensaje(
                lector,
                sucursal);

            servicioMensaje.ObtenerRespuesta();
        }
    }
}
