namespace MvcMovie.Models
{
    public class Movie
    {
            private string maPhim;
            private string tenPhim;
            public string MaPhim{
            get { return maPhim; }
            set { maPhim = value; }
            }
            public string TenPhim {
            get { return tenPhim;}
            set { tenPhim = value; }
            }
    }
}