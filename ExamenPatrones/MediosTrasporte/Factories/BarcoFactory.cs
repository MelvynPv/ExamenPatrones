using ExamenPatrones.CostoDistancia.Interfaces;

namespace ExamenPatrones.MediosTrasporte.Factories
{
    public class BarcoFactory : TransportesFactory
    {
        public BarcoFactory(ICostoDistancia costoDistancia, int velocidad)
            : base(costoDistancia, velocidad)
        {
        }

        protected override void InicializarTransporte()
        {
            if (Transporte == null)
            {
                Transporte = new Barco(VelocidadTransporte)
                {
                    CostoDistancia = _costoDistancia
                };
            }
        }
    }
}
