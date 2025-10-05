public class Cuenta
{
    private string idCuenta;

    public Cuenta(string prmtIdCuenta)
    {
        this.idCuenta = prmtIdCuenta;
        System.Console.WriteLine("Constructor Clase para cuenta {0}", prmtIdCuenta);
    }

    public virtual void CalcularIntereses()
    {
        System.Console.WriteLine("Cuenta.CalcularIntereses() efectado para la cuenta {0}", this.idCuenta);
    }

    public string getIdCuenta()
    {
        return this.idCuenta;
    }
}
