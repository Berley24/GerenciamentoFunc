using System;
using System.Collections.Generic;

namespace gerenciamentoFunc
{
    /// <summary>
    /// Classe principal que executa o sistema de gerenciamento de funcionários.
    /// Permite adicionar, buscar, exibir e remover funcionários do tipo Gerente, Desenvolvedor e Estagiário.
    /// </summary>
    internal class Program
    {
        // Lista global que armazena todos os funcionários cadastrados
        static List<Funcionario> funcionarios = new List<Funcionario>();

        /// <summary>
        /// Método principal que exibe o menu e gerencia as opções do sistema.
        /// </summary>
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Sistema de Gerenciamento de Funcionários ====");
                Console.WriteLine("1 - Adicionar Gerente");
                Console.WriteLine("2 - Adicionar Desenvolvedor");
                Console.WriteLine("3 - Adicionar Estagiário");
                Console.WriteLine("4 - Mostrar todos os funcionários");
                Console.WriteLine("5 - Buscar funcionário por nome");
                Console.WriteLine("6 - Remover funcionário");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": AdicionarGerente(); break;
                    case "2": AdicionarDesenvolvedor(); break;
                    case "3": AdicionarEstagiario(); break;
                    case "4": MostrarFuncionarios(); break;
                    case "5": BuscarFuncionario(); break;
                    case "6": RemoverFuncionario(); break;
                    case "0": return;
                    default: Console.WriteLine("Opção inválida."); break;
                }

                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Coleta os dados de entrada e adiciona um novo gerente à lista.
        /// </summary>
        static void AdicionarGerente()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();
            Console.Write("Salário: ");
            decimal salario = decimal.Parse(Console.ReadLine());
            Console.Write("Forma de pagamento: ");
            string formaPag = Console.ReadLine();
            Console.Write("Método de entrega do pagamento: ");
            string metEntrPag = Console.ReadLine();
            Console.Write("Bônus: ");
            decimal bonus = decimal.Parse(Console.ReadLine());

            var gerente = new Gerente(nome, idade, cargo, salario, formaPag, metEntrPag, bonus, 0);
            funcionarios.Add(gerente);
            Console.WriteLine("Gerente adicionado com sucesso!");
        }

        /// <summary>
        /// Coleta os dados de entrada e adiciona um novo desenvolvedor à lista.
        /// </summary>
        static void AdicionarDesenvolvedor()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();
            Console.Write("Salário: ");
            decimal salario = decimal.Parse(Console.ReadLine());
            Console.Write("Forma de pagamento: ");
            string formaPag = Console.ReadLine();
            Console.Write("Método de entrega do pagamento: ");
            string metEntrPag = Console.ReadLine();
            Console.Write("Horas extras: ");
            int horasExtras = int.Parse(Console.ReadLine());
            Console.Write("Valor por hora extra: ");
            decimal valorPorHora = decimal.Parse(Console.ReadLine());

            var dev = new Desenvolvedor(nome, idade, cargo, salario, formaPag, metEntrPag, horasExtras, valorPorHora, 0);
            funcionarios.Add(dev);
            Console.WriteLine("Desenvolvedor adicionado com sucesso!");
        }

        /// <summary>
        /// Coleta os dados de entrada e adiciona um novo estagiário à lista.
        /// </summary>
        static void AdicionarEstagiario()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();
            Console.Write("Salário: ");
            decimal salario = decimal.Parse(Console.ReadLine());
            Console.Write("Forma de pagamento: ");
            string formaPag = Console.ReadLine();
            Console.Write("Método de entrega do pagamento: ");
            string metEntrPag = Console.ReadLine();

            var est = new Estagiario(nome, idade, cargo, salario, formaPag, metEntrPag, 0);
            funcionarios.Add(est);
            Console.WriteLine("Estagiário adicionado com sucesso!");
        }

        /// <summary>
        /// Exibe todos os funcionários cadastrados.
        /// </summary>
        static void MostrarFuncionarios()
        {
            Console.Clear();
            Console.WriteLine("==== Funcionários Cadastrados ====\n");
            foreach (var f in funcionarios)
            {
                f.DisplayInfo();
                Console.WriteLine("--------------------------");
            }
        }

        /// <summary>
        /// Busca um funcionário pelo nome (ou parte do nome).
        /// </summary>
        static void BuscarFuncionario()
        {
            Console.Write("Digite o nome do funcionário: ");
            string nomeBusca = Console.ReadLine();
            var encontrados = funcionarios.FindAll(f => f.Nome.ToLower().Contains(nomeBusca.ToLower()));

            if (encontrados.Count > 0)
            {
                foreach (var f in encontrados)
                {
                    f.DisplayInfo();
                    Console.WriteLine("--------------------------");
                }
            }
            else
            {
                Console.WriteLine("Nenhum funcionário encontrado com esse nome.");
            }
        }

        /// <summary>
        /// Remove um funcionário com base no nome informado.
        /// </summary>
        static void RemoverFuncionario()
        {
            Console.Write("Digite o nome do funcionário a remover: ");
            string nome = Console.ReadLine();
            var funcionario = funcionarios.Find(f => f.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (funcionario != null)
            {
                funcionarios.Remove(funcionario);
                Console.WriteLine("Funcionário removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }
    }
}





//namespace gerenciamentoFunc
//{
//    internal class Program
//    {
//        static List<Funcionario> funcionarios = new List <Funcionario>();
//        static void Main(string[] args)
//        {

//            Gerente gerente = new ("Jonatan", 29, 
//                "Gerente de projetos na IBM", 10000m, "pix",
//                "automatico", 2000, 0275); 

//            Desenvolvedor dev = new ("Jonatan", 29,
//              "desenvolvedor C# na IBM", 8000m, "Dinheiro", "automatico", 10, 50, 0.1m);

//            Estagiario joao = new ("joao", 34,
//                "Frontend na IBM", 6000m, "pix", "manual", 0m);

//            funcionarios.Add(gerente);
//            funcionarios.Add(dev);
//            funcionarios.Add(joao);
//            foreach (var f in funcionarios)
//            {
//                f.DisplayInfo();
//                Console.WriteLine("--------------------------");

//                Console.ReadLine(); 
//            }
//        }
//    }
//}
