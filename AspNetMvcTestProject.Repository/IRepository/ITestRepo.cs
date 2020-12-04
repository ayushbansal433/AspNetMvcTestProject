using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcTestProject.Repository.IRepository
{
    public interface ITestRepo
    {
        Task<List<User>> GetUsers();
    }
}
