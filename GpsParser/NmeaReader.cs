using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpsParser
{
    public class NmeaReader
    {
        private List<Coordinate> coordinates = new List<Coordinate>();

        public NmeaReader(string fileName)
        {
            var lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                if (CheckGpgga(line))
                {
                    ParseGPS(line);
                }
            }
        }

        public List<Coordinate> GetCoordinates()
        {
            return coordinates;
        }

        private bool CheckGpgga(string line)
        {
            return string.Equals($"{line[3]}{line[4]}{line[5]}", "GGA", StringComparison.InvariantCultureIgnoreCase);
        }

        private void ParseGPS(string line)
        {
            var parts = line.Split(',');

            var newCoordinate = new Coordinate
            {
                FixTime = Conversion.ToDateTime(parts[1]),

                LatitudeType = parts[3],
                LongitudeType = parts[5],

                Latitude = Conversion.ToDecimalDegree(parts[2], parts[3]),
                Longitude = Conversion.ToDecimalDegree(parts[4], parts[5]),
                Altitude = double.Parse(parts[9]),

                AltitudeUnits = parts[10],

                FixQuality = int.Parse(parts[6]),
                NumberOfSatellites = int.Parse(parts[7]),
                Hdop = double.Parse(parts[8]),
                HeightOfGeoId = double.Parse(parts[11]),
                HeightOfGeoIdUnits = parts[12],
                TimeSpanSinceDgpsUpdate = parts[13],
                DgpsStationId = parts[14]
            };

            coordinates.Add(newCoordinate);
        }

    }
}
