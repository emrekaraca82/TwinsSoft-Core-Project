using Business.Constants;
using BusinessLayer.Abstract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubMenuManager : ISubMenuService
    {
        ISubMenuDal _subMenuDal;
      
        public SubMenuManager(ISubMenuDal subMenuDal)
        {
            _subMenuDal = subMenuDal;
        }

        public IResult Add(SubMenu subMenu)
        {
            _subMenuDal.Add(subMenu);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(SubMenu subMenu)
        {
            _subMenuDal.Delete(subMenu);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<SubMenu>> GetAll()
        {
            return new SuccessDataResult<List<SubMenu>>(_subMenuDal.GetList(),Messages.Listed);
           
        }

        public IDataResult<SubMenu> GetById(int id)
        {
            return new SuccessDataResult<SubMenu>( _subMenuDal.Get(x => x.SubMenuID == id));
        }

        public IDataResult<List<SubMenu>> GetAllByMenuId(int id)
        {
            return new SuccessDataResult<List<SubMenu>>(_subMenuDal.GetList(p => p.Menu.MenuID == id));
         
        }

        public IResult Update(SubMenu subMenu)
        {        
            _subMenuDal.Update(subMenu);
            return new SuccessResult(Messages.Updated);
        }
    }
}
