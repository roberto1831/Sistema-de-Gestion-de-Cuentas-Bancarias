namespace BusinessEntity;

public class CuentaBancaria
{
    public string NumeroCuenta { get; set; }
    public string Cliente { get; set; }
    public string Descripcion { get; set; }

    // Constructor con parámetros (si lo tienes)
    public CuentaBancaria(string numeroCuenta, string cliente, string descripcion)
    {
        NumeroCuenta = numeroCuenta;
        Cliente = cliente;
        Descripcion = descripcion;
    }

    // Constructor sin parámetros necesario para instanciar sin argumentos
    public CuentaBancaria() { }
}
