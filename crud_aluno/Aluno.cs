using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace crud_aluno
{
    public class Aluno
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; }
        public int Idade { get; set; }
        public Aluno(int ID, string nome, long cpf, int idade)
        {
            this.ID = ID;
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Console.WriteLine("Aluno criado!");
        }

        List<Aluno> alunosCadastrados = new List<Aluno>();

        public void SetAluno()
        {
            Console.WriteLine("Iniciando cadastro de aluno...");
            Console.WriteLine("Qual o nome do aluno? ");
            Nome = Console.ReadLine();

            Console.WriteLine("Quantos anos o aluno tem? ");
            Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o CPF do aluno(APENAS NÚMEROS): ");
            CPF = long.Parse(Console.ReadLine());
            ID++;

            Aluno aluno = new Aluno(ID, Nome, CPF, Idade);

            alunosCadastrados.Add(aluno);
        }

        public void GetAluno()
        {
            Console.WriteLine("Digite o ID do aluno que deseja EXIBIR as informações: ");
            int idsearch = int.Parse(Console.ReadLine());

            foreach (Aluno Aluno in alunosCadastrados)
            {
                if (Aluno.ID == idsearch)
                {
                    Console.WriteLine("Nome: " + Aluno.Nome);
                    Console.WriteLine("CPF: " + Aluno.CPF);
                    Console.WriteLine("Idade: " + Aluno.Idade);
                }
                else
                {
                    Console.WriteLine("Loading...");
                }
            }
        }
    }
}
