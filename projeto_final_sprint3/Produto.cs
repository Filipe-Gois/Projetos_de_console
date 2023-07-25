using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_final_sprint3;

namespace projeto_final_sprint3
{
    public class Produto
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; } = "";
        public string NomeM { get; set; } = "";
        public float Preco { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;
        // n precisa de get e set pq já está instanciando
        public Marca _Marca { get; set; } = new Marca();
        public Usuario user { get; set; } = new Usuario();
        public string CadastradoPor { get; set; }

        public List<Produto> listadeprodutos { get; set; } = new List<Produto>();


        public Produto()
        {

        }
        public Produto(int codigoproduto, string nomeproduto, float preco, string marca)
        {
            CodigoProduto = codigoproduto;
            NomeProduto = nomeproduto;
            Preco = preco;
            NomeM = marca;
            

        }
        public void Cadastrar()
        {

            Console.WriteLine($"Informe o código do produto:");
            CodigoProduto = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe a marca do produto:");
            NomeM = Console.ReadLine()!;

            Console.WriteLine($"Informe o nome do protudo:");
            NomeProduto = Console.ReadLine()!;

            Console.WriteLine($"Informe o preço");
            Preco = int.Parse(Console.ReadLine()!);

            CadastradoPor = user.NomeUsuario;
            Console.WriteLine($"\nProduto cadastrado por {user.NomeUsuario}");
            Console.WriteLine($"{DataCadastro}");

            listadeprodutos.Add(
                new(CodigoProduto, NomeProduto, Preco, NomeM)
            );

            _Marca.ListaDeMarcas.Add(new(NomeM));
        }

        public void Listar()
        {

            if (listadeprodutos.Count == 0)
            {
                Console.WriteLine($"Não há produtos.");
            }


            else
            {
                Console.WriteLine($"Produtos cadastrados:");
                foreach (var item in listadeprodutos)
                {
                    Console.WriteLine(@$"
                Código: {item.CodigoProduto}
                Marca: {item.NomeM}
                Nome: {item.NomeProduto}
                Preço: {item.Preco:C2}");
                }
            }

        }

        public void Deletar()
        {
            if (listadeprodutos.Count == 0)
            {
                Console.WriteLine($"Não há produtos a serem removidos.");
            }

            else
            {
                int codigoproduto = CodigoProduto;

                Console.WriteLine($"Informe o código do produto a ser removido:");
                codigoproduto = int.Parse(Console.ReadLine()!);

                Produto p = listadeprodutos.Find(x => x.CodigoProduto == codigoproduto)!;
                listadeprodutos.Remove(p);

                Console.WriteLine($"\nProduto excluído.");

            }
        }



    }
}