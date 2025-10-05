using Laboratorio89;

internal class Program
{
    private static void Main(string[] args)
    {
        Template temp1 = new Template();
        temp1.ponerVariable("Var1", "Valor 1");
        temp1.ponerVariable("Var2", "Valor 2");
        temp1.ponerVariable("Var3", "Valor 3");
        temp1.verHtml("<br>Texto de Prueba</br>");
    }
}
