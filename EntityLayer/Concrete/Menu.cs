using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Menu : IEntity
    {
        public int MenuID { get; set; }     
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
        public string MenuIcon { get; set; }
        public bool MenuStatus { get; set; }     
        public List<SubMenu> SubMenus { get; set; }

    }
}
