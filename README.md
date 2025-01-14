# Sözlük Projesi
Bu proje, popüler sözlük uygulamalarının işleyişini temel alarak geliştirilmiş bir Sözlük sitesi uygulamasıdır. Kullanıcıların başlık oluşturabileceği, başlıklara içerik ekleyebileceği ve mesajlaşma gibi özelliklerden faydalanabileceği bir sistemdir. Admin tarafında ise kategori, başlık yazar , raporlama ve içeriklerin yönetimi gibi bir dizi kapsamlı işlemler yapılabilmektedir.

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
- **İçerik:** Yazılan tüm yazıları listeleyebilir ve filtreleyebilir.
- **Raporlar:** Başlıklar CSV, Excel veya PDF formatlarında dışa aktarılabilir.
- **İletişim & Mesajlar:** 
  - Gelen mesajları görüntüleyebilir ve yanıtlayabilir.
  - Yeni mesaj oluşturabilir.
- **İstatistikler ve Grafikler:** 
  - Dinamik olarak istatistikler görüntülenebilir.
  - Kategorilerdeki başlık dağılımı ve içerik sayıları grafiklerle sunulabilir.
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
  - Sweet Alert, Google Charts, ReCaptcha, Pop Up
  - DataTable, Pagination, Searching
  - Hata Sayfaları (401, 404)

- **Kullanılan Teknolojiler:**
  - Asp.Net MVC5
  - Entity Framework Code First
  - MSSQL
  - HTML/CSS/Bootstrap

## Veritabanı Tablosu Ve İlişkileri
![veritabanı](https://github.com/user-attachments/assets/54ec2353-7106-417b-95cf-f8c82f2e6995)

## Site İndexi
![index](https://github.com/user-attachments/assets/f03624a5-c01c-4ea5-a2ac-30d7631a666b)

## Sözlük Tarafı
![vitrintarafıgiris](https://github.com/user-attachments/assets/706b6cb9-d66d-4ff4-9a99-5e083014285c)
![vitrintarafı](https://github.com/user-attachments/assets/f1a90fec-4417-445f-9030-57d50f9d2520)

## Yazar Tarafı
![yazargiris](https://github.com/user-attachments/assets/053da039-feaf-49da-8a27-5a1f2873759a)
![rechatpa](https://github.com/user-attachments/assets/56a3ecc4-1aa1-44bf-bfbe-14f57e4a9594)
![yazarprofil](https://github.com/user-attachments/assets/5cb5afa3-5e1e-4a5a-9e8c-4f9d7fb934b0)
![yazarbaslık](https://github.com/user-attachments/assets/7876ac2d-ba82-45e4-9363-d3711077e5b6)
![yazartümbaslık](https://github.com/user-attachments/assets/3abf0401-85bf-4400-a39c-645bf99657ae)
![mesaj kutus](https://github.com/user-attachments/assets/795c0938-994d-447c-87d3-54f929b2ed3c)
![yazaryazılarım](https://github.com/user-attachments/assets/afbc8620-715b-4600-9f2a-3064a2a6d72d)

## Admin Tarafı
![loginindexadmin](https://github.com/user-attachments/assets/7c64d999-0951-4242-8e40-e172984f4bf7)
![admincategory](https://github.com/user-attachments/assets/32b1a0ac-df1f-4dbe-9ba6-d747d8c75770)
![baslıkindex](https://github.com/user-attachments/assets/9984d2e4-8c77-4cd1-b43a-6470134ccc67)
![baslıkguncelle](https://github.com/user-attachments/assets/5ded33c0-9205-44ae-9cc0-29cc918b4e51)
![adminyazılar](https://github.com/user-attachments/assets/1b32aff8-aa0a-4fe6-8d8e-7c064b519f83)
![adminyazarlar](https://github.com/user-attachments/assets/a7bf83b2-8321-4106-9cfc-7d6d2c1c2dec)
![istatistikler](https://github.com/user-attachments/assets/a436acc9-fc98-4687-9dbc-a1f15363e661)
![kategoribaslıkchart](https://github.com/user-attachments/assets/358ea49d-cb45-432d-80f9-1b78cea7b493)
![hakkımızdapopup](https://github.com/user-attachments/assets/ff90613b-a6f5-48ef-8d1e-7d0df30881e2)
![adminiletisim](https://github.com/user-attachments/assets/13449e09-73aa-46fe-9a88-273cd0a2780a)
![gallery](https://github.com/user-attachments/assets/e0896a10-f145-410f-b90c-1a8b1bb8084d)
![baslıklarreport](https://github.com/user-attachments/assets/9d60d738-cc45-4f3b-832e-ad5dbbbba481)
![adminyetkilendirme](https://github.com/user-attachments/assets/888c3855-9b6d-4f3f-9dfd-72c4c1475214)
![yetkibazlıerişim](https://github.com/user-attachments/assets/fc0f5ac5-eb7e-40af-96d1-a57a1a793b1c)
![404](https://github.com/user-attachments/assets/4cecac25-ca5f-4268-8d8d-8910431fc4aa)
![401](https://github.com/user-attachments/assets/986548fb-fb7b-4237-b7d0-e64e17b3a873)












