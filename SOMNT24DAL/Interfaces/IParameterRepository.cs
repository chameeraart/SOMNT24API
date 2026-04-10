using SOMNT24DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24DAL.Interfaces
{
    public interface IParameterRepository
    {
        Task<List<Parameters>> GetAllAsync();
        Task<List<Parameters>> GetByIdAsync(string businessUnit, int executionType);
    }
}
