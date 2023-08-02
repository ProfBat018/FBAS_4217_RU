using System.ComponentModel.DataAnnotations;

namespace DbbForTurboAz.Model
{
    public class City
    {
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string Name { get; set; }
    }
}
