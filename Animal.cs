using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Petshop2


{

    public abstract class Animal

    {
        public string nome;


        private int idade { get; set; }


        public int novaIdade
        {
            get { return idade; }
            set
            {
                novaIdade = value;
                {
                    if (value >= 0)
                    {
                        Console.WriteLine("Idade inválida.");
                    }
                    else
                    {
                        idade = value;
                    }
                }
            }
        }

        public Animal(string nome, int idade)

        {
            this.nome = nome;


            this.idade = idade;

        }

        public virtual void Atender()
        {
            Console.WriteLine($"Atendendo {nome}");
        }
    }


}
