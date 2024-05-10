using HR.leaveManagement.DomainFinnal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LevateManagement.Application.Contracts
{
    public interface ILeaveRequestRepo : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestsWithDetail(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetail();
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails(string id);
    }
}
