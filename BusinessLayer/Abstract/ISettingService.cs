using Core.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISettingService
    {
        IDataResult<List<Setting>> GetAll();
        IDataResult<Setting> GetById(int id);
        IResult Delete(Setting setting);
        IResult Update(Setting setting);

    }
}
