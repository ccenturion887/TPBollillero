using System;
using System.Collections.Generic;
namespace TPBollilero.Core;
public class Bolillero
{
    private List<int> bolillas;
    public List<byte> Adentro {get ; set ;}
    public List<byte> Afuera {get ; set; }
    public Bolilla int {get ; set;}
    private IAzar azar;
    public Bolillero()
    {
        Adentro = new ();
        Afuera = new ();
    }
    private void crearBolilla (Adentro adentro)
    {
        if(value>=9)
        {    
            trhow new ArgumentException("Cantidad maxima de bolillas")
        }
        Bolilla = value;
        Bolilla.Add.(Bolilla);
    }
    
}
