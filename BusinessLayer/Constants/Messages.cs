using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //static verdiğimiz zaman new'lemez
    public static class Messages
    {
        public static string Added = "Kayıt Eklendi";
        public static string Updated = "Kayıt Güncelendi";
        public static string Deleted = "Kayıt Silindi";
        public static string Listed = "Veriler Listelendi";
        public static string Error = "Record Error";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CheckIfCategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenid = "Yetkiniz Yoktur";

    }
}
