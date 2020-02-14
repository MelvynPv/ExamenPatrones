namespace ExamenPatrones.MediosTrasporte
{
    public class Tren : Transporte
    {
        public Tren(int velocidad)
            :base(velocidad)
        {

        }

        public override string Tipo => "tren";
    }
}
