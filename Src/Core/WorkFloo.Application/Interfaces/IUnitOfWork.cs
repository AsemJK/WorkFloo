using System.Threading.Tasks;

namespace WorkFloo.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
