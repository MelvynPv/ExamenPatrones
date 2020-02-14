using ExamenPatrones.CostoDistancia.Interfaces;

namespace ExamenPatrones.MediosTrasporte.Interfaces
{
    public interface IMedioTransporte
    {
        string Tipo { get; }
        int VelocidadDistancia { get; }
        ICostoDistancia CostoDistancia { get; set; }
    }
}
