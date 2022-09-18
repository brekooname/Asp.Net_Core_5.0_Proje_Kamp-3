using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; }
        //ilişkili tablolarda silmek problem olduğundan
        //kategori silmek yerine bool ile aktif / pasif işlemi yapacağız.

        public List<Blog> Blogs { get; set; }
        //Her kategorinin birden çok blog'u olabilir.
        //List içerisinde tüm blog lar yer alır. Burası mantığıma yattı.
    }
}
