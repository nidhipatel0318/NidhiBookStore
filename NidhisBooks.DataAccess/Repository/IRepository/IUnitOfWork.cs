using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NidhisBooks.DataAccess.Repository.IRepository
{
  public interface IUnitOfWork: IDisposable
    {
        ICategoryrRepository Catgory { get; }
        ISP_Call SP_Call { get; }
    }
}
