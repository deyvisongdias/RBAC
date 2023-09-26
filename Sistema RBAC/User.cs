using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_RBAC
{
    public enum Role
    {
        User = 1,
        LimitedAdministrator = 2,
        Administrator = 3,
    }
    internal class User
    {
        public String name { get; set; }
        public String cpf { get; set; }
        public String login { get; set; }
        public String pass { get; set; }
        public Role role { get; set; }

        public User(String name, String cpf,String login,String pass, Role role)
        {
            this.name = name;
            this.cpf = cpf;
            this.login = login;
            this.pass = pass;
            this.role = role;
        }

        public User(){

        }

        public String toString()
        {

            return "Name: " + this.name + "\n" +
                    "CPF: " + this.name + "\n" +
                    "user Type: " + this.role.ToString() + "\n" +
                    "Login: " + this.login;              
        }

    }
}
