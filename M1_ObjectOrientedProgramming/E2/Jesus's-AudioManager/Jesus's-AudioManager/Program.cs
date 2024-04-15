using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace Jesus_s_AudioManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine("Type a Vehicle");

                string vehicleOption = Console.ReadLine().ToLower();
                Vehiculo vehiculo = null;

                switch(vehicleOption)
                {
                    case "train":
                        vehiculo = new Tren();
                        break;

                    case "car":
                        vehiculo = new Automovil();
                        break;

                    case "truck":
                        vehiculo = new Camion();
                        break;


                    default:
                        Console.WriteLine("Vehicle Not Found");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }
                if (vehiculo != null)
                {
                    vehiculo.VehicleSound();
                }
                i++;
            }
        }
    }
}
