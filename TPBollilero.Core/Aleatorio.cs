using System;
namespace TPBollilero.Core;
public class Aleatorio
{
  private List<int> bolillas;
  private Random random;

  public Bolillero()
    {
        crearBolilla = Enumerable.Range(0, 10).ToList();
        random = new Random();
    }
}
