using AspNetMvcTestProject.Model.Dto;
using AspNetMvcTestProject.Repository;
using AspNetMvcTestProject.Repository.IRepository;
using AspNetMvcTestProject.Service.ITestProjectService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcTestProject.Service.TestProjectService
{
    public class TestService : ITestService
    {
        private readonly IRepository _repository;
        public TestService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<UserDto>> GetAllUsers()
        {
            return (await _repository.GetUsers()).Select(x => new List<UserDto>().Select(y =>
            {
                y.Age = x.Age;
                y.Id = x.Id;
                y.Email = x.Email;
                y.Interests = x.Interests;
                y.Name = x.Name;
            })
            );
        }
    }
}
