using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOOSistemaCelular.Models
{
    internal abstract class Smartphone
    {
        public string Numero { get; set; }

        private string? Modelo;
        private string? IMEI;
        private int memoria;

        public Smartphone(string numero, string? modelo, string? iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            this.memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigação()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarAplicativo(string nome);
    }
}
