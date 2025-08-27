using System;
using Petshop2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Petshop2


{


    public class Gato : Animal


    {
        public Gato(string nome, int idade) : base(nome, idade) { }


        public override void Atender()

        {

            Console.WriteLine($"Atendendo {nome}! está miando muito!!!");
        }
    }
}
