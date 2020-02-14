using ExamenPatrones.Empresas.Enumeradores;
using ExamenPatrones.MediosTrasporte.Enumeradores;
using System;

namespace ExamenPatrones.Lectores
{
    public class PeticionPedido
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Distancia { get; set; }
        public TipoEmpresaPaqueteria? Paqueteria { get; set; }
        public string PaqueteriaCadena { get; set; }
        public TipoTransporte? MedioTransporte { get; set; }
        public string TransporteCadena { get; set; }
        public DateTime FechaPedido { get; set; }
    }
}
