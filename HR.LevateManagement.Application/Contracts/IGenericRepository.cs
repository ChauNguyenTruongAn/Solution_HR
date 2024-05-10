﻿using HR.leaveManagement.DomainFinnal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LevateManagement.Application.Contracts
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        //dùng chung cho các interface
        Task<IReadOnlyList<T>> GetAllAsync(); //read only
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
