﻿using File_Acess_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Acess_Management.Data.Repository.IRepository
{
    public interface IUserManagementRepository:IMainRepository<Users>
    {
        int InsertUser(Users user);
        bool CheckUser(string username);
    }
}
