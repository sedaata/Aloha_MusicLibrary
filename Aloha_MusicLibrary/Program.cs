using Aloha_MusicLibrary.Services;

namespace Aloha_MusicLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddDbContext<MusicStoreContext>()
            .AddScoped<ArtistService>()
            .AddScoped<SongService>()
            .AddScoped<PlaylistService>()
            .AddScoped<PlaylistSongService>()
            .BuildServiceProvider();

            var artistService = serviceProvider.GetRequiredService<ArtistService>();
            var songService = serviceProvider.GetRequiredService<SongService>();
            var playlistService = serviceProvider.GetRequiredService<PlaylistService>();
            var playlistSongService = serviceProvider.GetRequiredService<PlaylistSongService>();

            // Yukarıdaki kodlar proje için gereklidir.
            // 1. Entity Framework ve DbContext sınıfıyla birlikte projenizi hazırlayınız.
            // 2. Models klasörü içinde yukarıda servisleri yer alan entityleri oluşturunuz, gerekli ilişkilendirmelerini kurgulayarak uygulayınız, Code First yöntemi ile ekleyiniz ve Migration'larını uygulayınız;
            ///// Artist [Name, Genre (müzik türü)]
            ///// Song [Title, Duration (çalma süresi), ReleaseYear, ArtistId]
            ///// Playlist [Name, Description]
            // 3. Services klasörü içine yukarıda gerekli olan servisleri ekleyiniz. Her bir entity için ayrı servis kullanınız. Bağlantı için klasördeki örnek servisten faydalanabilirsiniz.
            // 4. Aşağıdaki proje gereklilikleri kısmındaki adımları uygulamak için ilgili servislere gerekli metotları ekleyip bu sayfada kullanınız.
            // Önemli Not!!!: Yukarıdaki serviceProvider yapıları CRUD işlemlerinizi bu sayfada uygulamak için herhangi bir context sınıfına ihtiyaç duymayacağınız şekilde yeterlidir. Örnek: artistService.AddArtist(newArtist);


            // Proje Gereklilikleri
            // Tek bir oturumda konsol uygulamasının gerçekleştirmesi gereken görevler;
            // 1. Tüm Şarkıları Listele
            // 2. Şarkı Ekle (Sanatçı olması gerekiyor)
            // 3. Şarkıyı Düzenle
            // 4. Şarkıyı Sil
            // 5. Tüm Sanatçıları Listele
            // 6. Sanatçı Ekle
            // 7. Sanatçıyı Düzenle
            // 8. Sanatçıyı Sil
            // 9. Tüm Çalma Listelerini Listele
            // 10. Çalma Listesini Görüntüle (Seçilen liste içindeki şarkıları göstermelidir)
            // 11. Çalma Listesi Ekle
            // 12. Çalma Listesini Düzenle
            // 13. Çalma Listesini Sil
            // 14. Çalma Listesine Şarkı Ekle
            // 15. Çalma Listesinden Şarkı Kaldır
            // 16. Çıkış

            // Konsol uygulamanızı yukarıdaki tüm adımları tek tek sağlayacak şekilde burada yazınız.
            ////// Uygulamanın her adımı aşağıda oluşturulacak metotları kullanmalıdır. Örnek: Tüm Şarkıları Listele: ListAllSongs(artistService, songService)
        }

        // Konsol uygulamasının kullanacağı metotları sırasıyla buraya yazınız.
        ////// Örnek: private static void ListAllSongs(ArtistService artistService, SongService songService)
        ///////// Not: Dışarıdan alınan servis parametreleri kullanacağınız CRUD işlemleri için gereklidir. Her bir adımın kullanıcı arayüzü için gerekli Write ve Read yapılarını bu metotların içinde kullanınız.
    }
}