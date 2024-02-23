
namespace Task
{
  class Circle
  {
    public readonly Point coord;
    public readonly double r;

    public Circle(Point coord, double r)
    {
      this.coord = coord;
      if (r < 0)
      {
        throw new InvalidRadiusException("Invalid radius given.");
      }
      this.r = r;
    }

    public bool IsWithinRadius(Point p)
    {
      return Math.Sqrt(Math.Pow(p.x - coord.x, 2) + Math.Pow(p.y - coord.y, 2)) < r;
    }
  }
}