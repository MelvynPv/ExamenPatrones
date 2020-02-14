namespace ExamenPatrones.CreadorMensajes.Interface
{
    /// <summary>
    /// decorador.
    /// </summary>
    public interface ICreadorMensaje
    {
        /// <summary>
        /// Tu paquete [Expresión1] de [Origen] y [Expresión2] a [Destino]
        //[Expresión3] [Rango de Tiempo] y[Expresión4] un costo de[Costo
        ///de envío] (Cualquier reclamación con[Paquetería]).
        ///
        /// La Paquetería: [Paquetería] no se encuentra registrada en nuestra red de distribución.
        /// 
        /// [Paquetería] no ofrece el servicio de transporte [Medio de Transporte], te recomendamos cotizar en otra empresa.
        /// 
        /// Si hubieras pedido en [Paquetería] te hubiera costado (Diferencia de costos de envío).
        /// </summary>
        void AgregarMensaje();
    }
}
