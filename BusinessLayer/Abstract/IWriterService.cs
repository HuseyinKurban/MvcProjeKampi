using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();

        void WriterAdd(Writer writer);
        //idye göre getirme,bulma
        Writer GetByID(int id);

        void WriterDelete(Writer writer);

        void WriterUpdate(Writer writer);
    }
}