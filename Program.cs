using System;

namespace primeiroCrud
{
    class Program
    {
        static computadorRepo repo  = new computadorRepo();
        static void Main(string[] args)
        {
            string userOpcao = opcaoUser();

			while (userOpcao.ToUpper() != "X")
			{
				switch (userOpcao)
				{
					case "1":
						ListarPecas();
						break;
					case "2":
						InserirPecas();
						break;
					case "3":
						AtualizarPecas();
						break;
					case "4":
						ExcluirPecas();
						break;
					case "5":
						VisualizarPecas();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				userOpcao = opcaoUser();
			}

			Console.WriteLine("Melhore isso, esta igual o pc da xuxa!!!");
			Console.ReadLine();
        }

        private static void ExcluirPecas()
		{
			Console.Write("Digite o id do computador: ");
			int indicePc= int.Parse(Console.ReadLine());

			repo.exclui(indicePc);
		}

        private static void VisualizarPecas()
		{
			Console.Write("Digite o id do computador: ");
			int indicePc = int.Parse(Console.ReadLine());

			var computador = repo.retornaId(indicePc);

			Console.WriteLine(computador);
		}

        private static void AtualizarPecas()
		{
			Console.Write("Digite o id do computador: ");
			int indicePc = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(equipamentoTipo)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(equipamentoTipo), i));
			}
			Console.Write("Digite o tipo de equipamento entre as opções acima: ");
			int entradaEquipamento = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a marca do equipamento: ");
			string entradaMarca = (Console.ReadLine());

			Console.Write("Digite a descrição do equipamento: ");
			string entradaDescricao = Console.ReadLine();

			Console.Write("Digite o Ano de fabricação: ");
			int entradaAnoFabricacao = int.Parse(Console.ReadLine());

			Console.Write("Digite o peso do equipamento: ");
			double entradaPeso = double.Parse(Console.ReadLine());

			computador atualizaPecas = new computador(id: indicePc,
										equipamento: (equipamentoTipo)entradaEquipamento,
										marca: entradaMarca,
										anoFabricacao: entradaAnoFabricacao,
										descricao: entradaDescricao,
                                        peso: entradaPeso);

			repo.atualiza(indicePc, atualizaPecas);
		}
        private static void ListarPecas()
		{
			Console.WriteLine("Listar Peças");

			var lista = repo.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma peça cadastrada.");
				return;
			}

			foreach (var peca in lista)
			{
                var excluido = peca.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", peca.retornaId(), peca.retornaMarca(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirPecas()
		{
			Console.WriteLine("Inserir novas peças");

				foreach (int i in Enum.GetValues(typeof(equipamentoTipo)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(equipamentoTipo), i));
			}
			Console.Write("Digite o tipo de equipamento entre as opções acima: ");
			int entradaEquipamento = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a marca do equipamento: ");
			string entradaMarca = (Console.ReadLine());

			Console.Write("Digite a descrição do equipamento: ");
			string entradaDescricao = Console.ReadLine();

			Console.Write("Digite o Ano de fabricação: ");
			int entradaAnoFabricacao = int.Parse(Console.ReadLine());

			Console.Write("Digite o peso do equipamento: ");
			double entradaPeso = double.Parse(Console.ReadLine());


			computador novoComputador = new computador(id: repo.proximoId(),
										equipamento: (equipamentoTipo)entradaEquipamento,
										marca: entradaMarca,
										anoFabricacao: entradaAnoFabricacao,
										descricao: entradaDescricao,
                                        peso: entradaPeso);

			repo.insere(novoComputador);
		}

        private static string opcaoUser()
		{
			Console.WriteLine();
			Console.WriteLine("Sonhos geek montando seu pc da Nasa");
			Console.WriteLine("Escolher você deve:");

			Console.WriteLine("1- Listar Computadores");
			Console.WriteLine("2- Inserir novas Peças");
			Console.WriteLine("3- Atualizar Peças");
			Console.WriteLine("4- Excluir Peças");
			Console.WriteLine("5- Visualizar Computadores");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUser = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUser;
		}
    }
}

            
        