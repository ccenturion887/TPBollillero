using System;
using System.Collections.Generic;
namespace TPBollilero.Core;
public class Bolillero
{
    public List<byte> Adentro {get ; set ;}
    public List<byte> Afuera {get ; set; }
    private IAzar azar;
    public Bolillero()
    {
        Adentro = new List<byte>();
        Afuera = new List<byte>();
    }
    private void crearBolilla()
}
