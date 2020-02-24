using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpsParser
{
    public struct Coordinate
    {
        public DateTime FixTime;
        public double Latitude;
        public string LatitudeType;
        public double Longitude;
        public string LongitudeType;
        public int FixQuality;
        public int NumberOfSatellites;
        public double Hdop;
        public double Altitude;
        public string AltitudeUnits;
        public double HeightOfGeoId;
        public string HeightOfGeoIdUnits;
        public string TimeSpanSinceDgpsUpdate;
        public string DgpsStationId;
    }

    public static class Conversion
    {

        public static double ToDecimalDegree(string line, string type)
        {
            string degreeString = "", minutesString = "";
            switch (line.Length)
            {
                case 8:
                    degreeString = line.Substring(0, 2);
                    minutesString = line.Substring(2, 6);
                    break;
                case 9:
                    degreeString = line.Substring(0, 3);
                    minutesString = line.Substring(3, 6);
                    break;
                default:
                    Console.WriteLine("Problem at Conversion");
                    break;
            }

            if (type == "E" || type == "N")
            {
                return Math.Round(double.Parse(degreeString) + (double.Parse(minutesString, CultureInfo.InvariantCulture) / 60), 6);
            }

            return -1 * Math.Round(double.Parse(degreeString) + (double.Parse(minutesString, CultureInfo.InvariantCulture) / 60), 6);

        }

        public static DateTime ToDateTime(string stringDate)
        {
            return new DateTime(2020, 1, 1, int.Parse(stringDate.Substring(0, 2)),
                int.Parse(stringDate.Substring(2, 2)), int.Parse(stringDate.Substring(4, 2)));
        }

    }
}
