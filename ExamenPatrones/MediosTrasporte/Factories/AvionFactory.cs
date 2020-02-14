using ExamenPatrones.CostoDistancia.Interfaces;

namespace ExamenPatrones.MediosTrasporte.Factories
{
    public class AvionFactory : TransportesFactory
    {
        public AvionFactory(ICostoDistancia costoDistancia, int velocidad)
            : base(costoDistancia, velocidad)
        {
        }

        protected override void InicializarTransporte()
        {
            if (Transporte == null)
            {
                Transporte = new Avion(VelocidadTransporte)
                {
                    CostoDistancia = _costoDistancia
                };
            }
        }
    }
}
