using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace ProjetosEstudoCSharp.Models
{
    public class Pessoa
    {
        //Eu posso ter duas classes com o mesmo nome mas o namespace tem que ser diferente
        // escreve prop, de um tab e ele cria a base de uma nova propriedade
        public string Nome { get; set; }
        public int    Idade { get; set; }

        public void Aprensentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho idade {Idade} anos.");
        }
    }
}