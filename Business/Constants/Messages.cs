using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string NameError = "Kullanıcı adı veya soyadı giriniz";
        public static string UserAdded = "Kullanıcı başarılı bir şekilde eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UsersListed = "Kullanıcılar görüntülendi";
        public static string UserUpdated = "Kullanıcı silindi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomersListed = "Müşteriler görüntülendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string Rentalİnvalid = "Kiralama tarihi boş olamaz";
        public static string RentalAdded = "Kiralama Eklendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalsListed = "Kiralamalar listelendi";
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string RentalUpdatedReturnDateError = "Araç Teslim Alındı.";
        public static string RentalUpdatedReturnDate = "Araç Teslim Alındı.";
        public static string CarCountOfBrandError = "BU kategoride en fazla 10 araç bulunabilir";
        public static string CarNameAlreadyExists;
        public static string CarImageLimitExceeded;
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
