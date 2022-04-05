using RiyasBooks.DataAccess.Repository.IRepository;
using RiyasBooks.Models;
using RiyasBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiyasBooks.DataAccess.Repository
{
    public class CoverTypeRepository  : Repository<CoverType> , ICoverTypeRepository
    {

        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
                 //_db.SaveChanges();
            }
            //throw new NotImplementedException();
        }
    }
}
