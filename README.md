## GPS PARSER with C#

###### Gps Parser for files with the ".nmea" extension.

**$GPGGA,002153.000,3342.6618,N,11751.3858,W,1,10,1.2,27.0,M,-34.2,M,,0000*5E**

> Parameters

- **UTC Time:**                      002153.000 hhmmss.sss

- **Latitude:**                      3342.6618 ddmm.mmmm

- **N/S Indicator:**                 N N=north or S=south

- **Longitude:**                     11751.3858 dddmm.mmmm

- **E/W Indicator:**                 W E=east or W=west

- **Position Fix Indicator:**        https://www.sparkfun.com/datasheets/GPS/NMEA%20Reference%20Manual-Rev2.1-Dec07.pdf

- **Satellites Used:**               10 Range 0 to 12

- **HDOP:**                          1.2 Horizontal Dilution of Precision

- **MSL Altitude:**                  27.0 meters

- **Units:**                         M meters

- **Geoid Separation:**              -34.2 meters Geoid-to-ellipsoid separation.

- **Ellipsoid altitude:**            MSL Altitude + Geoid Separation.

- **Units:**                         M meters

- **Age of Diff. Corr. sec Null fields when DGPS is not used**

- **Diff. Ref. Station ID:**         0000

- **Checksum:**                      *5E

- **CR LF:**                         End of message termination

@senihcerit :bowtie:  - it's ready.
