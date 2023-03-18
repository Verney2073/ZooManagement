using ZooManagement.Models;
using static ZooManagement.Models.Species;

namespace ZooManagement.Request
{
    public class SearchRequest
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public virtual string Filters => "";
    }

    public class AnimalSearchRequest : SearchRequest
    {
        public int Id { get; set; }
        public int speciesId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public DateTime DateAcquiredByZoo { get; set; }

        public string SpeciesName { get; set; }

        public Classifications Classification { get; set; }
    }
}