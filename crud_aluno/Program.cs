using crud_aluno;
using System;

class program
{
    public static void Main()
    {
        string op;
        bool ciclo = true;
        int ID = 0;
        string nome = "";
        string cpf = "";
        int idade = 0;

        Console.WriteLine("Bem-vindo ao cadastro de aluno!");

        List<Aluno> alunosCadastrados = new List<Aluno>();

        Aluno aluno = new Aluno(ID, nome, cpf, idade);

        while (ciclo)
        {
            Console.WriteLine("O que deseja fazer a seguir?");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("C - Create");
            Console.WriteLine("R - Read");
            Console.WriteLine("U - Update");
            Console.WriteLine("D - Delete");
            Console.WriteLine("X - Sair");
            Console.WriteLine("-------------------------------");

            try
            {
                op = Console.ReadLine().ToLower();

                switch (op)
                {
                    case "c":
                        aluno.SetAluno();
                        break;
                    case "r":
                        aluno.GetAluno();
                        break;
                    case "u":
                        aluno.UpdateAluno();
                        break;
                    case "d":
                        aluno.DeleteAluno();
                        break;
                    case "x":
                        Console.WriteLine("Aplicação finalizada!");
                        ciclo = false;
                        break;
                    default:
                        aluno.ValidaOpcao();
                        break;
                }
            }
            catch(OptionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}