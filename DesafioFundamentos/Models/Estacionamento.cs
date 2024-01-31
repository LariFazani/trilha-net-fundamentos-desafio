namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        string placa;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            //Atribui o valor do parâmetro ao membro de instância
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            
            //Verifica se foi digitada a placa com 7 caracteres
            if (placa.Length == 7){
                veiculos.Add(placa);
                Console.WriteLine("O veículo foi cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro: A placa deve ter exatamente 7 caracteres. Tente novamente.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            placa = Console.ReadLine();

            // Verifica se o veículo existe e converte as placas para letras maiúsculas
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0; 
                //O método Console.ReadLine() retorna uma string e a variável horas é do tipo int
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);

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
                // *IMPLEMENTE AQUI*
                    foreach(var placa in veiculos)
                {
                    Console.WriteLine(placa);
                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

