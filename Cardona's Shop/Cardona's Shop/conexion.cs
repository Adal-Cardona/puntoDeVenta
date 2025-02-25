using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta libreria permite trabajar cn estructuras de datos
using System.Data.SqlClient; //Permite trabajar con instrucciones SQL
using System.Windows.Forms;
using System.Data.Common;
using System.Collections;

namespace Cardona_s_Shop
{
    internal class conexion
    {
        SqlConnection conectada = new SqlConnection("Data Source = ADALCARDONAGAM; initial catalog = tiendaAbarrotes;Integrated Security = true");

        public void Conectar()
        {
            try
            {
                conectada.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void Desconectar()
        {
            conectada.Close();
        }

        //Seccion de pantalla de Inicio de Sesion
        

        

        //Trae la informacion del producto
        public DataTable consultarProducto(Int64 codigo)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select * From Inventario Where codigoBarras = @codigo", conectada);
                cmd.Parameters.Add("@codigo", SqlDbType.BigInt).Value = codigo;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }
        
        //Seccion de pantalla Ventas
        
        //Ingresa los datos del ticket
        public bool registroTicket(double total, DateTime fecha, int idEmpleado)
        {
            bool correcto = false;
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("INSERT INTO Ticket VALUES (@total, @fecha, @idEmpleado)", conectada);
                cmd.Parameters.Add("@total", SqlDbType.Money).Value = total;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
                cmd.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleado;
                cmd.ExecuteNonQuery();
                correcto = true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }

        //Ingresa toda la informacion a la tabla infoTicket

        public bool infoTicket(Int64 codigoBarras, int cantidad, double precioFinal)
        {
            bool correcto = false;
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select max(id) From ticket", conectada);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                int idTicket = Convert.ToInt32(dt.Rows[0][0].ToString());

                SqlCommand cmd2 = new SqlCommand("Insert Into infoTicket VALUES (@idTicket, @codigoBarras, @cantidad, @precioFinal)", conectada);
                cmd2.Parameters.Add("@idTicket", SqlDbType.Int).Value=idTicket;
                cmd2.Parameters.Add("@codigoBarras", SqlDbType.BigInt).Value=codigoBarras;
                cmd2.Parameters.Add("@cantidad", SqlDbType.Int).Value=cantidad;
                cmd2.Parameters.Add("@precioFinal", SqlDbType.Money).Value=precioFinal;
                cmd2.ExecuteNonQuery();
                correcto = true;

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
                restarStock(codigoBarras, cantidad);
            }

            return correcto;
        }

        public void restarStock(long codigoBarras, int cantidad)
        {
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("exec restarStock @codigoBarras, @cantidad", conectada);
                cmd.Parameters.Add("@codigoBarras", SqlDbType.BigInt).Value = codigoBarras;
                cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
        }



        //Seccion de pantalla Entradas de Inventario

        //Ingresar Entrada a Base de datos
        public bool EntradaInventario(int idEmpleado)
        {
            bool correcto = false;
            try
            {
                Conectar();

               
                SqlCommand cmd = new SqlCommand("Insert INto entradaInventario Values (@idEmpleado, @fecha)", conectada);
                cmd.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleado;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.ExecuteNonQuery();
                correcto = true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }

        //Insertar datos en tabla infoEntradaInventario

        public bool infoEntradaInventario(int idEmpleado, long codigoBarras, int cantidad)
        {
            bool correcto = false;
            DataTable dt = new DataTable();

            try
            {
                Conectar();

                SqlCommand cmd2 = new SqlCommand("Select max(id) From EntradaInventario", conectada);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(dt);
                int idEntrada = Convert.ToInt32(dt.Rows[0][0]);

                SqlCommand cmd = new SqlCommand("INSERT INTO infoEntradaInventario VALUES (@idEntrada, @idEmpleado, @codigoBarras, @cantidad)", conectada);
                cmd.Parameters.Add("@idEntrada", SqlDbType.Int).Value = idEntrada;
                cmd.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleado;
                cmd.Parameters.Add("@codigoBarras", SqlDbType.BigInt).Value = codigoBarras;
                cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
                cmd.ExecuteNonQuery();

                
                correcto = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
                aumentarStock(codigoBarras, cantidad);
            }
            return correcto;
        }
        public void aumentarStock(long codigoBarras, int cantidad)
        {
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("exec aumentarStock @codigoBarras, @cantidad", conectada);
                cmd.Parameters.Add("@codigoBarras", SqlDbType.BigInt).Value = codigoBarras;
                cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
                cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public bool borrarProducto(long id)
        {
            bool correcto = false;
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Delete From inventario where codigoBarras = @id", conectada);
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                cmd.ExecuteNonQuery();
                correcto = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }

        //Codigo ventana nuevoProducto

        public bool insertarNuevoProducto(long codigoBarras, string nombre, double precio, int stock, string departamento)
        {
            bool correcto = false;
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("INSERT INTO Inventario VALUES (@codigoBarras, @nombre, @precio, @stock, @departamento)", conectada);
                cmd.Parameters.Add("@codigoBarras", SqlDbType.BigInt).Value = codigoBarras;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@precio", SqlDbType.Int).Value = precio;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
                cmd.Parameters.Add("@departamento", SqlDbType.NVarChar).Value = departamento;
                cmd.ExecuteNonQuery();
                correcto = true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }


        //Codigo para pantalla CambiarInfoProducto

        public bool cambiarInformacionProductoPorID(long codigoBarras, string nombre, double precio, string departamento)
        {
            bool correcto = false;
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE inventario SET nombre = @nombre, precioUnidad = @precio, id_departamento = @departamento where codigoBarras = @codigoBarras", conectada);
                cmd.Parameters.Add("@codigoBarras", SqlDbType.BigInt).Value = codigoBarras;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@precio", SqlDbType.Money).Value = precio;
                cmd.Parameters.Add("@departamento", SqlDbType.NVarChar).Value = departamento;
                cmd.ExecuteNonQuery();
                correcto = true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }

        public bool cambiarInformacionProductoPorNombre(long codigoBarras, string nombre, int precio, string departamento)
        {
            bool correcto = false;
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE inventario SET codigoBarras = @codigoBarras, precioUnidad = @precio, id_departamento = @departamento where nombre = @nombre", conectada);
                cmd.Parameters.Add("@codigoBarras", SqlDbType.BigInt).Value = codigoBarras;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@precio", SqlDbType.Int).Value = precio;
                cmd.Parameters.Add("@departamento", SqlDbType.NVarChar).Value = departamento;
                cmd.ExecuteNonQuery();
                correcto = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }

        //Codigo para ventana nuevoEmpleado

        public bool insertarNuevoEmpleado(string pNombre, string sNombre, string pApellido, string sApellido, string departamento, int puesto, int edad, string rfc)
        {
            bool correcto = false;
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("INSERT INTO empleados VALUES (@pNombre, @sNombre, @pApellido, @sApellido, @departamento, @puesto, @edad, @rfc, @activo)", conectada);
                cmd.Parameters.Add("@pNombre", SqlDbType.NVarChar).Value = pNombre;
                cmd.Parameters.Add("@sNombre", SqlDbType.NVarChar).Value = sNombre;
                cmd.Parameters.Add("@pApellido", SqlDbType.NVarChar).Value = pApellido;
                cmd.Parameters.Add("@sApellido", SqlDbType.NVarChar).Value = sApellido;
                cmd.Parameters.Add("@departamento", SqlDbType.NVarChar).Value = departamento;
                cmd.Parameters.Add("@puesto", SqlDbType.Int).Value = puesto;
                cmd.Parameters.Add("@edad", SqlDbType.Int).Value = edad;
                cmd.Parameters.Add("@activo", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("@rfc", SqlDbType.NVarChar).Value = rfc;
                cmd.ExecuteNonQuery();
                correcto = true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }

        //Codigo para la pantalla cambioDeInfoEmpleados

        public bool actualizarDatosEmpleado(int id, string pNombre, string sNombre, string pApellido, string sApellido, string departamento, int puesto, int edad, string rfc, int activo)
        {
            bool correcto = false;

            try {
                Conectar();
                SqlCommand cmd = new SqlCommand("Update empleados Set primerNombre = @pNombre,  segundoNombre = @sNombre, primerApellido = @pApellido, segundoApellido = @sApellido, id_departamento = @departamento, id_puesto = @puesto, edad = @edad, rfc = @rfc, activo = @activo where id=@id", conectada);
                cmd.Parameters.Add("@pNombre", SqlDbType.NVarChar).Value = pNombre;
                cmd.Parameters.Add("@sNombre", SqlDbType.NVarChar).Value = sNombre;
                cmd.Parameters.Add("@pApellido", SqlDbType.NVarChar).Value = pApellido;
                cmd.Parameters.Add("@sApellido", SqlDbType.NVarChar).Value = sApellido;
                cmd.Parameters.Add("@departamento", SqlDbType.NVarChar).Value = departamento;
                cmd.Parameters.Add("@puesto", SqlDbType.Int).Value = puesto;
                cmd.Parameters.Add("@edad", SqlDbType.Int).Value = edad;
                cmd.Parameters.Add("@rfc", SqlDbType.NVarChar).Value = rfc;
                cmd.Parameters.Add("@activo", SqlDbType.Int).Value = activo;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
                correcto = true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }

        //Codigo Pantalla nuevosPuestos
        public bool insertarNuevoPuesto(string nombre, int ventas, int entradaInventario, int revisionStock, int productosNuevos, int infoEmpleados, int reporteVentas, int reporteInventarios, int cambios)
        {
            bool correcto = false;
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Insert INTO puestos VALUES (@nombre, @ventas, @entradaInventario, @revisionStock, @productosNuevos, @infoEmpleados, @reporteVentas, @reporteInventarios, @cambios)", conectada);
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@ventas", SqlDbType.Int).Value = ventas;
                cmd.Parameters.Add("@entradaInventario", SqlDbType.Int).Value = entradaInventario;
                cmd.Parameters.Add("@revisionStock", SqlDbType.Int).Value = revisionStock;
                cmd.Parameters.Add("@productosNuevos", SqlDbType.Int).Value = productosNuevos;
                cmd.Parameters.Add("@infoEmpleados", SqlDbType.Int).Value = infoEmpleados;
                cmd.Parameters.Add("@reporteVentas", SqlDbType.Int).Value = reporteVentas;
                cmd.Parameters.Add("@reporteInventarios", SqlDbType.Int).Value = reporteInventarios;
                cmd.Parameters.Add("@cambios", SqlDbType.Int).Value = cambios;
                cmd.ExecuteNonQuery();
                correcto=true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }

        public bool borrarPuesto(int id)
        {
            bool correcto = false;
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Delete From puestos where id = @id", conectada);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
                correcto = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }

        //Insertar Nuevos Departamentos
        public bool insertarNuevoDepa(string nombre, string siglas, int idGerente)
        {
            bool correcto = false;
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("INSERT INTO departamentos VALUES (@siglas, @nombre, @idGerente)", conectada);
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@siglas", SqlDbType.NVarChar).Value = siglas;
                cmd.Parameters.Add("@idGerente", SqlDbType.Int).Value = idGerente;
                cmd.ExecuteNonQuery();
                correcto = true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }

            return correcto;
        }

        public bool borrarDepartamento(string siglas)
        {
            bool correcto = false;
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Delete From departamentos where siglasDepartamento = @siglas",conectada);
                cmd.Parameters.Add("@siglas", SqlDbType.NVarChar).Value = siglas;
                cmd.ExecuteNonQuery();
                correcto = true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }

        public bool actualizarGerente(string siglas, int idEmpleado)
        {
            bool correcto = false;
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("UPDATE departamentos SET idGerente = @idEmpleado where siglasDepartamento = @siglas", conectada);
                cmd.Parameters.Add("@siglas", SqlDbType.NVarChar).Value = siglas;
                cmd.Parameters.Add("idEmpleado", SqlDbType.Int).Value = idEmpleado;
                cmd.ExecuteNonQuery();
                correcto = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return correcto;
        }

        //Consulta General InicioDeSesion
        public DataTable consultaGeneralInicioSesion()
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select * From inicioDeSesion", conectada);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

       
        //Consulta General Inventario

        public DataTable consultaGeneralInventario()
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select * From inventario order by nombre", conectada);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public DataTable consultaGeneralInventarioPorCodigo(long codigo)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select * From inventario Where codigoBarras like @codigo order by nombre", conectada);
                cmd.Parameters.Add("@codigo", SqlDbType.NVarChar).Value = "%" + codigo + "%";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public DataTable consultaGeneralInventarioPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select * From inventario Where nombre like @nombre order by nombre", conectada);
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = "%" + nombre + "%";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        //Consulta General Empleados

        public DataTable consultaGeneralEmpleados()
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select * From empleados order by primerApellido", conectada);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public DataTable consultaGeneralEmpleadosPorID(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select * From empleados where id = @id order by primerApellido", conectada);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }
        public DataTable consultaGeneralEmpleadosNomCompleto()
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select e.id as 'No.Empleado', CONCAT(e.primerApellido, ' ', e.segundoApellido, ' ', e.primerNombre, ' ', e.segundoNombre) as 'NombreCompleto', e.edad, e.rfc, d.nombre as 'departamento', p.nombre as 'puesto', e.activo From empleados e inner join departamentos d On e.id_departamento = d.siglasDepartamento inner join puestos p On e.id_puesto = p.id order by NombreCompleto;", conectada);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public DataTable consultaGeneralEmpleadosNomCompletoPorID(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select e.id as 'No.Empleado', CONCAT(e.primerApellido, ' ', e.segundoApellido, ' ', e.primerNombre, ' ', e.segundoNombre) as 'NombreCompleto', e.edad, e.rfc, d.nombre as 'departamento', p.nombre as 'puesto', e.activo From empleados e inner join departamentos d On e.id_departamento = d.siglasDepartamento inner join puestos p On e.id_puesto = p.id where e.id like @id order by NombreCompleto;", conectada);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = "%"+id+"%";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public DataTable consultaGeneralEmpleadosNomCompletoPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select e.id as 'No.Empleado', CONCAT(e.primerApellido, ' ', e.segundoApellido, ' ', e.primerNombre, ' ', e.segundoNombre) as 'NombreCompleto', e.edad, e.rfc, d.nombre as 'departamento', p.nombre as 'puesto', e.activo From empleados e inner join departamentos d On e.id_departamento = d.siglasDepartamento inner join puestos p On e.id_puesto = p.id where CONCAT(e.primerApellido, ' ', e.segundoApellido, ' ', e.primerNombre, ' ', e.segundoNombre) like @nombre order by NombreCompleto;", conectada);
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = "%" + nombre + "%";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        //Consulta General Puestos
        public DataTable consultaGeneralPuesto()
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select * From puestos order by nombre", conectada);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public DataTable consultaGeneralPuestoPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select * From puestos where nombre like @nombre order by nombre", conectada);
                cmd.Parameters.Add("@nombre",SqlDbType.NVarChar).Value = "%"+nombre + "%";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        //Consulta General Departamentos

        public DataTable consultaGeneralDepartamentos()
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select * From departamentos order by nombre", conectada);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public DataTable consultaGeneralDepartamentoPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("Select * From departamentos where nombre like @nombre order by nombre", conectada);
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = "%"+nombre + "%";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

    }

    
}
