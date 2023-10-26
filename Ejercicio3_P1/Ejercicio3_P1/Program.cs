using Ejercicio3_P1;

internal class Program
{
    private static void Main(string[] args)
    {
        CelNuevoController controllerCel = new CelNuevoController();
        controllerCel.InsertarCelulares();
        controllerCel.PromedioCel();
        controllerCel.MarcaSamsung();
    }
}