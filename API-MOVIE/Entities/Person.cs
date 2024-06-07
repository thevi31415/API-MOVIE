namespace API_MOVIE.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<MoviePerson> MoviePersons { get; set; } = new List<MoviePerson>();
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? ModifieDate { get; set; }
    }
}

