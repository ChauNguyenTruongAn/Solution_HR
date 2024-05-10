using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.leaveManagement.DomainFinnal.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime DateModified { get; set; }
        public string? ModifiedBy { get; set;}
    }
}
