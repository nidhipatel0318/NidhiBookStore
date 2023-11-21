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
   public class CoverTypeRespository:Repository<CoverType>, ICoverTypeRepository
  
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRespository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;

            }
        }
    }
}