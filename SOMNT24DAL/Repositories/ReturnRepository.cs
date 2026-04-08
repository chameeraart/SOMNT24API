using Microsoft.EntityFrameworkCore;
using SOMNT24DAL.Data;
using SOMNT24DAL.Interfaces;
using SOMNT24DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24DAL.Repositories
{
    public class ReturnRepository : IReturnRepository
    {
        private readonly AppDbContext _context;

        public ReturnRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ReturnType>> GetAllAsync()
        {
            return await _context.ReturnTypes.ToListAsync();
        }

        public async Task<ReturnType?> GetByIdAsync(string retnType)
        {
            return await _context.ReturnTypes
                .Where(t => t.RecID == Convert.ToInt16(retnType))
                .FirstOrDefaultAsync();
        }
        public async Task AddAsync(ReturnType entity)
        {
            if (entity.CreatedOn == DateTime.MinValue)
            {
                entity.CreatedOn = DateTime.Now;
            }

            if (entity.LastUpdatedOn == DateTime.MinValue)
            {
                entity.LastUpdatedOn = DateTime.Now;
            }
            await _context.ReturnTypes.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ReturnType entity)
        {
            if (entity.CreatedOn == DateTime.MinValue)
            {
                entity.CreatedOn = DateTime.Now;
            }

            if (entity.LastUpdatedOn == DateTime.MinValue)
            {
                entity.LastUpdatedOn = DateTime.Now;
            }
            _context.ReturnTypes.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string retnType)
        {
            var data = await _context.ReturnTypes.FirstOrDefaultAsync(t => t.RecID == Convert.ToInt16(retnType));
            if (data != null)
            {
                _context.ReturnTypes.Remove(data);
                await _context.SaveChangesAsync();
            }
        }
    }
}
