using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

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
    }
}
