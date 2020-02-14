using ExamenPatrones.CostoDistancia.Interfaces;
using ExamenPatrones.MediosTrasporte.Interfaces;

namespace ExamenPatrones.MediosTrasporte
{
    public abstract class Transporte : IMedioTransporte
    {
        public abstract string Tipo { get; }
        public ICostoDistancia CostoDistancia { get; set; }
    }
}
