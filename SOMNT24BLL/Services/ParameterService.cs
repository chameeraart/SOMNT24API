using SOMNT24BLL.Interfaces;
using SOMNT24DAL.Interfaces;
using SOMNT24DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24BLL.Services
{
    public class ParameterService : IParameterService
    {
        private readonly IParameterRepository _repository;

        public ParameterService(IParameterRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Parameters>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<List<Parameters>> GetByIdAsync(string businessUnit, int executionType)
        {
            return await _repository.GetByIdAsync(businessUnit, executionType);
        }
    }
}
