namespace ASP.NET_Plamena.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Song> SongsList { get; set; }
        public List<Genre> GenreList { get; set; }
    }
}
