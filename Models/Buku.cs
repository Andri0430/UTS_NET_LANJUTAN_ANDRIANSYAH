namespace UTS_NET_LANJUTAN_ANDRIANSYAH.Models
{
    public class Buku
    {
        public string genre { get; set; }
        public string judul { get; set; }

        public Buku(string genr, string kategori)
        {
            genre = genr;
            judul = kategori;
        }
    }
}