using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade {
    abstract class Produto {
        protected String nome;
        protected double preco;

        protected Produto(string nome, double preco) {
            this.nome = nome;
            this.preco = preco;
        }

        public abstract void reajustarPreco(Produto a);  

        public double getPreco() {
            return preco;
        }

        public virtual void exibirProduto() {
            Console.WriteLine();
            Console.WriteLine("***************************");
            Console.WriteLine($"Nome: {nome}\nPreço: {preco}");
        }

    }
}
