## ATM Uygulaması
Bu projede, C# dilinde geliştirilmiş bir ATM Uygulaması bulunmaktadır. Kullanıcılar, giriş yaparak bakiye sorgulaması, para çekme ve para yatırma işlemlerini gerçekleştirebilirler. Bu uygulama, n katmanlı mimari prensiplerine dayalı olarak geliştirilmiştir ve kullanıcı doğrulama, işlem yönetimi ve veri erişimi gibi çeşitli katmanlar kullanılmıştır.

## Proje Özellikleri
- **Kullanıcı Girişi:** Kullanıcı adı ve şifre ile kullanıcı doğrulama yapılır.
- **Bakiye Sorgulama:** Kullanıcı, mevcut bakiyesini sorgulayabilir.
- **Para Çekme:** Kullanıcı, hesabından para çekebilir. Yetersiz bakiye durumunda hata mesajı görüntülenir.
- **Para Yatırma:** Kullanıcı, hesabına para yatırabilir.
- **Veritabanı Entegrasyonu:** SQL Server kullanılarak, kullanıcı bilgileri ve işlem verileri bir veritabanına kaydedilir.

## Kullanılan Teknolojiler
- **Dil:** C#
- **Veritabanı:** SQL Server
- **Katmanlı Mimari:** N katmanlı mimari kullanılarak uygulama modüler bir şekilde yapılandırılmıştır.
- **Veritabanı Bağlantısı:** Entity Framework veya ADO.NET ile SQL Server veritabanına bağlanılır.

## Proje Yapısı
Proje, n katmanlı mimariyi temel alarak 4 ana katmandan oluşmaktadır:

1. **Presentation Layer (Sunum Katmanı):** Kullanıcıyla etkileşimi sağlar. Konsol tabanlı arayüz sunar ve kullanıcıdan alınan verileri iş katmanına aktarır.
2. **Business Layer (İş Katmanı):** İş mantığının yönetildiği katmandır. Kullanıcı doğrulama, bakiye sorgulama, para çekme ve para yatırma gibi işlemler burada gerçekleştirilir.
3. **Data Access Layer (Veri Erişim Katmanı):** Veritabanı işlemleri bu katmanda yapılır. Kullanıcı bilgileri ve işlemler SQL Server veritabanında saklanır.
4. **Database Layer (Veritabanı Katmanı):** Veritabanı işlemleri gerçekleştirilir. Kullanıcı bilgileri, bakiye verileri ve işlem geçmişi burada saklanır.

## N Katmanlı Mimari ile Öğrenilenler
Bu projede, n katmanlı mimariyi öğrenmek, konu üzerinde pratik yapmak, yazılım geliştirme becerilerimi önemli ölçüde geliştirdi.

- **Modülerlik:** Her katman yalnızca kendi sorumluluklarıyla ilgilenir, böylece kodun bakımı ve genişletilmesi daha kolay hale gelir.
- **Bağımsızlık:** Her bir katman bağımsız olarak geliştirilebilir ve test edilebilir.
- **Yeniden Kullanılabilirlik:** Katmanlar arası bağımlılık azaldığı için aynı yapıyı başka projelerde de kullanmak mümkün olur.
