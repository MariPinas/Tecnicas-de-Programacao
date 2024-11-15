using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace atividade {
    internal class Bolacha : Produto{
        protected String marca;

        public Bolacha(String m, double p) : base("Bolacha",p) {
            this.marca = m;
        }

        public override void reajustarPreco(Produto a) {
            preco = preco * 1.01;
        }
        public String getMarca() {
            return marca;
        }
        public double getPreco() { 
            return preco;
        }

        public override void exibirProduto() {
            base.exibirProduto();
            Console.WriteLine($"Marca: {marca}\nValor de reajuste: {1.01}");
            Console.WriteLine("***************************");
        }
    }
}
