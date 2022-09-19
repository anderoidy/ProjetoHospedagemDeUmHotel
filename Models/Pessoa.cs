using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaHospedagemHotel.Models
{
    public class Pessoa
    {
        
        public int IdPessoa { get; set; }
        public string  NomePessoa { get; set; }
        public string SobreNomePessoa { get; set; }
         public string NomeCompleto => $"{NomePessoa} {SobreNomePessoa}";


        public Pessoa(int idPessoa, string nomePessoa, string sobreNome) {
            IdPessoa = idPessoa;
            NomePessoa = nomePessoa;
            SobreNomePessoa = sobreNome;
        }

         public Pessoa() {
            
        }
    }

   
}