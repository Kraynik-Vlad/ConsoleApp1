using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entity
{
    public class User
    {
        private String login;
        private String password;
        private String role;

        public User(string login, string password, string role)
        {
            this.login = login;
            this.password = password;
            this.role = role;
        }

        public String getLogin() {
            return this.login;
        }

        public String getPassword() {
            return this.password;
        }

        public String getRole() {
            return this.role;
        }

        
    }
}
