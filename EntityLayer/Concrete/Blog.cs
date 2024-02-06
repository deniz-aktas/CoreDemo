using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; } 
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryID { get; set; } //ID nin tutulacagı alan category ıd ile aynı olmalı ilişkı kısmında sıkıntı yaşamayalım diye
        public Category Category{ get; set; } //İlişki içersine alınacak olan tablo türünde ya da entity türünde tanımlanması gerekıyor
        public int MyProperty { get; set; }
        public int WriterID { get; set; }
        public Writer Writer { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
