using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authordal;

        public AuthorManager(IAuthorDal authordal)     //bu Author manager her çalıştığında bu nesneyi gelen parametreyi -ye ata ve author olarak türet demek oluyor.
        {
            _authordal = authordal;
        }

        public void Add(Author t)
        {
            _authordal.Insert(t);
        }

        public void Delete(Author t)
        {
            _authordal.Delete(t);
        }

        public List<Author> GetAuthorById(int id)
        {
            return _authordal.GetListAll(x=>x.AuthorID==id);
        }

        public Author GetById(int id)
        {
            return _authordal.GetByID(id);
        }

        public List<Author> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Author t)
        {
            _authordal.Update(t);
        }
    }
}
 