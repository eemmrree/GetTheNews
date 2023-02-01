using GetTheNews.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheNews.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public long? DeletedBy { get; set; }
        public IsDeleted IsDeleted { get; set; } = IsDeleted.No;

    }
}
