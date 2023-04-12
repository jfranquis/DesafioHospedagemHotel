using System.Text;
using DesafioProjetoHospedagem.Models;


Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1", sobrenome: "Teste1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2", sobrenome: "Teste2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3", sobrenome: "Teste3");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 10, valorDiaria: 90);
Suite suite2 = new Suite(tipoSuite: "Luxo", capacidade: 3, valorDiaria: 70);
Suite suite3 = new Suite(tipoSuite: "Standard", capacidade: 4, valorDiaria: 50);
//Suite suite4 = new Suite(tipoSuite: "Comum", capacidade: 5, valorDiaria: 30);



// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine("Suite: {0} - Valor diária: {1}", suite.TipoSuite, suite.ValorDiaria);
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");