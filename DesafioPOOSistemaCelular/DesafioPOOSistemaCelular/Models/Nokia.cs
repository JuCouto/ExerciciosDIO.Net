using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOOSistemaCelular.Models
{
    internal class Nokia : Smartphone
    {
        public Nokia(string numero, string? modelo, string? iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {

        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo... \nAplicativo {nome.ToUpper()} instalado com sucesso!!");
        }
    }
}
