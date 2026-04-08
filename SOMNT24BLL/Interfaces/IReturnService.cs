using SOMNT24DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24BLL.Interfaces
{
    public interface IReturnService
    {
        Task<List<ReturnType>> GetAllAsync();
        Task<ReturnType?> GetByIdAsync(string retnType);
        Task CreateAsync(ReturnType entity);
        Task UpdateAsync(ReturnType entity);
        Task DeleteAsync(string retnType);
    }
}
