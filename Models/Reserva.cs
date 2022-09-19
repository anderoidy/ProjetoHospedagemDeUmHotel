using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaHospedagemHotel.Models
{
    public class Reserva
    {
        List<Pessoa> hospedes = new List<Pessoa>();
        Suite suite = new Suite();
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados) {
            DiasReservados = diasReservados;
        }


        // Declaracao dos metodos 
        public void CadastrarHospedes(List<Pessoa> hospedes) {
            
        }

        public void CadastrarSuite(Suite suite) {

        }

        public int ObterQuantidadeHospedes() {
            return 0;
        }

        public decimal CalcularValorDiaria() {
            return 0;
        }





    }
}