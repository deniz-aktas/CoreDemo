using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t); //ekleme
        void TDelete(T t); //silme
        void TUpdate(T t); //güncelleme
        List<T> GetList(); //listeleme
        T TGetById(int id); //id ye göre getirme işlmei dışardan int turunde parametre alacak

    }
}
