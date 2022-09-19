using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaHospedagemHotel.Models
{
    public class Suite
    {
        public int IdSuite { get; set; }
        public int CapacidadeSuite { get; set; }
        public decimal ValorDiaria { get; set; }
       

        public Suite(int idSuite, int capacidadeSuite, decimal valorDiaria) {
            IdSuite = idSuite;
            CapacidadeSuite = capacidadeSuite;
            ValorDiaria = valorDiaria;
            
        }

        public Suite() {

        }
    }
}