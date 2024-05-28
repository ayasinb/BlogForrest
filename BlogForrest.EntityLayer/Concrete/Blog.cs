using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForrest.EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string ThumbnailImageURL { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ViewCount { get; set; }
        public string CoverImageURL { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }  
    }
}
