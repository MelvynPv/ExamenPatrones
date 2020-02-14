using ExamenPatrones.Empresas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPatrones.Empresas.Factories.Interfaces
{
    public interface ISucursalEmpresaPaqueteriaFactory
    {
        IEmpresaPaqueteria ObtenerEmpresa(string paqueteria);
    }
}
