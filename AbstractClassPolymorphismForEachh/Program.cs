// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main()
    {
        ///////CAR/////////
        // Birinci: Audi A6, 2023, 4 qapı, 530L baqaj, Avtomat, 240 km/s
        // İkinci: Kia K5, 2022, 4 qapı, 510L baqaj, Avtomat, 210 km/s
        // Üçüncü: Hyundai Sonata, 2021, 4 qapı, 480L baqaj, Avtomat, 205 km/s

        Car _car = new Car("Audi", "A6", 2023, "10-AA-101", 100, 240, 4, 530, true);
        Car _car1 = new Car("Kia", "K5", 2022, "20-BB-202", 100, 210, 4, 510, true);
        Car _car2 = new Car("Hyundai", "Sonata", 2021, "30-CC-303", 100, 205, 4, 480, true);


        // 2 Motorcycle obyekti yaradın:
        // Birinci: Kawasaki Ninja, 2023, 1000cc, Sport, yox sidecar, 300 km/s
        // İkinci: Ducati Monster, 2022, 937cc, Naked, yox sidecar, 250 km/s

        ////////MOTORCYCLE////////
        Motorcycle _motorcycle = new Motorcycle("Kawasaki", "Ninja", 2023, "40-DD-404", 100, 300, 1000, false, "Sport", "Kawasaki Ninja sport motosikletidir");
        Motorcycle _motorcycle1 = new Motorcycle("Ducati", "Monster", 2022, "50-EE-505", 100, 250, 937, false, "Naked", "Ducati Monster güclü şəhər motosudur");


        // 2 Truck obyekti yaradın:
        // Birinci: DAF XF, 2020, 20 ton tutum, 4 ox, 12 ton yük, 130 km/s
        // İkinci: Iveco Stralis, 2021, 28 ton tutum, 6 ox, 18 ton yük, 115 km/s

        ////////TRUCK////////
        Truck _truck = new Truck("DAF", "XF", 2020, "60-FF-606", 100, 130, 20, 4, 12);
        Truck _truck1 = new Truck("Iveco", "Stralis", 2021, "70-GG-707", 100, 115, 28, 6, 18);
    }
}
