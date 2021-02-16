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
        public static string CarDeleted = "Araba başarılı bir şekilde silindi";
        public static string CarUpdated = "Araba başarılı bir şekilde güncellendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string BrandNameInvalid = "Marka adı geçersiz";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorNameInvalid = "Renk adı geçersiz";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorListed = "Renkler listelendi";
        internal static string NameError = "Kullanıcı adı veya soyadı giriniz";
        internal static string UserAdded = "Kullanıcı başarılı bir şekilde eklendi";
        internal static string UserDeleted = "Kullanıcı silindi";
        internal static string UsersListed = "Kullanıcılar görüntülendi";
        internal static string UserUpdated = "Kullanıcı silindi";
        internal static string CustomerAdded = "Müşteri eklendi";
        internal static string CustomersListed = "Müşteriler görüntülendi";
        internal static string CustomerUpdated = "Müşteri güncellendi";
        internal static string CustomerDeleted = "Müşteri silindi";
        internal static string Rentalİnvalid = "Kiralama tarihi boş olamaz";
        internal static string RentalAdded = "Kiralama Eklendi";
        internal static string RentalDeleted = "Kiralama silindi";
        internal static string RentalsListed = "Kiralamalar listelendi";
        internal static string RentalUpdated = "Kiralama güncellendi";
        internal static string RentalUpdatedReturnDateError = "Araç Teslim Alındı.";
        internal static string RentalUpdatedReturnDate = "Araç Teslim Alındı.";
    }
}
