using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Slider : IEntity
    {
        public int SliderID { get; set; }
        public string SliderTitle { get; set; }
        public string SliderLink { get; set; }
        public string SliderLinkWriter { get; set; }
        public string SliderImage { get; set; }
        public int SliderOrder { get; set; }
        public bool SliderStatus { get; set; }
        public DateTime SliderCreateDate { get; set; }
    }
}
