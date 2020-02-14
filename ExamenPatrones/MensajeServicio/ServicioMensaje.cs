using ExamenPatrones.CreadorMensajes.Directores;
using ExamenPatrones.Empresas.Factories.Interfaces;
using ExamenPatrones.Empresas.Interfaces;
using ExamenPatrones.FormatoTiempo.Factories.Interfaces;
using ExamenPatrones.FormatoTiempo.Interfaces;
using ExamenPatrones.Lectores;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPatrones.MensajeServicio
{
    public class ServicioMensaje
    {
        private readonly ILectorArchivoPedido lectorArchivoPedido;
        private readonly ISucursalEmpresaPaqueteriaFactory sucursal;
        private readonly DateTime tiempoActual;
        private readonly IFormatosTiempoEspecificos formatosTiempoEspecificos;

        public ServicioMensaje(
            ILectorArchivoPedido lectorArchivoPedido,
            ISucursalEmpresaPaqueteriaFactory sucursal,
            DateTime tiempoActual,
            IFormatosTiempoEspecificos formatosTiempoEspecificos)
        {
            this.lectorArchivoPedido = lectorArchivoPedido;
            this.sucursal = sucursal;
            this.tiempoActual = tiempoActual;
            this.formatosTiempoEspecificos = formatosTiempoEspecificos;
        }

        public string ObtenerRespuesta()
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<PeticionPedido> pedidos = lectorArchivoPedido.LeerArchivo();
            IEmpresaPaqueteria empresaPaqueteria;

            foreach (PeticionPedido pedido in pedidos)
            {
                try
                {
                    empresaPaqueteria = sucursal.ObtenerEmpresa(pedido.PaqueteriaCadena);
                    IFormatoTiempo formatoTiempo = formatosTiempoEspecificos.ObtenerFormatoTiempo(tiempoActual, pedido.FechaPedido);
                    string mensaje = new CreadorMensajeEntregado(empresaPaqueteria, formatoTiempo).CrearMensajeEntregado(pedido, true);
                    stringBuilder.AppendLine(mensaje);

                }
                catch (Exception err)
                {
                    stringBuilder.AppendLine(err.Message);
                }
            }
            return stringBuilder.ToString();
        }

    }
}
