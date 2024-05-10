using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LevateManagement.Application.Features.LeaveType.Queries.GetAllLeaveType
{
    // trả dữ liệu về
    public record LeaveTypeRequest : IRequest<List<LeaveTypeDTO>>
    {

    }
}
