 # StoreApp - ASP.NET Core MVC E-Ticaret Uygulaması

## Proje Hakkında

StoreApp, ASP.NET Core MVC kullanılarak geliştirilmiş temel özelliklere sahip bir e-ticaret uygulamasıdır. Ürünlerin listeleme, ekleme, güncelleme ve silme işlemleri desteklenmektedir. Katmanlı mimari ile sürdürülebilir bir yapı sunar.

---

## Özellikler

- Ürün listeleme ve detay görüntüleme  
- Ürün ekleme, güncelleme ve silme  
- Entity Framework Core Code First ile SQLite veritabanı yönetimi  
- Bootstrap ile responsive tasarım  
- Katmanlı mimari ve temiz kod prensipleri

---

## Teknolojiler

- ASP.NET Core MVC  
- C#  
- Entity Framework Core (Code First)  
- SQLite  
- Bootstrap  
- Visual Studio / VS Code

---

## Kurulum ve Çalıştırma

1. Depoyu klonlayın:  
```bash
git clone https://github.com/southernleo/Store.git
Proje klasörüne gidin:

bash
cd Store
Gerekli NuGet paketlerini indirin:
bash

dotnet restore
appsettings.json dosyasındaki bağlantı dizesinin doğru olduğundan emin olun:


"ConnectionStrings": {
    "DefaultConnection": "Data Source=StoreApp.db"
}
Migrationları uygulayarak veritabanını oluşturun:

bash
dotnet ef database update
Uygulamayı çalıştırın:

bash
Kopyala
Düzenle
dotnet run
Tarayıcınızda https://localhost:5001 (veya konsolda verilen URL) adresine gidin ve uygulamayı kullanmaya başlayın.
