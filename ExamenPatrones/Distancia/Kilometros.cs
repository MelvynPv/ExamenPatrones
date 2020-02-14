﻿using ExamenPatrones.Distancia.Interfaces;

namespace ExamenPatrones.Distancia
{
    public class Kilometros : ITipoDistancia
    {
        public string Contraccion => "km";

        public int UnidadDistancia { get; set; }
    }
}
