using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aula05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("******************\nAula 05 - Arrays\n******************\n");
			//declarando um vetor com 5 elementos inteiros
			int[] numero = new int[5];
			int i, soma = 0;

			string[] alunos = { "Anderson", "William", "Roberto", "Pedro", "Matheus", "Gabriela", "Joao", "Rafael" ,"Gabriela"};

			for(i=0; i < alunos.Length; i++)
			{
				Console.WriteLine(alunos[i]);
			}
			Console.WriteLine("\nAplicando o Reverse");
			Array.Reverse(alunos);
			for (i = 0; i < alunos.Length; i++)
			{
				Console.WriteLine(alunos[i]);
			}

			Console.WriteLine("\nAplicando o Sort => Ordena um array");
			Array.Sort(alunos);
			for (i = 0; i < alunos.Length; i++)
			{
				Console.WriteLine(alunos[i]);
			}

			int indice = Array.IndexOf(alunos, "Gabriela");
			Console.WriteLine(indice);

			/*			for (i = 0; i < numero.Length; i++)
						{
							Console.WriteLine("Digite o número: " + (i + 1));
							numero[i] = Convert.ToInt32(Console.ReadLine());
						}
						//numero[0] = 9
						for (i = 0; i < numero.Length; i++)
						{
							Console.WriteLine("numero[{0}] = {1}", i.ToString(), numero[i].ToString());
						}
						for (i = 0; i < numero.Length; i++)
						{
							soma += numero[i];
						}
						Console.WriteLine("Soma = " + soma);
						//Criação de vetores
						string[] nomes = new string[3] { "Eliane", "Jose", "Ana" };
						string[] nomesAlunos = new string[] { "Eliane", "Jose", "Ana" };
						int[] idades = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
						string[] produtos = { "mouse", "teclado", "fone" };
						/*Leia 15 elementos para um vetor A. Crie o vetor B, de mesma dimensão, contendo os elementos do vetor A em ordem inversa.*/
			/*	int[] vetA = new int[6];
				int[] vetB = new int[6];
				int[] vetC = new int[6];
				for (i = 0; i < vetA.Length; i++)
				{
					Console.WriteLine("Digite o número: " + (i + 1) + " para vetor A: ");
					vetA[i] = Convert.ToInt32(Console.ReadLine());
				}
				int x = vetA.Length - 1; //x =5
				for (i = 0; i < vetA.Length; i++)
				{
					//preenche o vetor B do início para o fim
					vetB[i] = vetA[x];
					x--;

					//preenche o vetor C do fim para o inicio
					vetC[5 - i] = vetA[i];
				}
				for (i = 0; i < vetA.Length; i++)
				{
					Console.WriteLine("Vetor A: " + vetA[i] + "\tVetor B: " + vetB[i]);
				}
			*/

			//*Leia as notas de 10 alunos e armazene em um vetor. Exiba a média desta turma de alunos.
			/*double[] notas = new double[10];
			double somaNotas = 0, media;
			for(i=0; i<notas.Length; i++)
			{
				Console.WriteLine("Digite a nota do " + (i + 1) + " aluno: ");
				notas[i] = Convert.ToDouble(Console.ReadLine());
				somaNotas += notas[i];
			}
			media = somaNotas / notas.Length;
			Console.WriteLine("A média desta turma é: {0}", media.ToString("0.0"));*/

		}
	}
}