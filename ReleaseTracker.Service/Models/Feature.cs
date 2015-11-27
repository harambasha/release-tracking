using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseTracker.Service.Models
{
    public class Feature
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Approved { get; set; }
        public long UserId { get; set; }
        public long ReleaseId { get; set; }
    }
}
