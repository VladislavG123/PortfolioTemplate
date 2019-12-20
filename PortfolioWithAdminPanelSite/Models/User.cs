using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioWithAdminPanelSite.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string About { get; set; }

        public virtual ICollection<Projects> Projects { get; set; }
    }
}
