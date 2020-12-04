using Demo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Facade
{
    public class UserFacade : Facade<Entity.User>
    {
        UserRepository userRepository = null;
        public UserFacade(DataContext dataContext) : base(dataContext)
        {
            userRepository = new UserRepository(dataContext);
        }
    }
}
