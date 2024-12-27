# Sözlük Projesi

Bu proje, popüler sözlük uygulamalarının işleyişini temel alarak geliştirilmiş bir Sözlük sitesi uygulamasıdır. Kullanıcıların başlık oluşturabileceği, başlıklara içerik ekleyebileceği ve mesajlaşma gibi özelliklerden faydalanabileceği bir sistemdir. Admin tarafında ise kategorilerin ve içeriklerin yönetimi gibi kapsamlı işlemler yapılabilmektedir.

## Proje Özellikleri

### Kullanıcı Paneli
- **Profilim:** Kullanıcı bilgilerini güncelleyebilir.
- **Başlıklarım:** Kendi oluşturduğu başlıkları görüntüleyebilir, düzenleyebilir ve içerikleri görebilir.
- **Tüm Başlıklar:** Sitedeki tüm başlıkları görüntüleyebilir ve seçili başlıklara entry (içerik),yorum ekleyebilir.
- **Mesajlar:** 
  - Kullanıcı, diğer kullanıcılara mesaj gönderebilir.
  - Gelen mesajları ve gönderdiği mesajları görüntüleyebilir hangi formatta ise o şekilde görebilir.
- **Yazılarım:** Kendi eklediği tüm içerikleri tarih/zaman bilgileriyle görüntüler.

### Admin Paneli
- **Kategoriler:** 
  - Yeni kategori ekleme, düzenleme ve silme işlemleri yapılabilir.
- **Başlıklar:** 
  - Sitedeki tüm başlıklar listelenir ve içerikleri yönetilebilir.
  - Başlıkları aktif/pasif duruma getirme işlemleri yapılabilir.
- **İçerik:** Yazılan tüm yazılar listeleyebilir ve filtreleyebilir.
- **Raporlar:** Başlıklar CSV, Excel veya PDF formatlarında dışa aktarılabilir.
- **İletişim & Mesajlar:** 
  - Gelen mesajları görüntüleyebilir ve yanıtlayabilir.
  - Yeni mesaj oluşturabilir.
- **Yetkilendirmeler:**
  - Yeni admin eklenebilir ve yetkileri düzenlenebilir.
  - Yetkisiz adminler belirli işlemleri gerçekleştiremez.

## Teknik Detaylar
- **Geliştirme Yaklaşımı:**
  - N Katmanlı Mimari (Business, DataAccess, Entity, Presentation)
  - Repository Design Pattern
- **Özellikler:**
  - Authentication & Authorization
  - Fluent Validation
  - LINQ Sorguları
  - Sweet Alert, Google Charts, ReCaptcha
  - DataTable, Pagination, Searching
  - Hata Sayfaları (401, 404)

- **Kullanılan Teknolojiler:**
  - Asp.Net MVC5
  - Entity Framework
  - MSSQL
  - HTML/CSS/Bootstrap


## Veritabanı Tablosu Ve İlişkileri
![veritabanı](https://github.com/user-attachments/assets/54ec2353-7106-417b-95cf-f8c82f2e6995)

## Site İndexi



## Yazar Girişi
