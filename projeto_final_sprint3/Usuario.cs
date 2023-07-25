using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_final_sprint3;

namespace projeto_final_sprint3
{
    public class Usuario
    {
        public int CodigoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public string opcao { get; set; }
        


        public Usuario()
        {

        }
        

        public void MenuUsuario()
        {
            do
            {
                Console.WriteLine(@$"Olá, informe a opção desejada:
        
        [1] - Cadastrar nova conta
        [2] - Logar em uma conta já existente");

                opcao = Console.ReadLine()!;
            } while (opcao != "1" || opcao != "2");

            switch (opcao)
            {
                case "1":
                    Cadastrar();
                    break;

                case "2":

                    break;
                default:
                    Console.WriteLine($"Opção inválida.");

                    break;
            }
        }
        public void Cadastrar()
        {
            Console.WriteLine($"Informe o código do usuário:");
            this.CodigoUsuario = int.Parse(Console.ReadLine()!);
            
            Console.WriteLine($"Informe seu nome:");
            this.NomeUsuario = Console.ReadLine()!;

            Console.WriteLine($"Informe seu E-mail:");
            this.Email = Console.ReadLine()!;

            Console.WriteLine($"Informe uma senha:");
            this.Senha = Console.ReadLine()!;

            Console.WriteLine($"Usuário cadastrado!");

            this.DataCadastro = DateTime.Now;
            Console.WriteLine($"{DataCadastro}");

            

        }

        public void Deletar()
        {
            this.NomeUsuario = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }




    }
}