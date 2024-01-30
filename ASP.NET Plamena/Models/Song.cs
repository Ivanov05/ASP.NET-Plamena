namespace ASP.NET_Plamena.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
