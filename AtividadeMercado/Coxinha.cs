using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace atividade {
    internal class Coxinha : Produto{
        protected String sabor;

        public Coxinha(String sabor, double p) : base("Coxinha",p){
            this.sabor = sabor;
        }
        public override void reajustarPreco(Produto a) {
            preco = preco * 1.15;
        }
        public override void exibirProduto() {
            base.exibirProduto();
            Console.WriteLine($"Sabor: {sabor}\nValor de reajuste: {1.15}");
            Console.WriteLine("***************************");
        }
    }
}
