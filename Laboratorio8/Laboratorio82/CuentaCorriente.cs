public class CuentaCorriente : Cuenta
{
    public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
    {
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine("CuentaCorriente.CalcularIntereses() efectuado para " + "La cuenta {0}", getIdCuenta());
    }
}