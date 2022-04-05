using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContentExample.src.Domain.Entities.User;

namespace DataBaseContentExample.src.Persistance.UsersRepository
{
    internal class AddUser : UserOperationsBase
    {
        public AddUser(User user)
        {
            base.query = $"IF NOT EXISTS(SELECT * FROM [dbo].[Users] WHERE [Name] = '{user.Name}') BEGIN DECLARE @id varchar(50) = CONVERT(VARCHAR(50), NEWID()); INSERT INTO [dbo].[Users] ([Id], [Name],[Age]) VALUES (@id, '{user.Name}', {user.Age}); SELECT @id; END ELSE BEGIN SELECT [Id] FROM[dbo].[Users] WHERE [Name] = '{user.Name}'; END; ";
        }

        public override object Execute()
        {
            return base.Execute();
        }
    }
}
