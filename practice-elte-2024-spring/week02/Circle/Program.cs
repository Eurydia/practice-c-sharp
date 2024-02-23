// See https://aka.ms/new-console-template for more information

using TextFile;

namespace Task
{

  class Program
  {
    static void Main(string[] args)
    {
      double posX, posY, r;
      Circle c;

      try
      {
        TextFileReader tf = new TextFileReader("input.md");
        tf.ReadDouble(out posX);
        tf.ReadDouble(out posY);
        tf.ReadDouble(out r);
        c = new Circle(new Point(posX, posY), r);

        tf.ReadInt(out int size);
        for (int i = 0; i < size; i++)
        {
          tf.ReadDouble(out posX);
          tf.ReadDouble(out posY);
          Point p = new Point(posX, posY);
          if (c.IsWithinRadius(p))
          {
            Console.WriteLine("Found");
            return;
          }
        }
      }
      catch (FileNotFoundException)
      {
        return;
      }
      catch (ArgumentException)
      {
        return;
      }
    }
  }
}
