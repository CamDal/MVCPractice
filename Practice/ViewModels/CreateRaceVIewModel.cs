using Practice.Data.Enum;
using Practice.Models;

namespace Practice.ViewModels
{
    public class CreateRaceVIewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public RaceCategory RaceCategory { get; set; }
    }
}
