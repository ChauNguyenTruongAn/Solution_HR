using HR.leaveManagement.DomainFinnal.Common;

namespace HR.leaveManagement.DomainFinnal
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }
        public LeaveType LeaveType { get; set; }
        public int leaveTypeId { get; set; }
        public int Period { get; set; }
        public string EmployeeId { get; set; } = string.Empty;
    }
}
