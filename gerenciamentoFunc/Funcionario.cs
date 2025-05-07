namespace gerenciamentoFunc
{
    /// <summary>
    /// Classe abstrata que representa um funcionário genérico.
    /// Fornece propriedades e métodos comuns para todas as subclasses.
    /// </summary>
    public abstract class Funcionario
    {
        // Propriedades comuns dos funcionários
        public string Nome { get; set; }                       // Nome do funcionário
        public int Idade { get; set; }                         // Idade do funcionário
        public string Cargo { get; set; }                      // Cargo ou função
        public decimal Salario { get; set; }                   // Salário base
        public string FormaPagamento { get; set; }             // Forma de pagamento (ex: depósito, cheque)
        public string MetodoEntregaPagamento { get; set; }     // Como o pagamento será entregue (ex: e-mail, correios)
        public decimal Impostos { get; set; }                  // Porcentagem de imposto a ser aplicado

        /// <summary>
        /// Construtor da classe Funcionario.
        /// </summary>
        public Funcionario(string nome, int idade, string cargo, decimal salario,
                           string formaPagamento, string metEntrPag, decimal impostos)
        {
            Nome = nome;
            Idade = idade;
            Cargo = cargo;
            Salario = salario;
            FormaPagamento = formaPagamento;
            MetodoEntregaPagamento = metEntrPag;
            Impostos = impostos;
        }

        /// <summary>
        /// Exibe as informações básicas do funcionário no console.
        /// Pode ser sobrescrito por subclasses se necessário.
        /// </summary>
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Cargo: {Cargo}, Salário Base: {Salario:C}");
            Console.WriteLine($"Forma de pagamento: {FormaPagamento}, Entrega: {MetodoEntregaPagamento}");
        }

        /// <summary>
        /// Método abstrato que deve ser implementado pelas subclasses para calcular o salário final.
        /// </summary>
        public abstract decimal CalcularSalario();

        /// <summary>
        /// Método virtual para calcular o valor dos impostos a serem descontados.
        /// O cálculo padrão aplica a porcentagem definida em `Impostos`.
        /// </summary>
        public virtual decimal CalcularImpostos()
        {
            return Salario * Impostos / 100;
        }

        /// <summary>
        /// Informa como será feita a entrega do pagamento.
        /// </summary>
        public virtual string EntregarPagamento()
        {
            return $"O pagamento será entregue via: {MetodoEntregaPagamento}";
        }
    }
}
