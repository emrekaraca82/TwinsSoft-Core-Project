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
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public IResult Add(Slider slider)
        {
            _sliderDal.Add(slider);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Slider slider)
        {
            _sliderDal.Delete(slider);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Slider>> GetAll()
        {
            return new SuccessDataResult<List<Slider>>(_sliderDal.GetList(),Messages.Listed);
        }

        public IDataResult<Slider> GetById(int id)
        {
           return new SuccessDataResult<Slider>(_sliderDal.Get(x => x.SliderID == id));
        }

        public IResult Update(Slider slider)
        {
            _sliderDal.Update(slider);
            return new SuccessResult(Messages.Updated);
        }
    }
}
