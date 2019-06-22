using System;

namespace POO
{
    public class CuentaCorriente
    {
        protected double saldo=0;
        public double Saldo
        {
            get {return saldo;}
        }

        public bool Extraccion(double cantidad)
        {
            if (cantidad <= 0)
            { return false;}
            this.saldo -= cantidad;
            return true;
        }
        public bool Deposito (double cantidad)
        {
            Console.WriteLine("Ejecutando Deposito como double {0}", cantidad);
            saldo += cantidad;
            return true;
        }

        public bool Deposito (double cantidad, double otracantidad)
        {
            Console.WriteLine("Ejecutando doble Deposito como double {0}", cantidad);
            saldo += cantidad;
            saldo += otracantidad;
            return true;
        }
        public bool Deposito (float cantidad)
        {
            Console.WriteLine("Ejecutando Deposito como float {0}", cantidad);
            saldo += cantidad;
            return true;
        }

        public bool Deposito (int cantidad)
        {
            Console.WriteLine("Ejecutando Deposito como int {0}", cantidad);
            saldo += cantidad;
            return true;
        }
        public bool Deposito (long cantidad)
        {
            Console.WriteLine("Ejecutando Deposito como long {0}", cantidad);
            saldo += cantidad;
            return true;
        }
        public static void NombrarCuenta()
        {
            Console.WriteLine("Llamando metodo sin instanciar la clase");
        }
    }
}