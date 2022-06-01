using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Entity;

namespace ConsoleApp1.Services
{
    public class UserService
    {
        List<User> users = new List<User>();


        public User createUser(String userName, String password, String role) {
            User user = new User(userName, password, role);
            users.Add(user);
            return user;
        }

        public User findUser(String userName, String password) {
            // todo find User in collection users by userName and password
            // if find - return user
            // if not find - return null

            for (int i = 0; i < users.Count; i++)
            {
                if (userName.Equals(users[i].getLogin()) && password.Equals(users[i].getPassword()))
                {
                    return (users[i]);
                }
            }
            return null;
        }
    }
}
