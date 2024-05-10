using HR.leaveManagement.DomainFinnal.Common;

namespace HR.leaveManagement.DomainFinnal
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
