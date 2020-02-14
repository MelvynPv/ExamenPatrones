using System.Collections.Generic;

namespace ExamenPatrones.Lectores
{
    public interface ILectorArchivoPedido
    {
        List<PeticionPedido> LeerArchivo();
    }
}