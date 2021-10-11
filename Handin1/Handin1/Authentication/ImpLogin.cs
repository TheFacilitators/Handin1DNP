using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Handin1.Authentication {
    public class ImpLogin : ILogin {
        private List<User> users;

        public ImpLogin() {
            users = new List<User>();
            
            users.Add(new User {Username = "Strawberry", Password = "123456", SecurityLevel = 3});
            users.Add(new User {Username = "Blueberry", Password = "123abc", SecurityLevel = 2});
            users.Add(new User {Username = "Cranberry", Password = "abc123", SecurityLevel = 5});
        }
        
        public User Validate(string username, string password) {
            User u = users.First(tem => tem.Username.Equals(username));
            if (u == null) {
                throw new Exception("There is no such user");
            }

            if (!u.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return u;
        }
    }
}