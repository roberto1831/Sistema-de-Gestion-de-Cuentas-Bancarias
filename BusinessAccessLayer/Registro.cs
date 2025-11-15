
using BusinessEntity;
using DataAccessLayer;

namespace BusinessAccessLayer;




public class Registro
{
    private AccesoDatos datos = new AccesoDatos();

    public int Insertar(CuentaBancaria cuenta)
    {
        return datos.Insertar(cuenta);
    }

    public CuentaBancaria Buscar(string numeroCuenta)
    {
        return datos.BuscarPorNumero(numeroCuenta);
    }

    public int Actualizar(CuentaBancaria cuenta)
    {
        return datos.Actualizar(cuenta);
    }

    public int Eliminar(string numeroCuenta)
    {
        return datos.Eliminar(numeroCuenta);
    }
    public List<CuentaBancaria> ObtenerTodas()
    {
        return datos.ObtenerTodas();
    }
    
}
