using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class YonetimUyeManager : IYonetimUyeService
    {
        IYonetimUyeDal _yonetimUyeDal;

        public YonetimUyeManager(IYonetimUyeDal yonetimUyeDal)
        {
            _yonetimUyeDal = yonetimUyeDal;
        }

        public void TAdd(YonetimUye t)
        {
            _yonetimUyeDal.Insert(t);
        }

        public void TDelete(YonetimUye t)
        {
            _yonetimUyeDal.Delete(t);
        }

        public YonetimUye TGetByID(int id)
        {
            return _yonetimUyeDal.GetByID(id);
        }

        public List<YonetimUye> TGetList()
        {
            return _yonetimUyeDal.GetList();
        }

        public void TUpdate(YonetimUye t)
        {
            _yonetimUyeDal.Update(t);
        }
    }
}
