using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BusinessEntity;

namespace DataAccessLayer
{
    public class AccesoDatos
    {
      //  private string cadenaConexion = "Server=JESSY;Database=db_bancos;User Id=sa;Password=1234;";
          private string cadenaConexion = "Server=ROBERTOGAMER;Database=db_bancos;User Id=sa;Password=19851831;";

        // Insertar cuenta
        public int Insertar(CuentaBancaria c)
        {
            try
            {
                if (BuscarPorNumero(c.NumeroCuenta) != null)
                    return -1;

                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string sql = "INSERT INTO CuentaBancaria (NumeroCuenta, Cliente, Descripcion) VALUES (@num, @cli, @desc)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@num", c.NumeroCuenta);
                        cmd.Parameters.AddWithValue("@cli", c.Cliente);
                        cmd.Parameters.AddWithValue("@desc", c.Descripcion);

                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                return -2;
            }
        }

        // Buscar cuenta
        public CuentaBancaria BuscarPorNumero(string numero)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string sql = "SELECT NumeroCuenta, Cliente, Descripcion FROM CuentaBancaria WHERE NumeroCuenta = @num";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@num", numero);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new CuentaBancaria
                                {
                                    NumeroCuenta = reader.GetString(0),
                                    Cliente = reader.GetString(1),
                                    Descripcion = reader.GetString(2)
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Actualizar cuenta
        public int Actualizar(CuentaBancaria c)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string sql = "UPDATE CuentaBancaria SET Cliente = @cli, Descripcion = @desc WHERE NumeroCuenta = @num";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@cli", c.Cliente);
                        cmd.Parameters.AddWithValue("@desc", c.Descripcion);
                        cmd.Parameters.AddWithValue("@num", c.NumeroCuenta);

                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                return -2;
            }
        }

        // Eliminar cuenta
        public int Eliminar(string numero)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string sql = "DELETE FROM CuentaBancaria WHERE NumeroCuenta = @num";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@num", numero);
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                return -2;
            }
        }

        // Obtener todas las cuentas
        public List<CuentaBancaria> ObtenerTodas()
        {
            List<CuentaBancaria> lista = new List<CuentaBancaria>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string sql = "SELECT NumeroCuenta, Cliente, Descripcion FROM CuentaBancaria";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new CuentaBancaria
                                {
                                    NumeroCuenta = reader.GetString(0),
                                    Cliente = reader.GetString(1),
                                    Descripcion = reader.GetString(2)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Puedes registrar el error si deseas
                return new List<CuentaBancaria>(); // Devuelve lista vacía en caso de error
            }

            return lista;
        }
    }
}
