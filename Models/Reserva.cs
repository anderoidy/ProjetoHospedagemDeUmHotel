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


        public void CadastrarHospedes(List<Pessoa> hospedes) {
            
        }

    }
}