using RentaCarKDS.Models;

namespace RentaCarKDS.Data
{
    public static class CarRepository
    {
        private static List<Car> _cars = null;

        static CarRepository() // constructur
        {
            _cars = new List<Car>
            {
                //Veri tabanındaki kayıtlar
                new Car {Id = 105846, 
                    StartDate= "31.12.2023", 
                    FinishDate = "02.01.2023", 
                    DatePrice = 350,
                    ChassisNo = "26AXFA5WAEVN", 
                    Type = "Economic", 
                    Plate = "38 LI 010", 
                    DepartmentCity="Kayseri", 
                    Brand="Renault", 
                    Photo="2010-renault-kangoo-extreme.jpg"}, // Ekonomik parametre:0-499
                new Car {Id = 109963, 
                    StartDate= "01.11.2023", 
                    FinishDate = "12.11.2023", 
                    DatePrice = 559, 
                    ChassisNo = "611AZGB916IB", 
                    Type = "Standard", 
                    Plate = "34 HIZ 034", 
                    DepartmentCity="Muğla", 
                    Brand="Volkswagen", 
                    Photo="2023-volkswagen-passat-variant-highline.jpg"}, // Standart parametre:500-999
                new Car {Id = 109961, 
                    StartDate= "01.12.2023", 
                    FinishDate = "04.12.2023", 
                    DatePrice = 1248, 
                    ChassisNo = "912PRSH044BS", 
                    Type = "Premium", 
                    Plate = "48 MSK 001", 
                    DepartmentCity="İstanbul", 
                    Brand="Porsche", 
                    Photo="2022-porsche-911-carrera-gts.jpg"}, // Premium parametre:1000-...
                new Car {Id = 100398, 
                    StartDate= "03.04.2023", 
                    FinishDate = "04.05.2023", 
                    DatePrice = 540, 
                    ChassisNo = "ASD44DSC8AQB", 
                    Type = "Standard", 
                    Plate = "42 AS 661", 
                    DepartmentCity="Konya", 
                    Brand="Skoda", 
                    Photo="2023-skoda-superb-laurin-&-klement.jpg"},
                new Car {Id = 101248, 
                    StartDate= "14.10.2023", 
                    FinishDate = "25.10.2023", 
                    DatePrice = 661, 
                    ChassisNo = "CSDZ61ERG8QX", 
                    Type = "Standard", 
                    Plate = "58 NG 179", 
                    DepartmentCity="Sivas", 
                    Brand="Seat", 
                    Photo="2023-seat-leon-mk4-fr.jpeg"},
                new Car {Id = 105791, 
                    StartDate= "17.12.2023", 
                    FinishDate = "30.12.2023", 
                    DatePrice = 680, 
                    ChassisNo = "XV5QWD7VDS85", 
                    Type = "Standard", 
                    Plate = "35 KF 394", 
                    DepartmentCity="İzmir", 
                    Brand="Bmw", 
                    Photo="2023-bmw-320i-luxury.jpeg"},
                new Car {Id = 100395, 
                    StartDate= "03.01.2023", 
                    FinishDate = "20.01.2023", 
                    DatePrice = 505, 
                    ChassisNo = "AVA89QWFDF6Z", 
                    Type = "Premium", 
                    Plate = "34 BO 318", 
                    DepartmentCity="İstanbul", 
                    Brand="Mercedes-Benz", 
                    Photo="2023-mercedes-benz-c-class-180-avantgarde.jpg"},
                new Car {Id = 100393, 
                    StartDate= "04.10.2023", 
                    FinishDate = "19.10.2023", 
                    DatePrice = 415, 
                    ChassisNo = "JUI9L5SDF14A", 
                    Type = "Economic", 
                    Plate = "01 PL 916", 
                    DepartmentCity="Adana", 
                    Brand="Fiat", 
                    Photo="2023-fiat-egea-easy.jpeg"},
                new Car {Id = 100392, 
                    StartDate= "09.12.2023", 
                    FinishDate = "04.12.2023", 
                    DatePrice = 9841, 
                    ChassisNo = "SVA49AS419AC", 
                    Type = "Premium", 
                    Plate = "22 EST 013", 
                    DepartmentCity="Edirne", 
                    Brand="Audi", 
                    Photo="2023-audi-a3-sedan-35-tfsi.jpeg"},
                new Car {Id = 100391, 
                    StartDate= "20.09.2023", 
                    FinishDate = "24.09.2023", 
                    DatePrice = 1995, 
                    ChassisNo = "AV6B86TFOILK", 
                    Type = "Economic", 
                    Plate = "06 AA 001", 
                    DepartmentCity="Ankara", 
                    Brand="Renault", 
                    Photo="2023-renault-clio-equilibre.jpeg"},
                new Car {Id = 100361, 
                    StartDate= "22.09.2023", 
                    FinishDate = "29.09.2023", 
                    DatePrice = 5415, 
                    ChassisNo = "UK6HUL29ASCV", 
                    Type = "Economic", 
                    Plate = "48 AA 001", 
                    DepartmentCity="Muğla", 
                    Brand="Hyundai", 
                    Photo  ="2023-hyundai-i20-jump.jpeg"}
            };
        }
        public static List<Car> Cars 
        {
            get { return _cars; } 
        }
        public static void AddCar(Car car) // araba ekle
        {
            _cars.Add(car);
        }
        public static Car GetCarById(int id) // id getir
        {
            return _cars.FirstOrDefault(c => c.Id == id);
        }
        //public static void RemoveCar(Car car) { }
    }
}
