namespace ExamenPatrones.MediosTrasporte
{
    public class Barco : Transporte
    {
        public Barco(int velocidad)
            : base(velocidad) 
        {

        }
        public override string Tipo => "barco";
    }
}
