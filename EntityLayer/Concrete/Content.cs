using Core.Entities;
using System;

namespace EntityLayer.Concrete
{
    public class Content : IEntity
    {
        public int ContentID { get; set; }
        public string ContentTitle { get; set; }
        public long ContentDetail { get; set; }
        public string ContentKeyword { get; set; }
        public string ContentImage { get; set; }
        public string ContentLink { get; set; }
        public bool ContentStatus { get; set; }
        public int ContentOrder { get; set; } //içerik Sırası
        public DateTime ContentCreateDate { get; set; }

    }
}
