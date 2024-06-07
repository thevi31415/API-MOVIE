namespace API_MOVIE.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<MoviePerson> MoviePersons { get; set; } = new List<MoviePerson>();
        public string Language { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CoverImage { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? ModifieDate { get; set; }

    }
}
