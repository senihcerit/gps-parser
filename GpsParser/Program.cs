using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GpsParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var nmeaReader = new NmeaReader("output.nmea"); // This file is yours NMEA file. And we get GPGGA format.
            
            var takenCoordinates = nmeaReader.GetCoordinates();

            foreach (var item in takenCoordinates)
            {
                Console.WriteLine(item.Latitude + item.LatitudeType + ", " + item.Longitude + item.LongitudeType +", " + item.Altitude + item.AltitudeUnits);
            }

            Console.ReadLine();
        }
    }
}
