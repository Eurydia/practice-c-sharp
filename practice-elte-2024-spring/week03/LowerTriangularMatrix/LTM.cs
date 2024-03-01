
namespace Task
{
  class LTM
  {
    private int n = 0;
    private double[] v;
    public LTM(int n)
    {
      this.n = n;
      this.v = new double[(n * (n + 1)) / 2];
    }

    private static int Ind(int i, int j)
    {
      return j + (i * (i - 1) / 2);
    }
    public double GetElem(int i, int j)
    {
      if (i >= j)
      {
        return this.v[LTM.Ind(i, j)];
      }
      return 0.0;
    }

    public static LTM Add(LTM a, LTM b)
    {
      LTM c = new LTM(a.n);

      for (int i = 0; i < (a.n * (a.n + 1) / 2); i++)
      {
        c.v[i] = a.v[i] + b.v[i];
      }
      return c;
    }
    public static LTM Mul(LTM a, LTM b)
    {
      LTM c = new LTM(a.n);

      for (int i = 0; i < (a.n * (a.n + 1) / 2); i++)
      {
        for (int j = 0; j < (a.n * (a.n + 1) / 2); j++)
        {
          double curr = 0;
          if (i >= j)
          {
            for (int k = j; k < i; k++)
            {
              curr += a.v[LTM.Ind(i, k)] * b.v[LTM.Ind(k, j)];
            }
          }
          c.v[LTM.Ind(i, j)] = curr;
        }
      }
      return c;
    }
  }
}