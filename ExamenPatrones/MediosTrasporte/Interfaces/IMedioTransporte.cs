using ExamenPatrones.CostoDistancia.Interfaces;

namespace ExamenPatrones.MediosTrasporte.Interfaces
{
    public interface IMedioTransporte
    {
        string Tipo { get; }
        ICostoDistancia CostoDistancia { get; set; }
    }
}
