using RiyasBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiyasBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository: IRepository<Category>
    {
        void Update(Category category);
    }
}
