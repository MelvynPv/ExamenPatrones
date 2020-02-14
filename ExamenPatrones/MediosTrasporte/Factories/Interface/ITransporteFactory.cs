using ExamenPatrones.MediosTrasporte.Interfaces;

namespace ExamenPatrones.MediosTrasporte.Factories.Interfaces
{
    public interface ITransporteFactory
    {
        IMedioTransporte CrearTransporte();
    }
}
