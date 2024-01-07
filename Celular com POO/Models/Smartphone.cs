using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celular_com_POO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Marca { get; set; }
        private string Imei { get; set; }
        private string Memoria { get; set; }

        public Smartphone(string numero, string modelo, string marca, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando o seu smartphone...");
        }

        public void receberLigacao()
        {
            Console.WriteLine("Recebendo ligação de DIO...");
        }

        public abstract void instalarAplicativo(string appName);

        public string getModel()
        {
            return Modelo;
        }

        public string getBrand()
        {
            return Marca;
        }

        public string getImei()
        {
            return Imei;
        }

        public string getMemory()
        {
            return Memoria;
        }
    }
}