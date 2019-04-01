using System;
using System.Collections.Generic;
using System.Text;

namespace OrgChart.Data.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TPocoEntity> GetRepository<TPocoEntity>() where TPocoEntity : class;
        int Complete();
    }
}
