using System.ComponentModel.DataAnnotations;

namespace DbbForTurboAz.Model
{
    public class Color
    {
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string Name { get; set; }
    }
}
