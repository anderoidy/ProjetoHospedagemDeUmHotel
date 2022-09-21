using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaHospedagemHotel.Models
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nomePessoa) {
            NomePessoa = nomePessoa;
        }
        
        public Pessoa(string nomePessoa, string sobreNome) {
            NomePessoa = nomePessoa;
            SobreNomePessoa = sobreNome;
        }
        
        public string? NomePessoa { get; set; }
        public string? SobreNomePessoa { get; set; }
        public string? NomeCompleto => $"{NomePessoa} {SobreNomePessoa}".ToUpper();
    }   
}