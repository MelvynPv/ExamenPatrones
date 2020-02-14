using ExamenPatrones.CostoDistancia.Interfaces;

namespace ExamenPatrones.MediosTrasporte.Factories
{
    public class AvionFactory : TransportesFactory
    {
        public AvionFactory(ICostoDistancia costoDistancia)
            : base(costoDistancia)
        {
        }

        protected override void InicializarTransporte()
        {
            if (Transporte == null)
            {
                Transporte = new Avion
                {
                    CostoDistancia = _costoDistancia
                };
            }
        }
    }
}
