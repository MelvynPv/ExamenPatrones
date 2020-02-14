using ExamenPatrones.CostoDistancia.Interfaces;
using ExamenPatrones.MediosTrasporte.Factories.Interfaces;
using ExamenPatrones.MediosTrasporte.Interfaces;

namespace ExamenPatrones.MediosTrasporte.Factories
{
    public abstract class TransportesFactory : ITransporteFactory
    {
        protected readonly ICostoDistancia _costoDistancia;
        protected IMedioTransporte Transporte { get; set; }
        public int VelocidadTransporte { get; }

        protected TransportesFactory(ICostoDistancia costoDistancia, int velocidad)
        {
            _costoDistancia = costoDistancia;
            VelocidadTransporte = velocidad;
        }
        public IMedioTransporte CrearTransporte() 
        {
            InicializarTransporte();
            return Transporte;
        }
        protected abstract void InicializarTransporte();
    }
}
