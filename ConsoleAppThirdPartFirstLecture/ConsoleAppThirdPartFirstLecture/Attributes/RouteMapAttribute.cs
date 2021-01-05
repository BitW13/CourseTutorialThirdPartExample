using System;

namespace ConsoleAppThirdPartFirstLecture.Attributes
{
    public class RouteMapAttribute : Attribute
    {
        public int[] Route { get; set; }

        public RouteMapAttribute(params int[] route)
        {
            _ = route ?? throw new ArgumentNullException();

            Route = route;
        }
    }
}
