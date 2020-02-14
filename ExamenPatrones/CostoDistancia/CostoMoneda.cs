using ExamenPatrones.CostoDistancia.Interfaces;
using ExamenPatrones.Distancia.Interfaces;

namespace ExamenPatrones.CostoDistancia
{
    public abstract class CostoMoneda : ICostoDistancia
    {

        public decimal CostoPorUnidadDistancia { get; set; } = 1;
        public string PrefijoMoneda { get; }
        public ITipoDistancia TipoDistancia { get; }

        protected CostoMoneda(ITipoDistancia tipoDistancia, string prefijoMoneda)
        {
            TipoDistancia = tipoDistancia;
            PrefijoMoneda = prefijoMoneda;
        }

        public decimal CostoTotal() 
        {
            return TipoDistancia.UnidadDistancia * CostoPorUnidadDistancia;
        }
    }
}
