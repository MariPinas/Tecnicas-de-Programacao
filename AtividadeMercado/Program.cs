using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace atividade {
    internal class Program {
        static void Main(string[] args) {
            Produto bolacha = new Bolacha("Bauducco", 4);
            Produto coxinha = new Coxinha("Frango", 4);
            Produto leite = new Leite("Integral", 6);
            Produto queijo = new Queijo("Mussarela", 10);
            Produto refrigerante = new Refrigerante("Guarana Antartica", 5);

            List<Produto> produtosDispo = new List<Produto>() {
                bolacha, coxinha, leite, queijo, refrigerante
            };
          
            CestaDeCompras minhaCesta = new CestaDeCompras();
            string op;
            do {
                Console.WriteLine("===== Menu =====");
                Console.WriteLine("[1] - Adicionar produtos na cesta");
                Console.WriteLine("[2] - Reajustar o preco de todos produtos");
                Console.WriteLine("[3] - Exibir cesta de produtos");
                Console.WriteLine("[4] - Exibir total da compra");
                Console.WriteLine("[5] - Sair");
                op = Console.ReadLine();
                Console.Clear();
                switch (op) {
                    case "1":
                        Console.WriteLine("=== Exibindo Todos os Produtos ===");
                        foreach (var produto in produtosDispo) {
                            produto.exibirProduto();
                        }
                        Console.WriteLine("Escolha um produto: 1. Bolacha 2.Coxinha 3.Leite 4. Queijo 5.Refrigerante 6.Sair");
                        string escolha = Console.ReadLine();
                        switch (escolha) {
                            case "1":
                                bool a = minhaCesta.AddProduto(bolacha);
                                if (a) Console.WriteLine("\n==== Produto adicionado com sucesso ====\n");
                                else Console.WriteLine($"Nao foi possivel adicionar esse produto: {bolacha}");
                                break;
                            case "2":
                                bool b = minhaCesta.AddProduto(coxinha);
                                if (b) Console.WriteLine("\n==== Produto adicionado com sucesso ====\n");
                                else Console.WriteLine($"Nao foi possivel adicionar esse produto: {coxinha}");
                                break;
                            case "3":
                                bool c = minhaCesta.AddProduto(leite);
                                if (c) Console.WriteLine("\n==== Produto adicionado com sucesso ====\n");
                                else Console.WriteLine($"Nao foi possivel adicionar esse produto: {leite}");
                                break;
                            case "4":
                                bool d = minhaCesta.AddProduto(queijo);
                                if (d) Console.WriteLine("\n==== Produto adicionado com sucesso ====\n");
                                else Console.WriteLine($"Nao foi possivel adicionar esse produto: {queijo}");
                                break;
                            case "5":
                                bool e = minhaCesta.AddProduto(refrigerante);
                                if (e) Console.WriteLine("\n==== Produto adicionado com sucesso ====\n");
                                else Console.WriteLine($"Nao foi possivel adicionar esse produto: {refrigerante}");
                                break;
                            case "6":
                                break;
                        }
                        break;
                    case "2":
                        bool teste = minhaCesta.reajustarTudo();
                        if (teste) {
                            Console.WriteLine("\n====Produtos reajustados com sucesso====\n");
                            minhaCesta.ExibirCesta();
                        } else {
                            Console.WriteLine("\n==!== Houve um erro ao ajustar os produtos ==!==\n");
                        }
                        break;
                    case "3":
                        minhaCesta.ExibirCesta();
                        break;
                    case "4":
                        minhaCesta.totalCompra();
                        break;
                    case "5":
                        Console.WriteLine("Saindo do programa...");
                       
                        break;
                    default:
                        Console.WriteLine("OPCAO INVALIDA");
                        break;
                }
            } while (op != "5");
            }
    }
}
