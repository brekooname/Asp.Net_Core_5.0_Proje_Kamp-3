﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void Delete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void Update(Blog t)
        {
            _blogDal.Update(t);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetByID(id);
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> GetListWithCategoryByAuthorBm(int id)
        {
            return _blogDal.GetListWithCategoryByAuthor(id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().TakeLast(3).ToList();
        }

        public List<Blog> GetLast10Blog()
        {
            return _blogDal.GetListAll().TakeLast(10).ToList();
        }

        public List<Blog> GetBlogListByAuthor(int id)
        {
            return _blogDal.GetListAll(x => x.AuthorID == id);
        }


        //BURAYA ARANACAK KELİMEYİ GİRİN KISMI YAPIALCAK
        //public List<Blog> GetBlogContain(string search)
        //{
        //    return _blogDal.GetListAll().Contains(search).ToList();
        //}


    }
}
