using System;

namespace gerenciamentoFunc
{
    /// <summary>
    /// Representa um funcionário do tipo Desenvolvedor.
    /// Herda da classe abstrata Funcionario e adiciona cálculo de horas extras.
    /// </summary>
    internal class Desenvolvedor : Funcionario
    {
        // Número de horas extras trabalhadas
        public int HorasExtras { get; set; }

        // Valor pago por cada hora extra
        public decimal ValorPorHorasExtras { get; set; }

        /// <summary>
        /// Construtor do Desenvolvedor.
        /// </summary>
        public Desenvolvedor(string nome, int idade, string cargo,
            decimal salario, string formaPagamento, string metEntrPag,
            int horasExtras, decimal valorPorHorasExtras, decimal impostos)
            : base(nome, idade, cargo, salario, formaPagamento, metEntrPag, impostos)
        {
            HorasExtras = horasExtras;
            ValorPorHorasExtras = valorPorHorasExtras;
        }

        /// <summary>
        /// Calcula os impostos com base no salário total (incluindo horas extras).
        /// Imposto fixo de 10% sobre o valor bruto.
        /// </summary>
        public override decimal CalcularImpostos()
        {
            return (Salario + (HorasExtras * ValorPorHorasExtras)) * 0.10m;
        }

        /// <summary>
        /// Calcula o salário final incluindo horas extras e descontando os impostos.
        /// </summary>
        public override decimal CalcularSalario()
        {
            decimal valorHorasExtras = HorasExtras * ValorPorHorasExtras;
            decimal impostos = CalcularImpostos();
            decimal salarioFinal = Salario + valorHorasExtras - impostos;

            Console.WriteLine($"Valor total das horas extras: {valorHorasExtras:C}");

            return salarioFinal;
        }

        /// <summary>
        /// Informa como o pagamento será entregue.
        /// </summary>
        public override string EntregarPagamento()
        {
            return $"O pagamento será entregue de forma: {MetodoEntregaPagamento}";
        }

        /// <summary>
        /// Exibe todas as informações do desenvolvedor no console,
        /// incluindo salário final e impostos.
        /// </summary>
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Horas Extras: {HorasExtras}, Valor por Hora Extra: {ValorPorHorasExtras:C}");
            Console.WriteLine($"Impostos calculados: {CalcularImpostos():C}");
            Console.WriteLine($"Salário final: {CalcularSalario():C}");
            Console.WriteLine(EntregarPagamento());
        }
    }
}
