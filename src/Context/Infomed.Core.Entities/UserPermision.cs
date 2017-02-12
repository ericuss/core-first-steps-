using Infomed.Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Entities
{
    public class UserPermision
    {
        public Guid PermisionId { get; set; }
        public Permision Permision { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
