using Demo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository
{
    public class UserRepository : Repository<User>
    {
        DataContext context = null;
        public UserRepository(DataContext dataContext) : base(dataContext)
        {
            this.context = dataContext;
        }
    }
}
