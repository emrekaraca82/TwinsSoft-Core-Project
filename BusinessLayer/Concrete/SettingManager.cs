using Business.Constants;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SettingManager : ISettingService
    {
        ISettingDal _settingDal;

        public SettingManager(ISettingDal settingDal)
        {
            _settingDal = settingDal;
        }

        public IDataResult<List<Setting>> GetAll()
        {
            return new SuccessDataResult<List<Setting>>(_settingDal.GetList(), Messages.Listed);
        }

        public IDataResult<Setting> GetById(int id)
        {
            return new SuccessDataResult<Setting>(_settingDal.Get(x => x.SettingID == id));
        }
   
        public IResult Delete(Setting setting)
        {
            _settingDal.Delete(setting);
            return new SuccessResult(Messages.Deleted);
        }

        [ValidationAspect(typeof(SettingValidator))]
        public IResult Update(Setting setting)
        {
            _settingDal.Update(setting);
            return new SuccessResult(Messages.Updated);
        }
         
    }
}
