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
    public class MenuManager : IMenuService
    {
        IMenuDal _menuDal;
        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }

        public IResult Add(Menu menu)
        {
            _menuDal.Add(menu);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Menu menu)
        {
            _menuDal.Delete(menu);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Menu>> GetAll()
        {
            return new SuccessDataResult<List<Menu>>(_menuDal.GetList(),Messages.Listed);
        }

        public IDataResult<Menu> GetById(int id)
        {
            return new SuccessDataResult<Menu>(_menuDal.Get(x => x.MenuID == id));
        }

        public IResult Update(Menu menu)
        {
            _menuDal.Update(menu);
            return new SuccessResult(Messages.Updated);
        }
    }
}
