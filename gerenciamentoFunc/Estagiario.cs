using System;

namespace gerenciamentoFunc
{
    /// <summary>
    /// Representa um funcionário do tipo Estagiário.
    /// Herda da classe Funcionario e redefine o cálculo de salário e impostos.
    /// </summary>
    internal class Estagiario : Funcionario
    {
        /// <summary>
        /// Construtor da classe Estagiario.
        /// </summary>
        public Estagiario(string nome, int idade, string cargo,
            decimal salario, string formaPagamento, string metEntrPag,
            decimal impostos)
            : base(nome, idade, cargo, salario, formaPagamento, metEntrPag, impostos)
        { }

        /// <summary>
        /// Calcula o salário do estagiário.
        /// Não há acréscimos ou descontos — retorna o salário base.
        /// </summary>
        public override decimal CalcularSalario()
        {
            return Salario;
        }

        /// <summary>
        /// Estagiários são isentos de impostos neste sistema.
        /// </summary>
        public override decimal CalcularImpostos()
        {
            Impostos = 0;
            return Impostos;
        }

        /// <summary>
        /// Informa como o pagamento será entregue.
        /// </summary>
        public override string EntregarPagamento()
        {
            return $"O pagamento será entregue de forma: {MetodoEntregaPagamento}";
        }

        /// <summary>
        /// Exibe as informações do estagiário, incluindo salário final e impostos.
        /// </summary>
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Impostos: {CalcularImpostos():C}");
            Console.WriteLine($"Salário Final: {CalcularSalario():C}");
        }
    }
}
