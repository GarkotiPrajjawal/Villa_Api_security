using System.Linq.Expressions;
using Villa_Api_security.Models;

namespace Villa_Api_security.Repository.IRepostiory
{
    public interface IVillaRepository : IRepository<VillaOne>
    {
        Task<VillaOne> UpdateAsync(VillaOne entity);
    }
}
