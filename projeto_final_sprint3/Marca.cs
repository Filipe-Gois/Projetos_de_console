using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_final_sprint3;

namespace projeto_final_sprint3
{
    public class Marca
    {
        public int CodigoMarca { get; set; }

        public string NomeMarca { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public Produto produto { get; set; }
        public List<Marca> ListaDeMarcas = new List<Marca>();

        public Marca()
        {

        }
        public Marca(string nomemarca, int codigomarca)
        {
            NomeMarca = nomemarca;
            CodigoMarca = codigomarca;

        }
        public Marca(string nomemarca)
        {
            NomeMarca = nomemarca;
        }

        public void CadastrarMarca()
        {

            Console.WriteLine($"Informe o nome da marca:");
            NomeMarca = Console.ReadLine()!;

            Console.WriteLine($"Informe o código da marca:");
            CodigoMarca = int.Parse(Console.ReadLine()!);

            
            Console.WriteLine(@$"
            Marca cadastrada!
            {DataCadastro}
            ");

            ListaDeMarcas.Add(new(NomeMarca, CodigoMarca));
        }

        public void ListarMarca()
        {
            if (ListaDeMarcas.Count == 0)
            {
                Console.WriteLine($"Não há marcas registradas.");

            }

            else
            {
                    
               
                Console.WriteLine(@$"Marcas cadastradas:");

                foreach (var item in ListaDeMarcas)
                {
                    Console.WriteLine(@$"
                Código da marca: {item.CodigoMarca}
                Nome da marca: {item.NomeMarca}");
                }
            }
        }
        // public void MarcaAdd(string nomeMarca)
        // {
        //     ListaDeMarcas.Add(new(nomeMarca));
        // }

        public void DeletarMarca()
        {
            if (ListaDeMarcas.Count == 0)
            {
                Console.WriteLine($"Não há marcas a serem excluídas.");

            }

            else
            {

                int codigomarca = CodigoMarca;

                Console.WriteLine($"Informe o código da marca a ser removida:");
                codigomarca = int.Parse(Console.ReadLine()!);

                Marca m = ListaDeMarcas.Find(x => x.CodigoMarca == codigomarca)!;
                ListaDeMarcas.Remove(m);

                Console.WriteLine($"\nMarca removida!");
            }
        }
    }
}