using ExamenPatrones.Empresas.Interfaces;
using ExamenPatrones.MediosTrasporte.Interfaces;
using System.Collections.Generic;

namespace ExamenPatrones.Empresas
{
    public class Fedex : EmpresaPaqueteria
    {
        public override string Nombre => "fedex";
    }
}
