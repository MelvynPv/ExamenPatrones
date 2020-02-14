using ExamenPatrones.CreadorMensajes.Interface;
using System.Text;

namespace ExamenPatrones.CreadorMensajes
{
    public class ReclamacionPaqueteria : ICreadorMensaje
    {
        private readonly StringBuilder _mensajeEntregado;
        private readonly string _paqueteria;

        public ReclamacionPaqueteria(StringBuilder mensajeEntregado, string paqueteria)
        {
            _mensajeEntregado = mensajeEntregado;
            _paqueteria = paqueteria;
        }

        public void AgregarMensaje()
        {
            _mensajeEntregado.Append(string.Format("(Cualquier reclamación con {0})", _paqueteria));
        }
    }
}
