using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace PersonRepo.Data.Models;

public class Person : IAcademyEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    
    public int Age
    {
        get
        {
            DateTime today = DateTime.Now;

            if (today.Month > BirthDate.Month)
            {
                return today.Year - BirthDate.Year;
            }
            else if (today.Month < BirthDate.Month)
            {
                return today.Year - BirthDate.Year - 1;
            }
            else
            {
                if (today.Day >= BirthDate.Day)
                {
                    return today.Year - BirthDate.Year;
                }
                else
                {
                    return today.Year - BirthDate.Year - 1;
                }
            }
        }
    }

}