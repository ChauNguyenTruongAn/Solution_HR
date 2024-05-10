using HR.leaveManagement.DomainFinnal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LevateManagement.Application.Contracts
{
    public interface ILeaveTypeRepository: IGenericRepository<LeaveType>
    {
        Task<bool> IsLeaveTypeUnique(string name); // kiểm tra tên có trùng hay không
    }
}
