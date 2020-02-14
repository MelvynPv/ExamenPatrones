using ExamenPatrones.Empresas.Interfaces;
using ExamenPatrones.MediosTrasporte.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamenPatrones.Empresas
{
    public abstract class EmpresaPaqueteria : IEmpresaPaqueteria
    {
        public abstract string Nombre { get; }
        public double MargenUtilidad { get; set; } = 1;
        public List<IMedioTransporte> MediosTransporte { get; set; } = new List<IMedioTransporte>();


        public IMedioTransporte ObtenerMedioDeTransporte(string tipoTransporte)
        {
            IMedioTransporte transporte = MediosTransporte.FirstOrDefault(x => x.Tipo == tipoTransporte);

            if (transporte == null)
            {
                string mensajeError = string.Format("{0} no ofrece el servicio de transporte {1}, te recomendamos cotizar en otra empresa.", Nombre, tipoTransporte);
                throw new ArgumentException(mensajeError);
            }

            return transporte;
        }
    }
}
