using System.Text;
using sistemaHospedagemHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("\nSistema de Hospedagem do Hotel \n");

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

//Cria um hospede
Pessoa p1 = new Pessoa(nomePessoa: "Anderson");
Pessoa p2 = new Pessoa(nomePessoa: "Andrew");

hospedes.Add(p1);
hospedes.Add(p2);

//Cria uma suite
Suite suite = new Suite(tipoSuite: "Premium", capacidadeSuite: 3, valorDiaria: 30);

// Cria uma nova reserva passando a suite e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Exibe a quantidade de hospedes e o valor da diaria
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diaria: {reserva.CalcularValorDiaria()}");

