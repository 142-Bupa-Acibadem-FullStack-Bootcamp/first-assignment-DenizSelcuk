using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface IGenericService <T ,TDto> where T: IEntityBase where TDto : IDtoBase
    {
        List<TDto> GetAll();
        List<TDto> GetAll(Expression<Func<T, bool>> expression);
        List<TDto> Find(int id);
        IQueryable<T> GetIQueryable();
        TDto Add(TDto item);
        Task<TDto> AddAsync(TDto item);
        TDto Update(TDto item);
        Task<TDto> UpdateAsync(TDto item);
        bool Delete(TDto item);
        bool DeleteById(int id);
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> DeleteAsync(TDto item);

    }
}
