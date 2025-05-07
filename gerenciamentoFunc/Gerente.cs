using System;

namespace gerenciamentoFunc
{
    /// <summary>
    /// Representa um funcionário do tipo Gerente.
    /// Herda da classe Funcionario e inclui um bônus adicional no salário.
    /// </summary>
    public class Gerente : Funcionario
    {
        /// <summary>
        /// Valor do bônus adicional que o gerente recebe.
        /// </summary>
        private decimal Bonus { get; set; }

        /// <summary>
        /// Construtor da classe Gerente.
        /// </summary>
        public Gerente(string nome, int idade, string cargo, decimal salario,
            string formaPagamento, string metEntrPag, decimal bonus, decimal impostos)
            : base(nome, idade, cargo, salario, formaPagamento, metEntrPag, impostos)
        {
            Bonus = bonus;
        }

        /// <summary>
        /// Calcula o salário final do gerente incluindo o bônus e descontando os impostos.
        /// </summary>
        public override decimal CalcularSalario()
        {
            return (Salario + Bonus) - CalcularImpostos();
        }

        /// <summary>
        /// Calcula os impostos com base no salário somado ao bônus.
        /// A alíquota aplicada é de 27,5%.
        /// </summary>
        public override decimal CalcularImpostos()
        {
            return (Salario + Bonus) * 0.275m;
        }

        /// <summary>
        /// Informa como o pagamento será entregue.
        /// </summary>
        public override string EntregarPagamento()
        {
            return $"O pagamento será entregue de forma: {MetodoEntregaPagamento}";
        }

        /// <summary>
        /// Exibe as informações do gerente, incluindo bônus, impostos e salário final.
        /// </summary>
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bônus: {Bonus}");
            Console.WriteLine($"Impostos calculados no salário: {CalcularImpostos():C}");
            Console.WriteLine($"Salário Final: {CalcularSalario():C}");
        }
    }
}
