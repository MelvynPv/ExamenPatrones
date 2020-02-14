using ExamenPatrones.Empresas.Factories.Interfaces;
using ExamenPatrones.Empresas.Interfaces;
using ExamenPatrones.Lectores;
using ExamenPatrones.MediosTrasporte.Interfaces;
using ExamenPatrones.ValidacionEnCadena.Servicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPatrones.MensajeServicio
{
    public class ServicioMensaje
    {
        private readonly ILectorArchivoPedido lectorArchivoPedido;
        private readonly ISucursalEmpresaPaqueteriaFactory sucursal;

        public ServicioMensaje(
            ILectorArchivoPedido lectorArchivoPedido,
            ISucursalEmpresaPaqueteriaFactory sucursal)
        {
            this.lectorArchivoPedido = lectorArchivoPedido;
            this.sucursal = sucursal;
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
                    IMedioTransporte medioTransporte = empresaPaqueteria.ObtenerMedioDeTransporte(pedido.TransporteCadena.ToLower());


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
