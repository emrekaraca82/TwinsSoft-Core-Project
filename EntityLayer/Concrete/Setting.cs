using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Setting : IEntity
    {
        public int SettingID { get; set; }
        public string SiteUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string Author { get; set; }
        public string Tel { get; set; }
        public string Gsm { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Mesai { get; set; }
        public string SmtpHost { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpSecure { get; set; }  
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instgram { get; set; }
        public string Youtube { get; set; }
        public string Lınkedin { get; set; }
        public string Google { get; set; }
        public string Recaptha { get; set; }
        public string Map { get; set; }
        public string Analystic { get; set; }
    }
}
