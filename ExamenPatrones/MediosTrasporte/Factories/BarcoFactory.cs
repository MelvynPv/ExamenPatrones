using ExamenPatrones.CostoDistancia.Interfaces;

namespace ExamenPatrones.MediosTrasporte.Factories
{
    public class BarcoFactory : TransportesFactory
    {
        public BarcoFactory(ICostoDistancia costoDistancia)
            : base(costoDistancia)
        {
        }

        protected override void InicializarTransporte()
        {
            if (Transporte == null)
            {
                Transporte = new Barco
                {
                    CostoDistancia = _costoDistancia
                };
            }
        }
    }
}
