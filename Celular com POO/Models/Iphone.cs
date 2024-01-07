using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celular_com_POO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string marca, string imei, string memoria)
            : base(numero, modelo, marca, imei, memoria)
        {
        }

        public override void instalarAplicativo(string appName)
        {
            Console.WriteLine($"Instalando {appName} no seu Iphone 15 Pro Max...");
        }
    }
}
