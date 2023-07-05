using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Villa_Api_security.Models;
using Villa_Api_security.Models.Dto;
using Villa_Api_security.Repository.IRepostiory;

namespace Villa_Api_security.Repository
{
    public class VillaRepository : Repository<VillaOne>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        /*public async Task CreateAsync(VillaOne entity)
        {
            await _db.Villas.AddAsync(entity);
            await SaveAsync();
        }

        public async Task<VillaOne> GetAsync(Expression<Func<VillaOne, bool>> filter = null, bool tracked = true)
        {
            IQueryable<VillaOne> query = _db.Villas;
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<VillaOne>> GetAllAsync(Expression<Func<VillaOne, bool>> filter = null)
        {
            IQueryable<VillaOne> query = _db.Villas;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }

        public async Task RemoveAsync(VillaOne entity)
        {
            _db.Villas.Remove(entity);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }*/
        public async Task<VillaOne> UpdateAsync(VillaOne entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
