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
    public class HaberlerManager : IHaberlerService
    {
        IHaberlerDal _haberlerDal;

        public HaberlerManager(IHaberlerDal haberlerDal)
        {
            _haberlerDal = haberlerDal;
        }

        public void TAdd(AnaSayfa t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AnaSayfa t)
        {
            throw new NotImplementedException();
        }

        public AnaSayfa TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AnaSayfa> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AnaSayfa t)
        {
            throw new NotImplementedException();
        }
    }
}
