
using ExamenPatrones.MediosTrasporte.Enumeradores;
using ExamenPatrones.MediosTrasporte.Interfaces;
using System.Collections.Generic;

namespace ExamenPatrones.Empresas.Interfaces
{
    public interface IEmpresaPaqueteria
    {
        string Nombre { get; }
        double MargenUtilidad { get; set; }
        List<IMedioTransporte> MediosTransporte { get; set; }

        IMedioTransporte ObtenerMedioDeTransporte(string tipoTransporte);
    }
}
