using ConsumindoApi.Entities;
using ConsumindoApi.Entities.Services;

namespace ConsumindoApi
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Informe a Data: ");
            int id = int.Parse(Console.ReadLine());

            AlunosServices alunosServices = new AlunosServices();

            Aluno alunoEncontrado = await alunosServices.Integracao(id);

            if (!alunoEncontrado.Verificacao)
            {
                Console.WriteLine("Aluno Encontrado");

                Console.WriteLine("Nome: " + alunoEncontrado.Nome);
                Console.WriteLine("Matricula: " + alunoEncontrado.Matricula);
                Console.WriteLine("Situacao: " + alunoEncontrado.Situacao);
            }
            else
            {
                Console.WriteLine("Aluno não encontrado");
            }

        }
    }
}