using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnLineDeskTop
{
    public class User
    {
        static int countUser = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public User(string name, string email, string password, string address)
        {
            Id = ++countUser;
            Name = name;
            Email = email;
            Password = password;
            Address = address;
        }
    }

    public class Users
    { 
        List<User> listUser = new List<User>();
        public int Count { get { return listUser.Count; } }

        public Users() {
        
        }

        public User GetById(int id)
        {
            foreach (var item in listUser)
            {
                if (item.Id == id) return item;
            }
            return null;
        }

        public User GetByCredentials(string email, string password)
        {
            foreach (var item in listUser)
            {
                if (item.Email == email.Trim().ToLower() && item.Password==password) return item;
            }
            return null;
        }
    }
}
