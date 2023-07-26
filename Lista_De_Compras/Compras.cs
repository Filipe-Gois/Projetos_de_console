using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lista_De_Compras;

namespace Lista_De_Compras
{
    public class Compras
    {
        public string produto { get; set; }
        public int codigo { get; set; } = 0;
        public int i { get; set; } = 0;
        public Compras p { get; set; }
        public List<Compras> comprasLista = new List<Compras>();

        public Compras()
        {
        }
        public Compras(string Produto, int Codigo)
        {
            produto = Produto;
            codigo = Codigo;
        }
        public void Adicionar()
        {
            Console.WriteLine($"\nInforme o nome do item que deseja adicionar:");
            this.produto = Console.ReadLine()!.ToUpper();

            // Console.WriteLine($"Informe o código do produto:");
            // this.codigo = int.Parse(Console.ReadLine()!);


            // lógica usada para ver se o item informado já existe na lista
            Compras pp = comprasLista.Find(x => x.produto == produto)!;

            // Compras c = comprasLista.Find(x => x.codigo == codigo)!;

            //  || c != null adicionar no if caso queira usar o código do produto
            if (pp != null)
            {
                Console.WriteLine($"\nItem já existe na lista.");
            }
            else
            {
                comprasLista.Add(new Compras(produto, codigo));
                Console.WriteLine($"\nProduto adicionado com sucesso!");
            }
        }

        public void Remover()
        {
            Console.WriteLine($"\nInforme o nome do produto a ser removido:");
            string produtoBuscado = Console.ReadLine()!.ToUpper();

            // caso queira usar o código do produto como parâmetro para remoção:
            // int produtoBuscado = int.Parse(Console.ReadLine()!);
            // p = comprasLista.Find(x => x.codigo == produtoBuscado)!;

            p = comprasLista.Find(x => x.produto == produtoBuscado)!;
            comprasLista.Remove(p);

            Console.WriteLine(p != null ? $"\nO produto {p.produto} foi removido com sucesso!" : $"\nProduto não encontrado.");
        }

        public void Listar()
        {
            if (comprasLista.Count == 0)
            {
                Console.WriteLine($"\nLista vazia.");

            }

            else
            {
                foreach (Compras item in comprasLista)
                {

                    i++;
                    Console.WriteLine($"\n{i}: {item.produto}");
                }
            }

        }
    }
}