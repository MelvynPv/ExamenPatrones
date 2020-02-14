using ExamenPatrones.CostoDistancia.Interfaces;
using ExamenPatrones.MediosTrasporte.Factories.Interfaces;
using ExamenPatrones.MediosTrasporte.Interfaces;

namespace ExamenPatrones.MediosTrasporte.Factories
{
    public abstract class TransportesFactory : ITransporteFactory
    {
        protected readonly ICostoDistancia _costoDistancia;
        protected IMedioTransporte Transporte { get; set; }
        protected TransportesFactory(ICostoDistancia costoDistancia)
        {
            _costoDistancia = costoDistancia;
        }
        public IMedioTransporte CrearTransporte() 
        {
            InicializarTransporte();
            return Transporte;
        }
        protected abstract void InicializarTransporte();
    }
}
