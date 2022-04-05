using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContentExample.src.Domain.Entities.User;

namespace DataBaseContentExample.src.Persistance.UsersRepository
{
    class UpdateUser : UserOperationsBase
    {
       public UpdateUser(User user)
       {
            base.query = $"UPDATE [dbo].[Users] SET [Name] ='{user.Name}',[Age] = {user.Age} where Id = '{user.Id}';";
       }

       public override object Execute()
       {
            return base.Execute();
       }

    }
}
