namespace UTS_NET_LANJUTAN_ANDRIANSYAH.Models
{
    public class Stats
    {
        public int jumlahKomik { get; set; }
        public int jumlahNovel { get; set; }
        public int jumlahSejarah { get; set; }

        public int Total
        {
            get
            {
                return (jumlahKomik+jumlahNovel+jumlahSejarah);
            }
            set
            {
                Total = value;
            }
        }
    }
}
