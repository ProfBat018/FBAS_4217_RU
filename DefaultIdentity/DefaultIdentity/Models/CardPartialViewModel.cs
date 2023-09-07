using DefaultIdentity.Areas.Identity.Data;

namespace DefaultIdentity.Models;

public class CardPartialViewModel
{
    public List<Car> Cars { get; set; } = new()
    {
        new()
        {
            Make = "Mercedes",
            Model = "C class",
            ImgUrl =
                "https://www.mercedes-benz.com.tr/passengercars/mercedes-benz-cars/models/c-class/saloon-w205/_jcr_content/image.MQ6.2.2x.20201203155631.png"
        },
        new()
        {
            Make = "BMW",
            Model = "3 series",
            ImgUrl =
                "https://www.bmw.com.tr/content/dam/bmw/common/all-models/3-series/sedan/2018/navigation/BMW-3er-Sedan-ModelCard.png"
        }
    };
}