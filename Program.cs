using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaCorriente.NombrarCuenta();
            CuentaCorriente cuenta = new CuentaCorriente();
            cuenta.Deposito(200.55);
            Console.WriteLine("el saldo de la cuenta es: {0}", cuenta.Saldo);
            cuenta.Deposito(200.55, 600);
            Console.WriteLine("el saldo de la cuenta es: {0}", cuenta.Saldo);
            cuenta.Deposito(35.89F);
            Console.WriteLine("el saldo de la cuenta es: {0}", cuenta.Saldo);
            cuenta.Deposito(35.89F);
            Console.WriteLine("el saldo de la cuenta es: {0}", cuenta.Saldo);
            cuenta.Deposito(100);
            Console.WriteLine("el saldo de la cuenta es: {0}", cuenta.Saldo);
            cuenta.Deposito(300L);
            Console.WriteLine("el saldo de la cuenta es: {0}", cuenta.Saldo);
        }
        static void Maincoche()
        {
            //Coche micoche= new Coche("OOT854","GRIS","RENAULT","CLIO");
            cocheinteligente micoche = new cocheinteligente("OOT854","GRIS","RENAULT","CLIO");
            Console.WriteLine("Los datos de mi coche son: ");
            Console.WriteLine("Marca: {0}",micoche.Marca);
            Console.WriteLine("Color: {0}",micoche.Color);
            Console.WriteLine("Modelo: {0}",micoche.Modelo);
            Console.WriteLine("Patente: {0}", micoche.Patente);

            micoche.Acelerar(100);
            Console.WriteLine("Velocidad: {0}",micoche.Velocidad);
            micoche.Estacionar();
            Console.WriteLine("Velocidad: {0}",micoche.Velocidad);
        }
    }
}
