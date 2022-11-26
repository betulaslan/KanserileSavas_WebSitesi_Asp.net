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
    public class AnasayfaManager : IAnasayfaService
    {
        IAnaSayfaDal _anaSayfaDal;

        public AnasayfaManager(IAnaSayfaDal anaSayfaDal)
        {
            _anaSayfaDal = anaSayfaDal;
        }

        public void TAdd(AnaSayfa t)
        {
            _anaSayfaDal.Insert(t);
        }

        public void TDelete(AnaSayfa t)
        {
            _anaSayfaDal.Delete(t);
        }

        public AnaSayfa TGetByID(int id)
        {
            return _anaSayfaDal.GetByID(id);
        }

        public List<AnaSayfa> TGetList()
        {
            return _anaSayfaDal.GetList();
        }

        public void TUpdate(AnaSayfa t)
        {
            _anaSayfaDal.Update(t);
        }
    }
}
