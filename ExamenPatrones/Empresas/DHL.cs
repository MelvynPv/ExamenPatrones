using ExamenPatrones.Empresas.Interfaces;
using ExamenPatrones.MediosTrasporte.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenPatrones.Empresas
{
    public class DHL: EmpresaPaqueteria
    {
        public override string Nombre => "dhl";
    }
}
