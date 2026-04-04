using System;
class EarthVolume{
    static void Main(){

        double radiusKm = 6378;
        double pi = Math.PI;

        // Volume in cubic kilometers
        double volumeKm = (4.0 / 3.0) * pi * radiusKm * radiusKm * radiusKm;

        // Convert radius to miles
        double radiusMiles = radiusKm * 0.621371;

        // Volume in cubic miles
        double volumeMiles = (4.0 / 3.0)*pi*radiusMiles*radiusMiles*radiusMiles;

        Console.WriteLine("The volume of earth in cubic kilometers is "+volumeKm+" and cubic miles is "+volumeMiles);
    }
}

