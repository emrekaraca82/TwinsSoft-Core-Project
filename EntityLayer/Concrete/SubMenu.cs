using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SubMenu : IEntity
    {
        public int SubMenuID { get; set; }
        public int MenuId { get; set; }
        public string SubMenuName { get; set; }
        public string SubMenuUrl { get; set; }
        public string SubMenuIcon { get; set; }
        public bool SubMenuStatus { get; set; }    
        public virtual Menu Menu { get; set; }
    }
}
