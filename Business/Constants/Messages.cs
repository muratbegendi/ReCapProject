using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarAddedInvalid = "Araba ismi geçersiz veya Fiyat bilgisi 0 TL'den küçük";
        public static string CarDeleted =  "Araba başarılı bir şekilde silindi";
        public static string CarUpdated = "Araba başarılı bir şekilde güncellendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed ="Ürünler listelendi";
        public static string BrandNameInvalid ="Marka adı geçersiz";
        public static string BrandAdded ="Marka eklendi";
        public static string BrandListed ="Markalar listelendi";
        public static string BrandDeleted ="Marka silindi";
        public static string BrandUpdated ="Marka güncellendi";
        public static string ColorAdded ="Renk eklendi";
        public static string ColorNameInvalid ="Renk adı geçersiz";
        public static string ColorDeleted ="Renk silindi";
        public static string ColorUpdated ="Renk güncellendi";
        public static string ColorListed ="Renkler listelendi";
        
    }
}
