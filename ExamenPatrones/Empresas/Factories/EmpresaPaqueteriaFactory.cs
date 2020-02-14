using ExamenPatrones.CostoDistancia.Interfaces;
using ExamenPatrones.Distancia.Interfaces;
using ExamenPatrones.Empresas.Factories.Interfaces;
using ExamenPatrones.Empresas.Interfaces;
using ExamenPatrones.MediosTrasporte.Factories.Interfaces;
using System.Collections.Generic;

namespace ExamenPatrones.Empresas.Factories
{
    public abstract class EmpresaPaqueteriaFactory : IEmpresaPaqueteriaFactory
    {
        protected IEmpresaPaqueteria EmpresaPaqueteria { get; set; }

        protected EmpresaPaqueteriaFactory() 
        {

        }

        public IEmpresaPaqueteria CrearEmpresa()
        {
            InicializarEmpresa();
            AsignarTransportesDisponibles();
            AsignarMargenUtilidad();
            return EmpresaPaqueteria;
        }

        protected abstract void InicializarEmpresa();
        protected void AsignarTransportesDisponibles()
        {
            foreach (ITransporteFactory factory in TransportesDisponiblesEmpresa())
            {
                EmpresaPaqueteria.MediosTransporte.Add(factory.CrearTransporte());
            }
        }
        protected abstract void AsignarMargenUtilidad();

        protected abstract List<ITransporteFactory> TransportesDisponiblesEmpresa();

        protected abstract List<ICostoDistancia> CostosPorDistanciaDisponiblesEmpresa();

        protected abstract List<ITipoDistancia> DistanciasDisponiblesEmpresa();
    }
}
