using AspNetMvcTestProject.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcTestProject.Service.ITestProjectService
{
    public interface ITestService
    {
        Task<List<UserDto>> GetAllUsers();
    }
}
