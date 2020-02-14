namespace ExamenPatrones.MediosTrasporte
{
    public class Avion : Transporte
    {
        public Avion(int velocidad)
            :base(velocidad)
        {
        }
        public override string Tipo => "avion";

    }
}
