using System;
using System.Collections.Generic;

namespace ExamenPatrones.Lectores
{
    public class LectorAchivoCSV : ILectorArchivoPedido
    {
        public List<PeticionPedido> LeerArchivo()
        {
            List<PeticionPedido> pedidosEntity = new List<PeticionPedido>();
            string[] pedidos = System.IO.File.ReadAllLines(@"..\Archivos\pedidos.txt");

            foreach (string pedido in pedidos)
            {
                string[] parameters = pedido.Split(',');
                pedidosEntity.Add(new PeticionPedido()
                {
                    Origen = parameters[0],
                    Destino = parameters[1],
                    Distancia = parameters[2],
                    PaqueteriaCadena = parameters[3],
                    TransporteCadena = parameters[4],
                    FechaPedido = DateTime.Parse(parameters[5])
                });
            }

            return pedidosEntity;
        }

        //private static TipoEmpresaPaqueteria? ObtenerPaqueteria(string paqueteria)
        //{
        //    if (Enum.TryParse(paqueteria, true, out TipoEmpresaPaqueteria empresa)) 
        //    {
        //        return empresa;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //private static TipoTransporte? ObtenerTransporte(string transporte)
        //{
        //    if (Enum.TryParse(transporte, true, out TipoTransporte transporteEnum))
        //    {
        //        return transporteEnum;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }
}
