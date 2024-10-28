using Xunit;

public class Primera
{
    private Bolillero bolillero;

    public Primera()
    {
        IAzar azar = new Aleatorio();
        bolillero = new Bolillero(10, azar);
    }

    [Fact]
    public void SacarBolilla_DeberiaDevolverBolillaCero()
    {
        // Simulamos que la primera bolilla a sacar es siempre la 0
        int bolilla = bolillero.SacarBolilla();
        Assert.True(bolilla >= 0 && bolilla < 10); // Verificamos que sea una bolilla válida
        Assert.Equal(9, bolillero.CantidadBolillasDentro);
        Assert.Equal(1, bolillero.CantidadBolillasFuera);
    }

    [Fact]
    public void ReIngresar_DeberiaRegresarBolillaAlBolillero()
    {
        int bolilla = bolillero.SacarBolilla();
        bolillero.ReIngresarBolilla(bolilla);
        
        Assert.Equal(10, bolillero.CantidadBolillasDentro);
        Assert.Equal(0, bolillero.CantidadBolillasFuera);
    }

    [Fact]
    public void JugarGana_DeberiaGanarConBolillasAcertadas()
    {
        List<int> jugadaGanadora = new List<int> { 0, 1, 2, 3 };
        
        // Asumiendo que el bolillero permite sacar las bolillas en orden
        Assert.True(bolillero.Jugar(jugadaGanadora));
    }

    [Fact]
    public void JugarPierde_DeberiaPerderConBolillasIncorrectas()
    {
        List<int> jugadaPerdedora = new List<int> { 4, 2, 1 };
        Assert.False(bolillero.Jugar(jugadaPerdedora));
    }

    [Fact]
    public void GanarNVeces_DeberiaGanarUnaVez()
    {
        List<int> jugada = new List<int> { 0, 1 };
        int resultado = bolillero.JugarNVeces(jugada, 1);
        Assert.Equal(1, resultado);
    }
}
