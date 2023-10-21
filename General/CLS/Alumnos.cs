using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Alumnos
    {
        String _IdAlumno;
        String _Nie;
        String _Nombres;
        String _Apellidos;
        String _FechaNacimiento;
        String _Telefono;
        String _IdGenero;
        String _IdEstado;
        String _IdApoderado;
        String _IdDireccion;

        public string IdAlumno { get => _IdAlumno; set => _IdAlumno = value; }
        public string Nie { get => _Nie; set => _Nie = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string IdGenero { get => _IdGenero; set => _IdGenero = value; }
        public string IdEstado { get => _IdEstado; set => _IdEstado = value; }
        public string IdApoderado { get => _IdApoderado; set => _IdApoderado = value; }
        public string IdDireccion { get => _IdDireccion; set => _IdDireccion = value; }
       

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO alumnos(nie, nombres, apellidos, fechanacimiento, telefono, idgenero, idestado,idapoderado,direccion) VALUES('" + _Nie + "', '" + _Nombres + "', '" + _Apellidos + "', '" + _FechaNacimiento + "', '" + _Telefono + "', " + _IdGenero + ", " + _IdEstado + "," + _IdApoderado + ",'" + _IdDireccion + "');";
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

                Sentencia = @"UPDATE alumnos SET nie = '" + _Nie + "', nombres = '" + _Nombres + "', apellidos = '" + _Apellidos + "', fechanacimiento = '" + _FechaNacimiento + "', telefono = '" + _Telefono + "', idgenero = " + _IdGenero + ", idestado = " + _IdEstado + ",idapoderado = " + _IdApoderado + ",direccion = '" + _IdDireccion + "' " +
                "WHERE idalumno=" + _IdAlumno + ";";
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
        public Boolean ActualizarEstado()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {

                Sentencia = @"UPDATE alumnos SET idestado = " + _IdEstado + " " +
                "WHERE idalumno=" + _IdAlumno + ";";
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
                Sentencia = @"DELETE FROM alumnos WHERE idalumno=" + _IdAlumno + ";";
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
