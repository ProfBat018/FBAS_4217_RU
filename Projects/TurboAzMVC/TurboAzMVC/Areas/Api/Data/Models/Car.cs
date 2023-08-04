using System.ComponentModel.DataAnnotations;
using DbbForTurboAz.Model;

public class Car
{
    private string vin;
    
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    
    public string ImgUrl { get; set; }
    public DateTime ProductionDate { get; set; }
    public decimal Price { get; set; }
    
    
    [RegularExpression(@"^[A-Z0-9]{17}$")]
    public string VIN
    {
        get => vin;
        set => vin = value.ToUpper();
    }

    public int Mileage { get; set; }
    public int EngineVolume { get; set; }
    public int HorsePower { get; set; }
    public int PassengerCount { get; set; }
    
    [RegularExpression(@"^\+994((55)|(50)|(51)|(70)|(77)|(10)|(99)|(60))([0-9]){7}")]
    public string PhoneNumber { get; set; }
    public int ShowRoomId { get; set; }
    public ShowRoom ShowRoom { get; set; }
    
    public int BodyTypeId { get; set; }
    public BodyType BodyType { get; set; }
   
    public int CityId { get; set; }
    public City City { get; set; }
   
    public int ColorId { get; set; }
    public Color Color { get; set; }
    
    public int WheelDriveTypeId { get; set; }
    public WheelDriveType WheelDriveType { get; set; }

    public int FuelTypeId { get; set; }
    public FuelType FuelType { get; set; }
    
    public int TransmissionTypeId { get; set; }
    public TransmissionType TransmissionType { get; set; }
}