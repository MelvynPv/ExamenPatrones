using ExamenPatrones.Distancia.Interfaces;

namespace ExamenPatrones.CostoDistancia.Interfaces
{
    public interface ICostoDistancia
    {
        string PrefijoMoneda { get; }
        decimal CostoPorUnidadDistancia { get; set; }
        ITipoDistancia TipoDistancia { get;}
        decimal CostoTotal();
    }
}
