using Microsoft.EntityFrameworkCore;
using OrgChart.Data.Repository.EF;

namespace OrgChart.Data
{
    /// <summary>
    /// PtUnitOfWork class is a unit of work for manipulating about utility data in database via repository.
    /// </summary>
    public class OcUnitOfWork : EfUnitOfWork<DSDBContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcUnitOfWork" /> class.
        /// </summary>
        /// <param name="dsDbContext">The Digital Signature database context what inherits from DbContext of EF.</param>
        public OcUnitOfWork(DSDBContext dsDbContext) : base(dsDbContext)
        { }
    }
}
