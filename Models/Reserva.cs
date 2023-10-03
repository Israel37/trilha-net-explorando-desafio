namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public class CapacidadeExcedidaException : Exception
        {
            public CapacidadeExcedidaException(string mensagem) : base(mensagem)
            {
                 
            }
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
                // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
                // *IMPLEMENTADO!*

                if (Suite.Capacidade >= hospedes.Count)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    throw new CapacidadeExcedidaException("A capacidade da suíte é insuficiente para acomodar todos os hospedes.");

                }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(List<Pessoa> hospedes)
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTADO!*
            if (hospedes != null)
            {
                int quantidade = hospedes.Count;
                return quantidade;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTADO*

            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal desconto = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTADO*
            if (DiasReservados >= 10)
            {
                desconto = valor * 0.10m;
            }

            return valor - desconto;
        }
    }
}