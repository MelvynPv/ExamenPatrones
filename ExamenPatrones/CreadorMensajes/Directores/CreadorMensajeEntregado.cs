using ExamenPatrones.CostoDistancia.Interfaces;
using ExamenPatrones.Empresas.Interfaces;
using ExamenPatrones.FormatoTiempo.Interfaces;
using ExamenPatrones.Lectores;
using ExamenPatrones.MediosTrasporte.Interfaces;
using System.Text;

namespace ExamenPatrones.CreadorMensajes.Directores
{
    public class CreadorMensajeEntregado
    {
        private readonly IEmpresaPaqueteria empresaPaqueteria;
        private readonly IFormatoTiempo formatoTiempo;

        public CreadorMensajeEntregado(IEmpresaPaqueteria empresaPaqueteria, IFormatoTiempo formatoTiempo)
        {
            this.empresaPaqueteria = empresaPaqueteria;
            this.formatoTiempo = formatoTiempo;
        }

        public string CrearMensajeEntregado(PeticionPedido peticionPedido, bool paqueteEntregado)
        {
            StringBuilder mensajeResultante = new StringBuilder();
            IMedioTransporte medioTransporte = empresaPaqueteria.ObtenerMedioDeTransporte(peticionPedido.TransporteCadena.ToLower());
            ICostoDistancia costoDistancia = medioTransporte.CostoDistancia;

            ReclamacionPaqueteria reclamacionPaqueteria = new ReclamacionPaqueteria(mensajeResultante, peticionPedido.PaqueteriaCadena);
            CostoDeEntrega costoDeEntrega = new CostoDeEntrega(mensajeResultante, paqueteEntregado, costoDistancia, reclamacionPaqueteria);
            NexoY nexoY2 = new NexoY(mensajeResultante, costoDeEntrega);
            TiempoDeEntrega tiempoDeEntrega = new TiempoDeEntrega(mensajeResultante, paqueteEntregado, formatoTiempo, nexoY2);
            EstadoDeEntrega estadoDeEntrega = new EstadoDeEntrega(mensajeResultante, paqueteEntregado, peticionPedido.Destino, tiempoDeEntrega);
            NexoY nexoY = new NexoY(mensajeResultante, estadoDeEntrega);
            EstadoDeSalida estadoDeSalida = new EstadoDeSalida(mensajeResultante, paqueteEntregado, peticionPedido.Origen, nexoY);
            InicioMensaje inicioMensaje = new InicioMensaje(mensajeResultante, estadoDeSalida);

            inicioMensaje.AgregarMensaje();

            return mensajeResultante.ToString();
        }
    }
}
