﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        Admin GetAdmin(string username, string password);

        Admin GetRole(string username);

        List<Admin> GetList();

        void AdminAdd(Admin admin);

        Admin GetByID(int id);

        void AdminDelete(Admin admin);

        void AdminUpdate(Admin admin);
    }
}
