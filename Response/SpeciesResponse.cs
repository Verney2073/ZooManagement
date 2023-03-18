using ZooManagement.Models;
using static ZooManagement.Models.Species;

namespace ZooManagement.Response
{
    public class SpeciesResponse
    {
        private readonly Species _Species;

        public SpeciesResponse(Species species)
        {
            _Species = species;
        }
            public int Id => _Species.Id;

            public string SpeciesName => _Species.SpeciesName;

            public Classifications Classification => _Species.Classification;
        
    }
}

/*
   public int Id { get; set; }
    public string SpeciesName { get; set; }
    public Classifications Classification { get; set; } */