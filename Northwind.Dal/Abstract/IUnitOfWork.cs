using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        // repository eklenecek
        bool BeginTransaction();
        bool RoolBackTransaction();
        int SaveChanges();
    }
}
