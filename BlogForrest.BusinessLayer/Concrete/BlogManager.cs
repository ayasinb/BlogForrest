using BlogForrest.BusinessLayer.Abstract;
using BlogForrest.DataAccessLayer.Abstract;
using BlogForrest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForrest.BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Blog TGetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public void TInsert(Blog entity)
        {
            _blogDal.Insert(entity);
        }

        public void TUpdate(Blog entity)
        {
            throw new NotImplementedException();
        }

        public List<Blog> TGetListAll()
        {
            return _blogDal.GetListAll();
        }
    }
}
