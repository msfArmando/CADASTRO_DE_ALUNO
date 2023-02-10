using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.SymbolStore;

namespace crud_aluno
{
    public class Aluno
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public Aluno(int ID, string nome, string cpf, int idade)
        {
            this.ID = ID;
            Nome = nome;
            CPF = cpf;
            Idade = idade;
        }

        List<Aluno> alunosCadastrados = new List<Aluno>();

        public void SetAluno()
        {
            Console.WriteLine("Iniciando cadastro de aluno...");
            Console.WriteLine("Qual o nome do aluno? ");
            Nome = Console.ReadLine();
            ValidaNome(Nome);

            Console.WriteLine("Quantos anos o aluno tem? ");
            Idade = int.Parse(Console.ReadLine());
            ValidaIdade(Idade);

            Console.WriteLine("Digite o CPF do aluno(APENAS NÚMEROS): ");
            CPF = Console.ReadLine();
            if (ValidacaoCPF(CPF))
            {
                Aluno aluno = new Aluno(ID, Nome, CPF, Idade);
                alunosCadastrados.Add(aluno);
                Console.WriteLine("Aluno criado! ID -> " + aluno.ID);
                ID++;
            }
            else
            {
                Console.WriteLine("Não será possível concluir o cadastro.");
            }
        }

        public void GetAluno()
        {
            Console.WriteLine("Digite o ID do aluno que deseja EXIBIR as informações: ");
            int idsearch = int.Parse(Console.ReadLine());
            bool aviso = true;

            foreach (Aluno aluno in alunosCadastrados)
            {
                if (aluno.ID == idsearch)
                {
                    Console.WriteLine("Nome: " + aluno.Nome);
                    Console.WriteLine("CPF: " + aluno.CPF);
                    Console.WriteLine("Idade: " + aluno.Idade);
                    aviso = false;
                }
                else
                {
                    Console.WriteLine("Loading...");
                }
            }
            if (aviso)
            {
                Console.WriteLine("Aluno não encontrado!");
            }
        }

        public void DeleteAluno()
        {
            Console.WriteLine("Digite o ID do aluno que deseja DELETAR as infomações: ");
            int deletesearch = int.Parse(Console.ReadLine());
            int verificacao;
            bool aviso = true;

            foreach (Aluno aluno in alunosCadastrados)
            {
                if (aluno.ID == deletesearch)
                {
                    Console.WriteLine("Tem certeza que deseja DELETAR o aluno selecionado?\n Digite 1 para sim e 0 para não. ");
                    verificacao = int.Parse(Console.ReadLine());
                    if (verificacao == 1)
                    {
                        alunosCadastrados.Remove(aluno);
                        Console.WriteLine("Aluno removido com sucesso!");
                        aviso = false;
                        break;
                    }
                }
            }

            if (aviso)
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }
        
        public void UpdateAluno()
        {
            Console.WriteLine("Digite o ID do aluno que deseja EDITAR as informações: ");
            int editsearch = int.Parse(Console.ReadLine());

            foreach (Aluno aluno in alunosCadastrados)
            {
                if (aluno.ID == editsearch)
                {
                    Console.WriteLine("Digite o novo Nome: ");
                    string newname = Console.ReadLine();
                    ValidaNome(newname);

                    Console.WriteLine("Digite o novo CPF: ");
                    string newcpf = Console.ReadLine();
                    if (ValidacaoCPF(newcpf))
                    {
                        aluno.CPF = newcpf;
                    }
                    else
                    {
                        Console.WriteLine("Não será possível concluir o cadastro.");
                        break;
                    }

                    Console.WriteLine("Digite a nova Idade: ");
                    int newidade = int.Parse(Console.ReadLine());
                    ValidaIdade(newidade);

                    aluno.Nome = newname;
                    aluno.Idade = newidade;

                    Console.WriteLine("Aluno atualizado!");
                }
                else
                {
                    Console.WriteLine("Loading...");
                }
            }
        }

        public static bool ValidacaoCPF(string cpf)
        {
            if(cpf.Length == 11)
            {
                return true;
            }
            return false;
        }

        public void ValidaOpcao()
        {
            throw new OptionException("OPÇÃO INVÁLIDA!");
        }

        public void ValidaNome(string nome)
        {
            bool validanome = nome.All(char.IsDigit);
            if (validanome)
            {
                throw new OptionException("OPÇÃO INVÁLIDA!");
            }
        }

        public void ValidaIdade(int idade)
        {
            if(idade >= 18)
            {
                throw new FormatException("IDADE INVÁLIDA!");
            }
        }
    }
}
