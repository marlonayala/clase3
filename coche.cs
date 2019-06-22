using System;

namespace POO
{
    public class Coche
    {
        public string Patente;
        public string Color;
        public string Marca;
        public string Modelo;
        protected double velocidad;
        public double Velocidad
        {
            get {return velocidad;}            
        }
        public Coche(string _patente, string _color, string _marca, string _modelo )
        {
            this.Patente = _patente;
            this.Color = _color;
            this.Marca = _marca;
            this.Modelo = _modelo;
            this.velocidad =0;
        }

        public virtual void  Acelerar(double cantidad)
        {
            this.velocidad += cantidad;
            Console.WriteLine ("Incrementando la velocidad en: {0}", cantidad);
        }

        public void Frenar(double cantidad)
        {
            this.velocidad -= cantidad;
        }
        public void Girar(double cantidad)
        {
            
        }

    }
}