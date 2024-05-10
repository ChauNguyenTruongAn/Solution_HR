using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LevateManagement.Application.Features.LeaveType.Queries.GetAllLeaveType
{
    public class LeaveTypeDTO
    {
        /*
         Dto
        Request
        Respon
        */
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }
    }
}
