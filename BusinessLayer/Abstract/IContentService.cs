using Core.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        IDataResult<List<Content>> GetAll();
        IDataResult<Content> GetById(int id);
        IResult Add(Content content);
        IResult Delete(Content content);
        IResult Update(Content content);

    }
}
