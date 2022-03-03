using ProductApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces.Repository
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid Id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> HardDeleteAsync(T entity);
    }
}
