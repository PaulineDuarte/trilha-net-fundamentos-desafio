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
           
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string Novoveiculo = Console.ReadLine();
            veiculos.Add(Novoveiculo);
        
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
           

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                String HorasEstacinadasStr = Console.ReadLine();
 
                if (int.TryParse(HorasEstacinadasStr, out int HorasEstacionadas)){

                    decimal valorTotal = precoInicial  + (precoPorHora * HorasEstacionadas) ;

                    Console.WriteLine($"O Valor Total a ser pago pelo veiculo {placa} é : R$ {valorTotal}");

                    
                    veiculos.Remove(placa); 
                    Console.WriteLine("Placa removida com sucesso");
                   

                   } 
                else {
                    Console.WriteLine("Entrada Invalida. Por favor digite um número válido de horas.");
                }
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

                foreach (string veiculo in veiculos) {
                    Console.WriteLine(veiculo);
                };
    
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
