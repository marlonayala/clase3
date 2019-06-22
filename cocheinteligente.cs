using System;

namespace POO
{
    public class cocheinteligente : Coche
    {
        public cocheinteligente(string _patente, string _color, string _marca, string _modelo)         : base(_patente, _color, _marca, _modelo)
        {

        }

        public void Estacionar()
        {
            Console.WriteLine("Estacionando el coche automaticamente:");
            velocidad = 0;
        }

        public override void  Acelerar(double cantidad)
        {
            Console.WriteLine("Accionando mecanismo inteligente de acelaración {0}",cantidad);
            this.velocidad += cantidad;
        }
    }
}