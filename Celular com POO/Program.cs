using Celular_com_POO.Models;
using System;

namespace Celular_com_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando instâncias de Samsung e Iphone
            Samsung samsung = new Samsung("(47) 9 9999-0000", "Samsung S23 Ultra", "Samsung", "567234789123", "256 GB");
            Iphone iphone = new Iphone("(47) 9 9999-0000", "Iphone 15 Pro Max", "Apple", "657123687789", "512 GB");
            //Eu iria utilizar a memória em formato int, porém teria que fazer um tipo diferente de formatação para colocar o GB,
            //então utilizei como string mesmo para simplificar o código

            // Exibindo informações dos smartphones
            ExibirInformacoesSmartphone(samsung);
            ExibirInformacoesSmartphone(iphone);

            // Ligar smartphones e receber ligação
            samsung.Ligar();
            samsung.receberLigacao();

            Console.WriteLine("\n");

            iphone.Ligar();
            iphone.receberLigacao();

            Console.WriteLine("\n");

            // Instalando aplicativos nos smartphones
            samsung.instalarAplicativo("WhatsApp");
            iphone.instalarAplicativo("Instagram");
        }

        static void ExibirInformacoesSmartphone(Smartphone smartphone)
        {
            Console.WriteLine($"Marca: {smartphone.getBrand()}");
            Console.WriteLine($"Modelo: {smartphone.getModel()}");
            Console.WriteLine($"Imei: {smartphone.getImei()}");
            Console.WriteLine($"Memória: {smartphone.getMemory()}");
            Console.WriteLine($"Número: {smartphone.Numero}");
            Console.WriteLine();
        }
    }
}
