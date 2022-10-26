namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        public string placa { get; set; }
        private List<string> veiculos = new List<string>();

        
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        
        public void AdicionarVeiculo()
        {
            // *Implementado*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
                   
        }

        public void RemoverVeiculo()
        {
            // *Implementado*
            Console.WriteLine("Digite a placa do veículo para remover:");
            
            string placa = (Console.ReadLine());
            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                veiculos.Remove(placa);
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
               
                // *Implementado*
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = 0;
                valorTotal = (precoInicial + precoPorHora * horas);


               // *Implementado*
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                for (int contador = 0; contador < veiculos.Count; contador++){
                    Console.WriteLine($"{veiculos[contador]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
