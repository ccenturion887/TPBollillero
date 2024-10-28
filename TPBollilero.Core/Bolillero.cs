using System;
using System.Collections.Generic;
using System.Linq;

public class Bolillero
{
    private List<int> bolillas;
    private IAzar azar;

    public Bolillero(int cantidadBolillas, IAzar azar)
    {
        bolillas = Enumerable.Range(0, cantidadBolillas).ToList();
        this.azar = azar;
    }

    public int SacarBolilla()
    {
        if (bolillas.Count == 0) throw new InvalidOperationException("No hay bolillas en el bolillero.");
        
        int index = azar.Next(0, bolillas.Count);
        int bolilla = bolillas[index];
        bolillas.RemoveAt(index);
        return bolilla;
    }

    public void ReIngresarBolilla(int bolilla)
    {
        if (!bolillas.Contains(bolilla)) bolillas.Add(bolilla);
    }

    public bool Jugar(List<int> jugada)
    {
        List<int> bolillasSacadas = new List<int>();
        
        foreach (var numero in jugada)
        {
            bolillasSacadas.Add(SacarBolilla());
        }

        bool acierto = bolillasSacadas.SequenceEqual(jugada);
        foreach (var bolilla in bolillasSacadas)
        {
            ReIngresarBolilla(bolilla);
        }

        return acierto;
    }

    public int JugarNVeces(List<int> jugada, int veces)
    {
        int aciertos = 0;
        for (int i = 0; i < veces; i++)
        {
            if (Jugar(jugada))
            {
                aciertos++;
            }
        }
        return aciertos;
    }

    public int CantidadBolillasDentro => bolillas.Count;
    public int CantidadBolillasFuera => 10 - bolillas.Count; // Suponiendo 10 bolillas originalmente
}
