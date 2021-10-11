using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Handin1.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    UserName = "Lili",
                    Password = "burnbabyburn"
                },
                new User
                {
                    UserName = "Allie",
                    Password = "studentincubator"
                },
                new User
                {
                    UserName = "Rei",
                    Password = "notcfanclub"
                },
                new User
                {
                    UserName = "Jody",
                    Password = "bladelaserblazor"
                },
                new User
                {
                    UserName = "Jakob",
                    Password = "handin1approved"
                }

            }.ToList();
        }
        
        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}