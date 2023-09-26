using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_RBAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema de gerenciamento de usuarios e controle de acesso");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Digite os dados para cadastro de administrador");
            Console.WriteLine("Digite o nome:");
            String name = Console.ReadLine();
            Console.WriteLine("Insira seu login inicial:");
            String login = Console.ReadLine();
            Console.WriteLine("Insira sua senha inicial");
            String password = Console.ReadLine();
            Admin admin = new Admin(name, login, password);
            int option = 4;
            while (option != 0)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("1 - Cadastrar usuarios\n2 - Remover usuarios\n3 - imprimir lista de usuarios\n0 - Sair");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    admin.createUser();
                }
                if (option == 2)
                {
                    Console.WriteLine("Digite o cpf do Usuario a ser apagado:");
                    String cpf = Console.ReadLine();
                    admin.removeUser(cpf);
                }
                if (option == 3)
                {
                    foreach (User user in admin.Users)
                    {
                        Console.WriteLine("----------------------------------------------------");
                        user.toString();
                    }
                }
                if(option == 0)
                {
                    Console.WriteLine("Saindo...");
                    Console.WriteLine("----------------------------------------------------");
                }
                if (option!=0 && option!=2 && option!=3 && option!=1)
                {
                    Console.WriteLine("Opcao invalida");
                }
            }
        }
    }
}
