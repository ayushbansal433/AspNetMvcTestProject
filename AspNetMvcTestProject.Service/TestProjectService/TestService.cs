using AspNetMvcTestProject.Model.Dto;
using AspNetMvcTestProject.Repository;
using AspNetMvcTestProject.Repository.IRepository;
using AspNetMvcTestProject.Service.ITestProjectService;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcTestProject.Service.TestProjectService
{
    public class TestService : ITestService
    {
        private readonly ITestRepo _repository;
        public TestService(ITestRepo repository)
        {
            _repository = repository;
        }

        public async Task<List<UserDto>> GetAllUsers()
        {
            try
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<User, UserDto>();
                });

                IMapper mapper = config.CreateMapper();
                return mapper.Map<List<UserDto>>(await _repository.GetUsers());
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
