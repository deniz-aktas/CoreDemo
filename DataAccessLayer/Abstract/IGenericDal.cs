using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T: class
        //Category ve blog interfacelerin içine metotları yazmadan buraya dışarıdan entity parametresi göndermemiz gerekiyor
        //<T> where T: class o nedenle bunu yazdık---> T entity nin karşılıgndakı değer olacak şartımız ise (where) T bir class a ait bütün değerleri kullanacak
    {
        //tıpkı category ve blog a tanımladıgımız gıbı metotları tanımladık
        void Insert(T t); // ekleme
        void Delete(T t); // silmee
        void Update(T t); // güncelleme
        List<T> GetListAll(); // Listeleme
        T GetByID(int id); //id ye göre getir

        List<T> GetListAll(Expression<Func<T, bool>> filter); 
    }
}
