using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reserva
    {
       
        public int DiasReservados { get; set; }
        public Suite Suite { get; set; }
        public List<Pessoa> Hospedes { get; set; }

        public Reserva()
        {

        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public Reserva(int diasReservados, Suite suite, List<Pessoa> hospedes)
        {
            DiasReservados = diasReservados;
            Suite = suite;
            Hospedes = hospedes;
        }

        
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
         

            if (Suite.Capacidade == hospedes.Count)
            {
                Hospedes = hospedes;
                Console.WriteLine("Chekout Concluido ");
                Console.WriteLine($"Suite Capacidade: {Suite.Capacidade}");
                Console.WriteLine($"Quantidade de hopoede: {hospedes.Count}");

            }
            else if(Suite.Capacidade > hospedes.Count)
            {
                Console.WriteLine("Chekout Não Concluido ");
                Console.WriteLine("Quantidade de hospedes maior que a capacidade da suite");
                Console.WriteLine($"Suite Capacidade: {Suite.Capacidade}");
                Console.WriteLine($"Quantidade de hopoede: {hospedes.Count}");

            }
                  
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                Console.WriteLine("Chekout Não Concluido ");
                Console.WriteLine("Quantidade de hospedes menor que a capacidade da suite");
                Console.WriteLine($"Suite Capacidade: {Suite.Capacidade}");
                Console.WriteLine($"Quantidade de hopoede: {hospedes.Count}");



            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        
        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            Console.WriteLine();
            int quantidade = Hospedes?.Count ?? 0;

           
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*

         

            if (Hospedes != null)
            {
                Console.WriteLine($"Valor Diaria: {Suite.ValorDiaria}");
                Console.WriteLine($"Dias Reservados: {DiasReservados}");
                
                if (DiasReservados >= 10)
                {
                    valor = valor * 0.90m;
                    return valor;
                }

                return valor;

            }
            return valor =0;

        }
    }
}
