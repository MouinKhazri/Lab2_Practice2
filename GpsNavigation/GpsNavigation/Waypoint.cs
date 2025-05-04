namespace GpsNavigation
{
    // Define the Coordinate class with Latitude and Longitude properties
    public class Coordinate
    {
        public double Latitude { get; }
        public double Longitude { get; }

        public Coordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    public class Waypoint
    {
        public string Name { get; }
        public Coordinate Coordinates { get; }

        // Constructor that accepts name and coordinates (latitude, longitude)
        public Waypoint(string name, double latitude, double longitude)
        {
            Name = name;
            Coordinates = new Coordinate(latitude, longitude);
        }

        // Returns the coordinates as a tuple
        public (double latitude, double longitude) GetCoordinates()
            => (Coordinates.Latitude, Coordinates.Longitude);

        // Deconstructs the waypoint into latitude and longitude
        public void Deconstruct(out double latitude, out double longitude)
        {
            latitude = Coordinates.Latitude;
            longitude = Coordinates.Longitude;
        }
    }
}
