using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Apoderados
    {
        
            String _IdApoderado;
            String _Dui;
            String _TipoRelacion;
            String _NombresApoderado;
            String _Apellidos;
            String _Telefono;
            String _FechaNacimiento;
            String _IdDireccion;
            String _IdGenero;

            public string IdApoderado { get => _IdApoderado; set => _IdApoderado = value; }
            public string TipoRelacion { get => _TipoRelacion; set => _TipoRelacion = value; }
            public string NombresApoderado { get => _NombresApoderado; set => _NombresApoderado = value; }
            public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
            public string Telefono { get => _Telefono; set => _Telefono = value; }
            public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
            public string IdDireccion { get => _IdDireccion; set => _IdDireccion = value; }
            public string IdGenero { get => _IdGenero; set => _IdGenero = value; }
            public string Dui { get => _Dui; set => _Dui = value; }

        public Boolean Insertar()
            {
                Boolean Resultado = false;
                String Sentencia;
                Int32 FilasInsertadas = 0;
                try
                {
                    Sentencia = @"INSERT INTO apoderado(dui,tiporelacion, nombresapoderado, apellidos, telefono, fechanacimiento, direccion, idgenero) VALUES('" + _Dui + "','" + _TipoRelacion + "', '" + _NombresApoderado + "', '" + _Apellidos + "', '" + _Telefono + "', '" + _FechaNacimiento + "', '" + _IdDireccion + "', " + _IdGenero + ");";
                    DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                    FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                    if (FilasInsertadas > 0)
                    {
                        Resultado = true;
                    }
                }
                catch (Exception)
                {
                    Resultado = false;
                }
                return Resultado;
            }
            public Boolean Actualizar()
            {
                Boolean Resultado = false;
                String Sentencia;
                Int32 FilasInsertadas = 0;
                try
                {

                    Sentencia = @"UPDATE apoderado SET dui = '" + _Dui + "',tiporelacion = '" + _TipoRelacion + "', nombresapoderado = '" + _NombresApoderado + "', apellidos = '" + _Apellidos + "', telefono = '" + _Telefono + "', fechanacimiento = '" + _FechaNacimiento + "', direccion = '" + _IdDireccion + "', idgenero = " + _IdGenero + " " +
                    "WHERE idapoderado=" + _IdApoderado + ";";
                    DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                    FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                    if (FilasInsertadas > 0)
                    {
                        Resultado = true;
                    }
                }
                catch (Exception)
                {
                    Resultado = false;
                }
                return Resultado;
            }
            public Boolean Eliminar()
            {
                Boolean Resultado = false;
                String Sentencia;
                Int32 FilasEliminadas = 0;
                try
                {
                    Sentencia = @"DELETE FROM apoderado WHERE idapoderado=" + _IdApoderado + ";";
                    DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                    FilasEliminadas = Operacion.EjecutarSentencia(Sentencia);
                    if (FilasEliminadas > 0)
                    {
                        Resultado = true;
                    }
                }
                catch (Exception)
                {
                    Resultado = false;
                }
                return Resultado;
            }
        }
    }
