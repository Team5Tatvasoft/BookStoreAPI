using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models.ViewModels;
using BookStore.Models.Models;
namespace BookStore.Repository
{
    public  class UserRepository
    {
        BookStoreContext context = new BookStoreContext();
        
        public List<User> GetUsers()
        {
            return context.Users.ToList();

        }
        public User Login(LoginModel model)
        {
            return context.Users.FirstOrDefault(c => c.Email.Equals(model.Email.ToLower()) && c.Password.Equals(model.Password));
            
        }
        public User addUser(RegisterModel model)
        {
            User user = new User()
            {
                Email = model.Email,
                Password = model.Password,
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Roleid = model.Roleid,
            };
            var entry = context.Users.Add(user);
            context.SaveChanges();
            return entry.Entity;
        }
        
    }
}
