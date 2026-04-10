using Microsoft.EntityFrameworkCore;
using SOMNT24DAL.Data;
using SOMNT24DAL.Interfaces;
using SOMNT24DOMAIN.Enum;
using SOMNT24DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24DAL.Repositories
{
    public class ParameterRepository : IParameterRepository
    {
        private readonly AppDbContext _context;

        public ParameterRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Parameters>> GetAllAsync()
        {
            return await _context.parameters.ToListAsync();
        }

        public async Task<List<Parameters>> GetByIdAsync(string businessUnit, int executionType)
        {
            var group = (ParameterGroup)executionType;

            return await _context.parameters
                .Where(t => t.BusinessUnit == businessUnit && t.ParameterGroup == group.ToString())
                .ToListAsync();
        }
    }
}
