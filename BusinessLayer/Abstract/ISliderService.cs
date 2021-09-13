using Core.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISliderService
    {
        IDataResult<List<Slider>> GetAll();
        IDataResult<Slider> GetById(int id);
        IResult Add(Slider slider);
        IResult Delete(Slider slider);
        IResult Update(Slider slider);

    }
}
