using System.ComponentModel.DataAnnotations;

namespace DbbForTurboAz.Model
{
    public class ShowRoom
    {
        public int Id { get; set; }
        
        [RegularExpression(@"^[a-zA-Z0-9_.]+$")]
        public string Name { get; set; }
        
        [RegularExpression(@"^[a-zA-Z0-9 ./]+$")]
        public string Address { get; set; }
        
        [RegularExpression(@"^\+994((55)|(50)|(51)|(70)|(77)|(10)|(99)|(60))([0-9]){7}")]
        public string PhoneNumber  { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
