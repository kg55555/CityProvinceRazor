using Microsoft.EntityFrameworkCore;
using CommunityApp.Models;

namespace CommunityApp.Data;

public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvince()
        );
        modelBuilder.Entity<City>().HasData(
            GetCity()
        );
    }
    public static List<Province> GetProvince() {
        List<Province> Province = new List<Province>() {
            new Province() {    // 1
                ProvinceCode="BC",
                ProvinceName="British Columbia",
                Cities={},
            },
            new Province() {    //2
                ProvinceCode="AB",
                ProvinceName="Alberta",
                Cities={},
            },
            new Province() {    // 3
                ProvinceCode="ON",
                ProvinceName="Ontario",
                Cities={},
            }
        };

        return Province;
    }

    public static List<City> GetCity() {
        List<City> City = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population = 10000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 2,
                CityName = "Edmonton",
                Population = 22222,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 3,
                CityName = "Whistler",
                Population = 9999,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 4,
                CityName = "Ottawa",
                Population = 10489,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 5,
                CityName = "Kelowna",
                Population = 2345,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 6,
                CityName = "Toronto",
                Population = 1239,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 7,
                CityName = "Calgary",
                Population = 109,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 8,
                CityName = "Kingston",
                Population = 8249,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 9,
                CityName = "Medicine Hat",
                Population = 23489,
                ProvinceCode = "AB"
            },
        };

        return City;
    }
}