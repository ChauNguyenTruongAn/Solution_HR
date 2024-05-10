using AutoMapper;
using HR.leaveManagement.DomainFinnal;
using HR.LevateManagement.Application.Features.LeaveType.Queries.GetAllLeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LevateManagement.Application.MappingProfile
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDTO, LeaveType>().ReverseMap();
        }
    }
}
