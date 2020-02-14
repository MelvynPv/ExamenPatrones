using ExamenPatrones.CostoDistancia.Interfaces;

namespace ExamenPatrones.MediosTrasporte.Factories
{
    public class TrenFactory : TransportesFactory
    {

        public TrenFactory(ICostoDistancia costoDistancia)
            : base(costoDistancia)
        {
        }
        protected override void InicializarTransporte()
        {
            if (Transporte == null)
            {
                Transporte = new Tren
                {
                    CostoDistancia = _costoDistancia
                };
            }
        }
    }
}
