using Core.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMenuService
    {
        IDataResult<List<Menu>> GetAll();    
        IDataResult<Menu> GetById(int id);
        IResult Add(Menu menu);
        IResult Delete(Menu menu);
        IResult Update(Menu menu);

    }
}
