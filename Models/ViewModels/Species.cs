namespace ZooManagement.Models;

public class Species
{
        public enum Classifications 
    {
        mammal,
        reptile,
        bird,
        insect,
        fish,
        invertebrate
    }
    public int Id { get; set; }
    public string SpeciesName { get; set; }
    public Classifications Classification { get; set; }
}
