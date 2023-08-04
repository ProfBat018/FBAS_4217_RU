using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbbForTurboAz.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace TurboAzMVC.Areas.Api
{
    [ApiController]
    [Area("Api")]
    
    public class CarController : ControllerBase
    {
        private TurboDbContext _context;

        public CarController(TurboDbContext context)
        {
            Console.WriteLine("WebApi Controller");
            _context = context;
        }

        [HttpGet("GetAllCars")]
        [Route("{area}/{controller}/GetAllCars")]
        public async Task<IActionResult> GetAllCarsAsync()
        {
            var cars = await _context.Cars.ToListAsync();
            return Ok(cars);
        }

        [HttpGet("GetCarById")]
        [Route("{area}/{controller}/GetCarById/{id}")]
        public async Task<IActionResult> GetCarByIdAsync(int id)
        {
            var cars = await _context.Cars
                .Where(x => x.Id == id)
                .Include(x => x.City)
                .Include(x => x.Color)
                .Include(x => x.BodyType)
                .Include(x => x.FuelType)
                .Include(x => x.ShowRoom)
                .Include(x => x.WheelDriveType)
                .Include(x => x.WheelDriveType)
                .Select(x => new
                {
                    Make = x.Make,
                    Model = x.Model,
                    Year = x.ProductionDate,
                    Price = x.Price,
                    City = x.City.Name,
                    Color = x.Color.Name,
                    BodyType = x.BodyType.Name,
                    FuelType = x.FuelType.Name,
                    WheelDriveType = x.WheelDriveType.Name,
                    TransmissionType = x.TransmissionType.Name,
                    ShowRoom = x.ShowRoom.Name,
                    PhoneNumber = x.PhoneNumber,
                    Mileage = x.Mileage,
                    EngineVolume = x.EngineVolume,
                    HorsePower = x.HorsePower,
                    PassengerCount = x.PassengerCount,
                    VIN = x.VIN,
                    ImgUrl = x.ImgUrl
                })
                .ToListAsync();

            return Ok(cars);
        }


        // [HttpPost]
        // public async Task<IActionResult> AddCar([FromBody] Car car)
        // {
        //     try
        //     {
        //         await _context.Cars.AddAsync(car);
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (Exception ex)
        //     {
        //         return RedirectToPage("Error", new ErrorViewModel()
        //         {
        //             Message = ex.Message,
        //             StackTrace = ex.StackTrace
        //         });
        //     }
        //
        //     return Ok("success");
        // }
    }
}
