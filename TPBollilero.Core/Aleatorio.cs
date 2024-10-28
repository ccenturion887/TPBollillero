using System;
namespace TPBollilero.Core;
public class Aleatorio : IAzar
{
  private List<int> bolillas;
  private Random random;

  public int Next(int minValue, int maxValue)
    {
      return random.Next(minValue, maxValue);
    }
}
