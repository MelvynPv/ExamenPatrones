using ExamenPatrones.Empresas.Factories.Interfaces;
using ExamenPatrones.Lectores;
using ExamenPatrones.ValidacionEnCadena.Enumeradores;
using System;
using System.Linq;

namespace ExamenPatrones.ValidacionEnCadena
{
    public class NoExisteTransporteEnEmpresa : Verificacion
    {
        private readonly IEmpresaPaqueteriaFactory _empresaPaqueteriaFactory;
        public NoExisteTransporteEnEmpresa(IEmpresaPaqueteriaFactory empresaPaqueteriaFactory)
        {
            _empresaPaqueteriaFactory = empresaPaqueteriaFactory;
        }

        new public TipoMensaje? Verificar(PeticionPedido peticionPedido)
        {
            if (peticionPedido.MedioTransporte == null)
            {
                return TipoMensaje.NoExisteTrasporte;
            }
            else
            {
                bool existetrasporte = _empresaPaqueteriaFactory.CrearEmpresa().MediosTransporte.Select(s => s.Tipo).Contains(peticionPedido.MedioTransporte.ToString().ToLower());

                if (existetrasporte)
                {
                    return base.Verificar(peticionPedido);
                }
                else
                {
                    return TipoMensaje.NoExisteTrasporte;
                }
            }
        }
    }
}
