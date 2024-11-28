using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade {
    internal class Queijo : Produto{
        protected String tipo;

        public Queijo(String tipo, double p) : base("Coalho",p) {
            this.tipo = tipo;
        }

        public override void reajustarPreco(Produto a) {
            preco = preco * 1.02;
        }
        public override void exibirProduto() {
            base.exibirProduto();
            Console.WriteLine($"Tipo: {tipo}\nValor de reajuste: {1.02}");
            Console.WriteLine("***************************"); 
        }
    }
}
