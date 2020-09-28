using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopV1.Core.UnitOfWork
{
    /// <summary>
    /// IUnitOfWork
    /// </summary>
    public interface IUnitOfWork
    {
        int SaveChange();

        /// <summary>
        /// Async SaveChange
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangeAsync();
    }
}
