using System;
using System.Collections.Generic;
using System.Text;

namespace RiyasBooks.DataAccess.Repository.IRepository
{
    interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call Sp_Call { get; }
    }
}
