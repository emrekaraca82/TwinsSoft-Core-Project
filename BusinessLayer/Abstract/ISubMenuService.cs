using Core.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubMenuService
    {
        IDataResult<List<SubMenu>> GetAll();
        IDataResult<SubMenu> GetById(int id);
        IDataResult<List<SubMenu>> GetAllByMenuId(int id);
        IResult Add(SubMenu subMenu);
        IResult Delete(SubMenu subMenu);
        IResult Update(SubMenu subMenu);

    }
}
