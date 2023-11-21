﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NidhisBooks.Models.ViewModels;

namespace NidhisBooks.DataAccess.Repository.IRepository
{
   public interface ICoverTypeRepository:IRepository<CoverType>
    {
        void Update(CoverType coverType );
    }
}
