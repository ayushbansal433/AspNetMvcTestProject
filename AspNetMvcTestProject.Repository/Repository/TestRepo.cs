using AspNetMvcTestProject.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AspNetMvcTestProject.Repository.Repository
{
    public class TestRepo : ITestRepo
    {
        public async Task<List<User>> GetUsers()
        {
            try
            {
                using (var _userContext = new TestProjectEntities())
                {
                    return await _userContext.Users.ToListAsync();
                }
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }
    }
}
