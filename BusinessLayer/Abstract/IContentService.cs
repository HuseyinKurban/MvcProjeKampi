using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        //idye göre liste döndürme
        List<Content> GetListByHeadingID(int id);

        List<Content> GetListByWriterID(int id);

        void ContentAdd(Content content);

        Content GetByID(int id);

        void ContentDelete(Content content);

        void ContentUpdate(Content content);

         int? GetWriterIdByMail(string mail); // WriterID döndürmek için


    }
}
