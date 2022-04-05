using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContentExample.src.Persistance.UsersRepository
{
    internal abstract class UserOperationsBase
    {
        protected string query = "";

        public virtual object Execute()
        {
            return DataService.GetDataSQLScalar(this.query);
        }
    }
}
