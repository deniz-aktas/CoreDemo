using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment); //ekleme
        //void CategoryDelete(Category category); //silme
        //void CategoryUpdate(Category category); //güncelleme
        List<Comment> GetList(int id); //listeleme
        //Category GetById(int id); //id ye göre getirme işlmei dışardan int turunde parametre alacak
    }
}
