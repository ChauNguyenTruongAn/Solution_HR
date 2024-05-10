using AutoMapper;
using HR.LevateManagement.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HR.LevateManagement.Application.Features.LeaveType.Queries.GetAllLeaveType
{
    public class LeaveTypeRequestHandle : IRequestHandler<LeaveTypeRequest, List<LeaveTypeDTO>>
    {
            private readonly ILeaveAllocationRepository _leaveType;
            private readonly IMapper _mapper;

            public LeaveTypeRequestHandle(ILeaveAllocationRepository leaveType, IMapper mapper) {

                _leaveType = leaveType;
                _mapper = mapper;
            }
        public async Task<List<LeaveTypeDTO>> Handle(LeaveTypeRequest request, CancellationToken cancellationToken)
        {
            //read data from database
            var leaveType = await _leaveType.GetAllAsync();
            //map to DTO
            var data = _mapper.Map<List<LeaveTypeDTO>>(leaveType);
            //return database
            return data;

        }
    }
}
