﻿using ExamenPatrones.CostoDistancia;
using ExamenPatrones.CostoDistancia.Interfaces;
using ExamenPatrones.Distancia;
using ExamenPatrones.Distancia.Interfaces;
using ExamenPatrones.MediosTrasporte.Factories;
using ExamenPatrones.MediosTrasporte.Factories.Interfaces;
using System.Collections.Generic;

namespace ExamenPatrones.Empresas.Factories
{
    public class DHLFactory : EmpresaPaqueteriaFactory
    {
        protected override void AsignarMargenUtilidad()
        {
            EmpresaPaqueteria.MargenUtilidad = 0.4;//40%
        }

        protected override List<ITransporteFactory> TransportesDisponiblesEmpresa()
        {
            List<ITransporteFactory> medioTransportes = new List<ITransporteFactory>();

            foreach (ICostoDistancia costo in CostosPorDistanciaDisponiblesEmpresa())
            {
                medioTransportes.Add(new BarcoFactory(costo,46));
                medioTransportes.Add(new AvionFactory(costo,600));
            }

            return medioTransportes;
        }

        protected override List<ICostoDistancia> CostosPorDistanciaDisponiblesEmpresa()
        {
            List<ICostoDistancia> costosPorDistancia = new List<ICostoDistancia>();

            foreach (ITipoDistancia distancia in DistanciasDisponiblesEmpresa())
            {
                costosPorDistancia.Add(new CostoPesoMXN(distancia, "$"));
            }

            return costosPorDistancia;
        }

        protected override List<ITipoDistancia> DistanciasDisponiblesEmpresa()
        {
            List<ITipoDistancia> tipoDistancias = new List<ITipoDistancia>()
            {
                new Kilometros()
            };

            return tipoDistancias;
        }

        protected override void InicializarEmpresa()
        {
            if (EmpresaPaqueteria == null)
            {
                EmpresaPaqueteria = new DHL();
            }
        }
    }
}
