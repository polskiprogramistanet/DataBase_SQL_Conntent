using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContentExample.src.Application;
using DataBaseContentExample.src.Domain.Entities.User;
using DataBaseContentExample.src.Persistance.UsersRepository;


namespace DataBaseContentExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                

                User_Builder builder = new User_Builder();
                builder.Remove();

                builder.SetName("Rafal").SetAge(40).Build();
                builder.SetName("Stefan").SetAge(25).Build();
                builder.SetName("Mariola").SetAge(19).Build();

                Show_Data();

                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }

        static void Show_Data()
        {
            RepositioriumOfUsers repositiorium = new RepositioriumOfUsers();

            List<User> list = repositiorium.GetItems();

            foreach (var item in list)
            {
                Console.WriteLine($"User name={item.Name} age={item.Age}");
            }
        }
    }
}
