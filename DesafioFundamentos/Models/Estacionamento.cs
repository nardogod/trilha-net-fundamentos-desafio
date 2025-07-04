namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            // Pedir para o usuário digitar a placa do veículo que deseja remover
            string placa = Console.ReadLine();     
    
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
                // e armazenar na variável horas
                int horas = int.Parse(Console.ReadLine());

                // Calcula o valor total a ser pago
                decimal valorTotal = precoInicial + precoPorHora * horas;
                           
                // Remove o veículo da lista
                veiculos.Remove(veiculos.First(x => x.ToUpper() == placa.ToUpper()));
                // Exibe o valor total a ser pago
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (string v in veiculos)
                {
                    Console.WriteLine(v);
                             
                }
            }
            else
                {
                    Console.WriteLine("Não há veículos estacionados.");
                }
        }
    }
}
