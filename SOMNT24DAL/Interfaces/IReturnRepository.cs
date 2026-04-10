using SOMNT24DAL.Interfaces;
using SOMNT24DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24DAL.Interfaces
{
    public interface IReturnRepository
    {
        Task<List<ReturnType>> GetAllAsync();
        Task<ReturnType?> GetByIdAsync(string retnType);
        Task AddAsync(ReturnType entity);
        Task UpdateAsync(ReturnType entity);
        Task DeleteAsync(string retnType);
    }
}

