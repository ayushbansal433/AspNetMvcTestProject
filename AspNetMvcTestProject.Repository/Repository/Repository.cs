using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcTestProject.Repository.Repository
{
    public class Repository
    {
        public async Task<List<User>> GetUsers()
        {
            using(var _userContext= new TestProjectEntities())
            {
                return await _userContext.Users.ToListAsync();
            }
        }
    }
}
