﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categorydal = categoryDal;
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }

        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);
        }

        public Category GetByID(int id)
        {
            return _categorydal.Get(x => x.CategoryID == id);
        }

        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categorydal.Update(category);
        }
    }
}
