using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetApi.Models
{
    public class Poetry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(PoetId))]
        public int PoetId { get; set; }
        public Poet Poet { get; set; }
    }
}
