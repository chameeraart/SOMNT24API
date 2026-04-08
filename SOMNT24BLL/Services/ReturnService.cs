using SOMNT24BLL.Interfaces;
using SOMNT24DAL.Interfaces;
using SOMNT24DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24BLL.Services
{
    public class ReturnService : IReturnService
    {
        private readonly IReturnRepository _repository;

        public ReturnService(IReturnRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ReturnType>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ReturnType?> GetByIdAsync(string retnType)
        {
            return await _repository.GetByIdAsync(retnType);
        }

        public async Task CreateAsync(ReturnType entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(ReturnType entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(string retnType)
        {
            await _repository.DeleteAsync(retnType);
        }
    }
}
