using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NidhisBooks.DataAccess.Repository.IRepository;
using NidhiBookStore.DataAcess.Data;

namespace NidhisBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        
        ISP_Call SP_Call { get; }

        void Save();
    }
}
