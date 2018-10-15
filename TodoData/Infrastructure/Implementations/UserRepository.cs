using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TodoData
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(TodoContext context) 
            : base(context)
        {
        }

        public override void Add(User user)
        {

        }
    }
}