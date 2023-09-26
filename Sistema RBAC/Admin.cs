using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_RBAC
{

    internal class Admin
    {
        public List<User> Users { get; set; }
        public String name { get; set; }
        public String login { get; set; }
        public Role role { get; set; }
        
        public String password;

        public Admin(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
            User us = new User();
            Users.Add(us);
        }

        public Admin()  {

        }
        public void createUser()
        {
            Console.WriteLine("Digite o nome do usuario:");
            String name=Console.ReadLine();
            Console.WriteLine("Digite o login do usuario:");
            String login = Console.ReadLine();
            Console.WriteLine("Digite o CPF do usuario:");
            String cpf =Console.ReadLine();
            Console.WriteLine("Digite o tipo do usuario:");
            Console.WriteLine(" 1 - Usuario\n 2 - Administrador limitado\n 3 - Administrador");
            int type = int.Parse(Console.ReadLine());
            Role role = new Role();
            if(type == 1) { role.HasFlag(Role.Administrator); }
            if (type == 2) { role.HasFlag(Role.LimitedAdministrator); }
            if (type == 3) { role.HasFlag(Role.Administrator); }
            Console.WriteLine("Digite a senha de sistema:");
            String password = Console.ReadLine();
            User user = new User(name,cpf, login, password, role);
            Console.Write(user.toString());
            Users.Add(user);
        }

        public void insertUser(User user) 
        {
            this.Users.Add(user);
        }

        public void removeUser(String key)
        {
            
            foreach(User user in this.Users)
            {
                if (user.cpf == key)
                {
                    Users.Remove(user);
                    Console.WriteLine("Registro removido");
                }
                else
                {
                    Console.WriteLine("0 registros removidos");
                }
            }
        }

        public void printList()
        {
            foreach (User user in this.Users)
            {
                Console.WriteLine(user.toString());
            }
        }
    }
}
