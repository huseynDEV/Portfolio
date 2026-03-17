using System;
namespace _17._03
{
    public class Vehicle
    {
        private string _brand;
        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if (value.Length >= 3)
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("Minumum 3 simvol olmalidir");
                }


            }
        }

        private string _model;
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value.Length >= 3)
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("Minumum 3 simvol olmalidir");
                }


            }
        }

        private int _year;
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value >= 1980)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("1900 den boyuk olmalidir");
                }


            }
        }
        public int MileageKm { get; set; }
        public bool IsRunning { get; set; }
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }


        public void StartEngine()
        {
            IsRunning = true;
            Console.WriteLine("Mühərrik işə salındı.");
        }


        public void StopEngine()
        {
            IsRunning = false;
            Console.WriteLine("Mühərrik söndürüldü.");
        }

        // 
        public virtual void Drive(int km)
        {
            if (IsRunning)
            {
                MileageKm += km;
                Console.WriteLine($"{km} km sürüldü.");
            }
            else
            {
                Console.WriteLine("Mühərrik işləmir, sürmək mümkün deyil!");
            }
        }
    }

}

