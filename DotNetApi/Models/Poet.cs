namespace DotNetApi.Models
{
    public class Poet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }

        public virtual IList<Poetry> Poetries { get; set; }
    }
}