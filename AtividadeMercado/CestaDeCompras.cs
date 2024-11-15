using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace atividade {
     class CestaDeCompras {
        List<Produto> produtosCompra { get; set; } = new List<Produto>();

        public CestaDeCompras() { }

        public bool AddProduto(Produto produto) {
            if (produto == null) return false;
            else {
                produtosCompra.Add(produto);
                return true;
            }
        }

        public void ExibirCesta() {
            Console.WriteLine("===== MINHA CESTA DE COMPRAS =====\n");
            if(produtosCompra.Count == 0)
                Console.WriteLine("\t** Cesta de compras vazia **\n\n");
            else {
                foreach (var i in produtosCompra) {
                    i.exibirProduto();
                    Console.WriteLine();
                }
            }
        }

        public bool reajustarTudo() {
            if (produtosCompra.Count == 0) {
                Console.WriteLine("\n==!== NAO EXISTEM ITENS NA LISTA DE COMPRA ==!==\n");
                return false;
            } else {
                foreach (var i in produtosCompra) {
                    i.reajustarPreco(i);
                }
                return true;
            }
        }

        public void totalCompra() {
            double soma = 0;
            foreach (var i in produtosCompra) {
                double aux = i.getPreco();
                 soma = soma + aux;
            }
            Console.WriteLine($"TOTAL DA COMPRA: {soma}");
        }

    }
}
