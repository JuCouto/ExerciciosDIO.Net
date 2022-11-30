using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSistemaHospedagem.Models
{
    internal class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa( string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

        }

        public string _nome;
        private string Nome 
        { 
            get => _nome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode estar vazio");
                }
                _nome = value;
            }
        }
        private string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    }
}
