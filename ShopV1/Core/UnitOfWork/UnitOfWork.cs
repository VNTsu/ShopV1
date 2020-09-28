using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ShopV1.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Database Context
        /// </summary>
        public DbContext DbContext { get; }

        #region Ctor

        public UnitOfWork(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        #endregion

        #region Method

        /// <summary>
        /// Sync Save Change
        /// </summary>
        /// <returns></returns>
        public int SaveChange()
        {
            var result = DbContext.SaveChanges();
            return result;
        }

        /// <summary>
        /// Asyn  Save Change
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveChangeAsync()
        {
            var result = await DbContext.SaveChangesAsync();
            return result;
        }

        #endregion
    }
}
