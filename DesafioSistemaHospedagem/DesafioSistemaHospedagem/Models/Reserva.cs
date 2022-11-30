using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSistemaHospedagem.Models
{
    internal class Reserva
    {
        public Reserva()
        {

        }
        public Reserva( int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("Número de usuários excedeu a capacidade");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
        }

        public int ObterQuantidadeHospede()
        {
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal CalculoDiaria =  DiasReservados * Suite.ValorDiaria;
           

            if(DiasReservados >= 10)
            {
                decimal desconto = 10.0M / 100.0M;

                CalculoDiaria = CalculoDiaria - (desconto * CalculoDiaria);
            }
            return CalculoDiaria;
        }
    }
}
