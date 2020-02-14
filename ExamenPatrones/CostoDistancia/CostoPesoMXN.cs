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

        public override decimal CostoTotal(int unidadDistancia)
        {
            return unidadDistancia * CostoPorUnidadDistancia;
        }

        //public override string ToString()
        //{
        //    return string.Format("costo de {0}{1}",PrefijoMoneda, CostoTotal());
        //}
    }
}
