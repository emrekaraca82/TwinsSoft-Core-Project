using Core.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        IDataResult<List<About>> GetAll();
        IDataResult<About> GetById(int id);
        IResult Add(About about);
        IResult Delete(About about);
        IResult Update(About about);

    }
}
