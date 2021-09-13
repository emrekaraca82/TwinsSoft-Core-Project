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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public IResult Add(About about)
        {
            _aboutDal.Add(about);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(About about)
        {
            _aboutDal.Delete(about);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<About>> GetAll()
        {
            return new SuccessDataResult<List<About>>(_aboutDal.GetList(), Messages.Listed);
        }

        public IDataResult<About> GetById(int id)
        {          
            return new SuccessDataResult<About>(_aboutDal.Get(x => x.AboutID == id));
        }

        public IResult Update(About about)
        {
            _aboutDal.Update(about);
            return new SuccessResult(Messages.Updated);
        }
    }
}
