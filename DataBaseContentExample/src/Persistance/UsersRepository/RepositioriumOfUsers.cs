using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContentExample.src.Domain.Entities.User;


namespace DataBaseContentExample.src.Persistance.UsersRepository
{
    class RepositioriumOfUsers : IDataBase
    {
        List<User> items;

        public RepositioriumOfUsers()
        {
            string query = "SELECT [Id],[Name],[Age] FROM [dbo].[Users]";
            DataService.SetQuery(query, this);

        }
        object IDataBase.DbReader(IDataReader rd)
        {
            try
            {
                items = new List<User>();
                while (rd.Read())
                {
                    User item = new User();

                    item.Id = rd.GetGuid(0);
                    item.Name = rd.GetString(1);
                    item.Age = rd.GetInt32(2);

                    this.items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"RepositioriumOfUsers: {ex.Message}");
            }
            return items;
        }

        public List<User> GetItems()
        {
            return this.items;
        }
        public List<User> GetItems(int age)
        {
            return this.items.FindAll(x => x.Age == age);

        }
        public User GetItem(Guid id)
        {
            return this.items.Find(x => x.Id == id);
        }
        public User GetItem(string name)
        {
            return this.items.Find(x => x.Name.Equals(name));
        }

    }
}
