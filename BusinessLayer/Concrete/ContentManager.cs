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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public IResult Add(Content content)
        {
            _contentDal.Add(content);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Content content)
        {
            _contentDal.Delete(content);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Content>> GetAll()
        {
            return new SuccessDataResult<List<Content>>( _contentDal.GetList(),Messages.Listed);
        }

        public IDataResult<Content> GetById(int id)
        {
            return new SuccessDataResult<Content>(_contentDal.Get(x => x.ContentID == id));     
        }

        public IResult Update(Content content)
        {
            _contentDal.Update(content);
            return new SuccessResult(Messages.Updated);
        }
    }
}
