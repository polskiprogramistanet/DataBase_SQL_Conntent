using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContentExample.src.Domain.Entities.User;
using DataBaseContentExample.src.Persistance.UsersRepository;
namespace DataBaseContentExample.src.Application
{
    public class User_Builder
    {
        User user;
        UserOperationsBase @base;
        RepositioriumOfUsers repositiorium;
        

       

        public User_Builder()
        {
            this.user = new User();
            repositiorium = new RepositioriumOfUsers();
        }
        public User_Builder SetName(string name)
        {
            this.user.Name = name;
            return this;
        }
        public User_Builder SetAge(int age)
        {
            this.user.Age = age;
            return this;
        }
        public User_Builder Build()
        {
            try
            {
                @base = new AddUser(this.user);
                @base.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User_Builder: {ex.Message}");
            }
            return this;
        }
        public User_Builder Update()
        {
            @base = new UpdateUser(this.user);
            @base.Execute();
            return this;
        }
        public User_Builder Remove()
        {
            @base = new RemoveUser();
            @base.Execute();
            return this;
        }
        public User_Builder RemoveItem(string name)
        {
            @base = new RemoveUser();
            @base.Execute();
            return this;
        }

        

    }
}
