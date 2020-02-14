using ExamenPatrones.Empresas.Factories.Interfaces;
using ExamenPatrones.FormatoTiempo.Factories;
using ExamenPatrones.FormatoTiempo.Factories.Interfaces;
using ExamenPatrones.Lectores;
using ExamenPatrones.MensajeServicio;
using System;

namespace ExamenPatrones
{
    class Program
    {
        static void Main(string[] args)
        {
            ILectorArchivoPedido lector = new LectorAchivoCSV();
            ISucursalEmpresaPaqueteriaFactory sucursal = new MeridaNorteI();
            DateTime fechaActual = DateTime.Now;
            IFormatosTiempoEspecificos formatosTiempoEspecifico = new FormatosTiempoFactory();

            ServicioMensaje servicioMensaje = new ServicioMensaje(lector, sucursal, fechaActual, formatosTiempoEspecifico);

            string respuesta = servicioMensaje.ObtenerRespuesta();

            Console.WriteLine(respuesta);
        }
    }
}
