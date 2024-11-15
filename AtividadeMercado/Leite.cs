using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade {
    internal class Leite : Produto{
        protected String tipo;

        public Leite(String tipo, double p):base("Leite",p) {
            this.tipo = tipo;
        }

        public override void reajustarPreco(Produto a) {
            preco = preco * 1.005;
        }
        public override void exibirProduto() {
            base.exibirProduto();
            Console.WriteLine($"Tipo: {tipo}\nValor de reajuste: {1.005}");
            Console.WriteLine("***************************");
        }
    }
}
