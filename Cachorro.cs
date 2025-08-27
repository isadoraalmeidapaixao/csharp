using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Petshop2


{

    public class Cachorro : Animal

    {

        public Cachorro(string nome, int idade) : base(nome, idade) { }

        public override void Atender()

        {

            Console.WriteLine($"Atendendo {nome}! ele esta latindo demais!!");

        }

    }

}
