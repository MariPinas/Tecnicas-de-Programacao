using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade {
    internal class Refrigerante : Produto{
        protected String marca;

        public Refrigerante(String marca, double p) : base("Guarana",p) {
            this.marca = marca;
        }

        public override void reajustarPreco(Produto a) {
            preco = preco * 1.01;
        }
        public override void exibirProduto() {
            base.exibirProduto();
            Console.WriteLine($"Marca: {marca}\nValor de reajuste: {1.01}");
            Console.WriteLine("***************************");
        }
    }
}
