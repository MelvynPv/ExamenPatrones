using ExamenPatrones.Distancia.Interfaces;
using System;

namespace ExamenPatrones.CostoDistancia
{
    public class CostoPesoMXN : CostoMoneda
    {
        public CostoPesoMXN(ITipoDistancia tipoDistancia, string prefijoMoneda)
            : base(tipoDistancia, prefijoMoneda)
        {

        }
    }
}
