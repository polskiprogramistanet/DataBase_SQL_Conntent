using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContentExample.src.Persistance.UsersRepository
{
    internal class RemoveUser : UserOperationsBase
    {
        public RemoveUser(Guid id)
        {
            base.query = $"DELETE FROM [dbo].[Users] WHERE Id = '{id}'";
        }
        public RemoveUser(string name)
        {
            base.query = $"DELETE FROM [dbo].[Users] WHERE [Name] = '{name}'";
        }
        public RemoveUser()
        {
            base.query = $"DELETE FROM [dbo].[Users];";
        }
        public override object Execute()
        {
            return base.Execute();  
        }
    }
}
