using QuanLySieuThi.DAL;
using QuanLySieuThi.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.BAL
{
    internal class AreaBAL
    {
        AreaDAL dal = new AreaDAL();
        public List<AreaBEL> ReadAreaList()
        {
            List<AreaBEL> lstArea = dal.ReadAreaList();
            return lstArea;
        }
    }
}
