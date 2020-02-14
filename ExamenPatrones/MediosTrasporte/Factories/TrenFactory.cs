using ExamenPatrones.CostoDistancia.Interfaces;

namespace ExamenPatrones.MediosTrasporte.Factories
{
    public class TrenFactory : TransportesFactory
    {

        public TrenFactory(ICostoDistancia costoDistancia, int velocidad)
            : base(costoDistancia, velocidad)
        {
        }
        protected override void InicializarTransporte()
        {
            if (Transporte == null)
            {
                Transporte = new Tren(VelocidadTransporte)
                {
                    CostoDistancia = _costoDistancia
                };
            }
        }
    }
}
