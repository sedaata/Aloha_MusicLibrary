using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aloha_MusicLibrary.Services
{
    public class ArtistService
    {
        private readonly MusicStoreContext _context;

        public ArtistService(MusicStoreContext context)
        {
            _context = context;
        }

        // CRUD ve gerekli diğer metotları buraya yazınız. Bu sayfada sadece Artist ile ilgili işlemler uygulanmalıdır. Diğer entityler için ayrı servisler oluşturulmalıdır.
        // _context.Artists.Add()
    }
}
