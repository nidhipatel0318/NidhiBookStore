using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NidhiBookStore.DataAcess.Data;
using NidhisBooks.DataAccess.Repository.IRepository;
using NidhisBooks.Models.ViewModels;

namespace NidhisBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
            CoverType = new CoverTypeRespository(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }
        public ICoverTypeRepository{ get; private set;}

      //  IRepository.ICategoryRepository IUnitOfWork.Category => throw new NotImplementedException();

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()          // all the changes will be saved when the save method is called at the parent level
        {
            _db.SaveChanges();
        }
    }
}